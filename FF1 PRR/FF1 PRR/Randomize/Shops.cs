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
		// Let's const the stores
		const int wCornelia = 1;
		const int aCornelia = 2;
		const int iCornelia = 3;
		const int mwCornelia = 4;
		const int mbCornelia = 5;
		const int wPravoka = 6;
		const int aPravoka = 7;
		const int iPravoka = 8;
		const int mwPravoka = 9;
		const int mbPravoka = 10;
		const int wElfheim = 11;
		const int aElfheim = 12;
		const int iElfheim = 13;
		const int mwElfheim3 = 14;
		const int mbElfheim3 = 16;
		const int mwElfheim4 = 15;
		const int mbElfheim4 = 17;
		const int wMelmond = 18;
		const int aMelmond = 19;
		const int mwMelmond = 20;
		const int mbMelmond = 21;
		const int wCrescentLake = 22;
		const int aCrescentLake = 23;
		const int iCrescentLake = 24;
		const int mwCrescentLake = 25;
		const int mbCrescentLake = 26;
		const int iGaia = 27;
		const int mwGaia7 = 28;
		const int mbGaia7 = 29;
		const int wGaia = 30;
		const int aGaia = 31;
		const int iOnrac = 32;
		const int mwOnrac = 33;
		const int mbOnrac = 34;
		const int mwLufenia = 35;
		const int mbLufenia = 36;
		const int caravan1 = 37;
		const int caravan2 = 38;
		const int mwGaia8 = 39;
		const int mbGaia8 = 40;

		List<int> weaponStores = new List<int> { wCornelia, wPravoka, wElfheim, wMelmond, wCrescentLake, wGaia };
		List<int> armorStores = new List<int> { aCornelia, aPravoka, aElfheim, aMelmond, aCrescentLake, aGaia };
		List<int> itemStores = new List<int> { iCornelia, iPravoka, iElfheim, iCrescentLake, iGaia, iOnrac, caravan2 };
		List<int> blackMagicStores = new List<int> { mbCornelia, mbPravoka, mbElfheim3, mbElfheim4, mbMelmond, mbCrescentLake, mbGaia7, mbGaia8, mbOnrac, mbLufenia };
		List<int> whiteMagicStores = new List<int> { mwCornelia, mwPravoka, mwElfheim3, mwElfheim4, mwMelmond, mwCrescentLake, mwGaia7, mwGaia8, mwOnrac, mwLufenia };
		List<int> allMagicStores = new List<int> { mbCornelia, mbPravoka, mbElfheim3, mbElfheim4, mbMelmond, mbCrescentLake, mbGaia7, mbGaia8, mbOnrac, mbLufenia,
				mwCornelia, mwPravoka, mwElfheim3, mwElfheim4, mwMelmond, mwCrescentLake, mwGaia7, mwGaia8, mwOnrac, mwLufenia };

		List<int> allStores = new List<int>
		{
			wCornelia, wPravoka, wElfheim, wMelmond, wCrescentLake, wGaia,
			aCornelia, aPravoka, aElfheim, aMelmond, aCrescentLake, aGaia,
			iCornelia, iPravoka, iElfheim, iCrescentLake, iGaia, iOnrac, caravan2
		};

		private class ShopItem
		{
			public int id { get; set; }
			public int content_id { get; set; } // Item
			public int group_id { get; set; } // Store #
			public int coefficient { get; set; } // Inn/House of Healing cost
			public int purchase_limit { get; set; } // 0 = unlimited
		}

		private class ItemWithRank
		{
			public int id { get; set; } // used as the content ID in stores/chests
			public string name { get; set; } // English name
			public int type_id { get; set; } // 1=item, 2=weapon, 3=armor, 4=magic, 5=gil
			public int type_value { get; set; } // which item is it?
			public string rank { get; set; } // grade from F to S; X = exclude
		}


		private List<ShopItem> determineItems(List<int> items, List<int> stores, Random r1)
		{
			List<ShopItem> shopDB = new List<ShopItem>();

			List<int> storeNumItems = new List<int>();
			bool duplicates = true;
			while (duplicates)
			{
				storeNumItems.Clear();
				for (int lnI = 0; lnI < stores.Count - 1; lnI++)
					storeNumItems.Add(r1.Next() % items.Count);
				storeNumItems.Add(items.Count);
				duplicates = storeNumItems.AreAnyDuplicates();
			}
			storeNumItems.Sort();
			for (int lnI = 0; lnI < items.Count; lnI++)
			{
				ShopItem newItem = new ShopItem();
				newItem.id = 0;
				newItem.group_id = stores[storeNumItems.Select((elem, index) => new { elem, index }).First(p => p.elem > lnI).index];
				newItem.content_id = items[lnI];
				shopDB.Add(newItem);
			}

			return shopDB;
		}

		List<ShopItem> shopDB = new List<ShopItem>();
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
			int[,,] spellShopLookup = {
										{
											{ whiteMagicStores[0], whiteMagicStores[0], whiteMagicStores[0], whiteMagicStores[0]},
											{ whiteMagicStores[1], whiteMagicStores[1], whiteMagicStores[1], whiteMagicStores[1]},
											{ whiteMagicStores[2], whiteMagicStores[2], whiteMagicStores[2], whiteMagicStores[2]},
											{ whiteMagicStores[3], whiteMagicStores[3], whiteMagicStores[3], whiteMagicStores[3]},
											{ whiteMagicStores[4], whiteMagicStores[4], whiteMagicStores[4], whiteMagicStores[4]},
											{ whiteMagicStores[5], whiteMagicStores[5], whiteMagicStores[5], whiteMagicStores[5]},
											{ whiteMagicStores[6], whiteMagicStores[6], whiteMagicStores[8], whiteMagicStores[8]},
											{ whiteMagicStores[7], whiteMagicStores[7], whiteMagicStores[9], whiteMagicStores[9]}
										},
										{
											{ blackMagicStores[0], blackMagicStores[0], blackMagicStores[0], blackMagicStores[0]},
											{ blackMagicStores[1], blackMagicStores[1], blackMagicStores[1], blackMagicStores[1]},
											{ blackMagicStores[2], blackMagicStores[2], blackMagicStores[2], blackMagicStores[2]},
											{ blackMagicStores[3], blackMagicStores[3], blackMagicStores[3], blackMagicStores[3]},
											{ blackMagicStores[4], blackMagicStores[4], blackMagicStores[4], blackMagicStores[4]},
											{ blackMagicStores[5], blackMagicStores[5], blackMagicStores[5], blackMagicStores[5]},
											{ blackMagicStores[6], blackMagicStores[6], blackMagicStores[8], blackMagicStores[8]},
											{ blackMagicStores[7], blackMagicStores[7], blackMagicStores[9], blackMagicStores[9]}
										}
									};
			return spellShopLookup[type - 1, level - 1, magicMemory[type - 1, level - 1]];
		}

		private List<ShopItem> determineSpells(Magic magicData)
        {
			List<ShopItem> shopDB = new List<ShopItem>();
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
					shopDB.Add(newItem);
				}
            }

			return shopDB;
		}

		public Shops(Random r1, int randoLevel, string fileName, bool traditional, Magic magicData)
		{
			using (var reader = new StreamReader(fileName))
			using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				shopDB = csv.GetRecords<ShopItem>().ToList();
			}


			// Shuffle existing items
			if (randoLevel == 1)
			{
				// TODO:  Guarantee no duplicates in stores

				List<int> weaponList = new List<int>();
				List<int> armorList = new List<int>();
				List<int> itemList = new List<int>();

				foreach (ShopItem product in shopDB)
                {
					if (weaponStores.Contains(product.group_id))
					{
						weaponList.Add(product.content_id);
						continue;
					}
					else if (armorStores.Contains(product.group_id))
					{
						armorList.Add(product.content_id);
						continue;
					}
					else if (itemStores.Contains(product.group_id))
					{
						itemList.Add(product.content_id);
						continue;
					}
					else continue;
				}
				weaponList.Shuffle(r1);
				armorList.Shuffle(r1);
				itemList.Shuffle(r1);
				foreach (ShopItem product in shopDB)
				{
					if (weaponStores.Contains(product.group_id))
					{
						product.content_id = weaponList[0];
						weaponList.RemoveAt(0);
						continue;
					}
					else if (armorStores.Contains(product.group_id))
					{
						product.content_id = armorList[0];
						armorList.RemoveAt(0); 
						continue;
					}
					else if (itemStores.Contains(product.group_id))
					{
						product.content_id = itemList[0];
						itemList.RemoveAt(0); 
						continue;
					}
					else continue;
				}
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

			//clear out 

			shopDB.AddRange(determineSpells(magicData));

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
			// shopDB.AddRange(determineItems(new Magic().shuffleShops(r1, 1), whiteMagicStores, r1));
			// shopDB.AddRange(determineItems(new Magic().shuffleShops(r1, 2), blackMagicStores, r1));

			using (StreamWriter writer = new StreamWriter(fileName))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(shopDB);
			}
		}
	}
}
