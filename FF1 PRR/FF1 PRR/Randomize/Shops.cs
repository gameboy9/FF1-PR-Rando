using CsvHelper;
using FF1_PRR.Inventory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF1_PRR.Common.Common;

namespace FF1_PRR.Randomize
{
	public class Shops
	{
		private class ItemWithRank
		{
			public int id { get; set; } // used as the content ID in stores/chests
			public string name { get; set; } // English name
			public int type_id { get; set; } // 1=item, 2=weapon, 3=armor, 4=magic, 5=gil
			public int type_value { get; set; } // which item is it?
			public string rank { get; set; } // grade from F to S; X = exclude
		}

		private int rankToInt(string rank)
        {
			switch (rank)
            {
				case "F":
					return 0;
				case "E":
					return 1;
				case "D":
					return 2;
				case "C":
					return 3;
				case "B":
					return 4;
				case "A":
					return 5;
				case "S":
					return 6;
				case "X":
					return 7;
				default:
					return 7;
            }
        }
		private int determineMagicShop(int[,] magicMemory, int type, int level)
        {
			int[] spellShopLookup = {
										0,0,0,0,
										1,1,1,1,
										2,2,2,2,
										3,3,3,3,
										4,4,4,4,
										5,5,5,5,
										6,6,8,8,
										7,7,9,9
									};
			List<int> shop = (type == 1) ? Product.whiteMagicStores : Product.blackMagicStores;
			return shop[spellShopLookup[(level - 1)*4 + magicMemory[type - 1, level - 1]]];
		}

		private void placeNextItem(ShopItem shopEntry, ref List<int> productList, ref Dictionary<int, List<int>> shopInventories, ref HashSet<ShopItem> toRemove)
        {
			// check if we've seen this shop before
			if (shopInventories.TryGetValue(shopEntry.group_id, out List<int> inventory))
			{
				int i = 0;
				while (i < productList.Count)
				{
					// check if this shop contains the next item
					if (!inventory.Contains(productList[i]))
					{
						inventory.Add(productList[i]);
						shopInventories[shopEntry.group_id] = inventory;
						shopEntry.content_id = productList[i];
						productList.RemoveAt(i);
						break;
					}
					else
					{
						i++;
						continue;
					}
				}
				// if all possible items that can be placed are already in the store, remove this shop entry from the shopDB
				if (i == productList.Count)
				{
					toRemove.Add(shopEntry);
				}
			}
			else // this is a new store
			{
				shopInventories.Add(shopEntry.group_id, new List<int> { productList[0] });
				shopEntry.content_id = productList[0];
				productList.RemoveAt(0);
			}
		}

		private List<ShopItem> determineSpells(Magic magicData)
        {
			List<ShopItem> magicShopDB = new List<ShopItem>();
			int[,] magicMemory = new int[2, 8];
			int productID = 250;

			foreach (Magic.ability spell in magicData.getRecords())
            {
				if (spell.ability_group_id == 1 && spell.id != Magic.DUPE_CURE_4) //if it's a spell and not chaos's special Cure4
                {
					ShopItem newItem = new ShopItem();
					newItem.id = productID++;
					newItem.content_id = spell.id + 208; //Magic Constant for Ability ID -> shop ID map
					newItem.group_id = determineMagicShop(magicMemory, spell.type_id, spell.ability_lv);
					magicMemory[spell.type_id - 1, spell.ability_lv - 1]++;
					magicShopDB.Add(newItem);
				}
            }

			return magicShopDB;
		}

		public Shops(Random r1, int randoLevel, string fileName, bool traditional)
		{
			List<ShopItem> shopDB = Product.readShopDB(fileName);

			// Shuffle existing items
			if (randoLevel == 1)
			{
				// TODO:  Guarantee no duplicates in stores

				List<int> weaponList = new List<int>();
				List<int> armorList = new List<int>();
				List<int> itemList = new List<int>();
				int max_id = 0;

				foreach (ShopItem product in shopDB)
				{
					max_id = Math.Max(max_id, product.id + 1);
					if (Product.weaponStores.Contains(product.group_id))

					{
						weaponList.Add(product.content_id);
					}
					else if (Product.armorStores.Contains(product.group_id))
					{
						armorList.Add(product.content_id);
					}
					else if (Product.itemStores.Contains(product.group_id))
					{
						itemList.Add(product.content_id);
					}
					else continue;
				}
				weaponList.Shuffle(r1);
				armorList.Shuffle(r1);
				itemList.Shuffle(r1);

				// a dictionary containing the current inventories of every shop so far
				Dictionary<int, List<int>> shopInventories = new Dictionary<int, List<int>>();

				// a list of entries to remove from the database if no item can be placed in that shop
				var toRemove = new HashSet<ShopItem>();

				foreach (ShopItem product in shopDB)
				{
					if (Product.weaponStores.Contains(product.group_id))
					{
						placeNextItem(product, ref weaponList, ref shopInventories, ref toRemove);
					}
					else if (Product.armorStores.Contains(product.group_id))
					{
						placeNextItem(product, ref armorList, ref shopInventories, ref toRemove);
					}
					else if (Product.itemStores.Contains(product.group_id))
					{
						placeNextItem(product, ref itemList, ref shopInventories, ref toRemove);
					}
					else continue;
				}

				shopDB.RemoveAll(toRemove.Contains);

				ShopItem fixAntidote = new();
				fixAntidote.id = max_id;
				fixAntidote.content_id = Items.antidote;
				fixAntidote.group_id = 3; // iCornelia
				shopDB.Add(fixAntidote);

				ShopItem fixGoldNeedle = new();
				fixGoldNeedle.id = max_id+1;
				fixGoldNeedle.content_id = Items.goldNeedle;
				fixGoldNeedle.group_id = 3; // iCornelia
				shopDB.Add(fixGoldNeedle);
			}
			else // Generate new shop contents
			{
				/*
				List<int> tierLimit = new List<int>
				{
					2, 3, 3, 4, 4, 
					5, 2, 3, 3, 4, 4, 5,
					2, 2, 3, 3, 4, 5
				};
				int storeID = 0;

				foreach (int store in allStores)
				{
					int numberOfItems = r1.Next() % 8;
					for (int lnI = 0; lnI < numberOfItems; lnI++) 
					{
						ShopItem newItem = new ShopItem();
						int itemPct = r1.Next() % 100;
						newItem.group_id = store;

						// 75/95% chance to reduce tier by 1, 50/70% chance to reduce tier by 2 instead.
						int tier = tierLimit[storeID] -
							(itemPct <= ((randoLevel == 2) ? 50 : 70) ? 2 : (itemPct <= ((randoLevel == 2) ? 75 : 95) ? 1 : 0));
						tier = (tier == 0) ? 1 : tier;

						if (weaponStores.Contains(store))
							newItem.content_id = new Weapons().selectItem(r1, (randoLevel == 4) ? 0 : tier);
						else if (armorStores.Contains(store))
							newItem.content_id = new Armor().selectItem(r1, (randoLevel == 4) ? 0 : tier);
						else if (itemStores.Contains(store))
							newItem.content_id = new Items().selectItem(r1, (randoLevel == 4) ? 0 : tier, traditional);

						shopDB.Add(newItem);
					}
					storeID++;
				}
				*/
				// TODO:  Remove duplicates within each store.
			}

			/*
			// Get all possible inventory items with rank information
			List<ItemWithRank> contentWithRank = new List<ItemWithRank>();
			using (var reader = new StreamReader(Path.Combine("data", "contentRank.csv")))
			using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				contentWithRank = csv.GetRecords<ItemWithRank>().ToList();
			}
				
			// split the contentWithRank into items, weapons, and armor
			List<ItemWithRank> itemsWithRank = new List<ItemWithRank>();
			List<ItemWithRank> weaponsWithRank = new List<ItemWithRank>();
			List<ItemWithRank> armorWithRank = new List<ItemWithRank>();
			foreach (ItemWithRank item in contentWithRank)
            {
				if (item.rank == "X") continue;
				switch (item.type_id)
                {
					case 1:
						itemsWithRank.Add(item);
						continue;
					case 2:
						weaponsWithRank.Add(item);
						continue;
					case 3:
						armorWithRank.Add(item);
						continue;
					default:
						continue;
                }
            }
			*/

			Product.writeShopDB(fileName,shopDB);
		}
	}
}
