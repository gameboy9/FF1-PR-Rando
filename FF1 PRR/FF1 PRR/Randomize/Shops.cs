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
		List<int> itemStores = new List<int> { iCornelia, iPravoka, iElfheim, iCrescentLake, iGaia, iOnrac };
		List<int> blackMagicStores = new List<int> { mbCornelia, mbPravoka, mbElfheim3, mbElfheim4, mbMelmond, mbCrescentLake, mbGaia7, mbGaia8, mbOnrac, mbLufenia };
		List<int> whiteMagicStores = new List<int> { mwCornelia, mwPravoka, mwElfheim3, mwElfheim4, mwMelmond, mwCrescentLake, mwGaia7, mwGaia8, mwOnrac, mwLufenia };
		List<int> allMagicStores = new List<int> { mbCornelia, mbPravoka, mbElfheim3, mbElfheim4, mbMelmond, mbCrescentLake, mbGaia7, mbGaia8, mbOnrac, mbLufenia, 
				mwCornelia, mwPravoka, mwElfheim3, mwElfheim4, mwMelmond, mwCrescentLake, mwGaia7, mwGaia8, mwOnrac, mwLufenia };

		List<int> allStores = new List<int>
		{
			wCornelia, wPravoka, wElfheim, wMelmond, wCrescentLake, wGaia,
			aCornelia, aPravoka, aElfheim, aMelmond, aCrescentLake, aGaia,
			iCornelia, iPravoka, iElfheim, iCrescentLake, iGaia, iOnrac
		};

		private class shopItem 
		{
			public int id;
			public int content_id; // Item
			public int group_id; // Store #
			public int coefficient = 0; // Inn/House of Healing cost
			public int purchase_limit = 0; // 0 = unlimited
		}

		List<shopItem> productList = new List<shopItem>();

		private List<shopItem> determineItems(List<int> items, List<int> stores, Random r1)
		{
			List<shopItem> shopDB = new List<shopItem>();

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
				shopItem newItem = new shopItem();
				newItem.id = 0;
				newItem.group_id = stores[storeNumItems.Select((elem, index) => new { elem, index }).First(p => p.elem > lnI).index];
				newItem.content_id = items[lnI];
				shopDB.Add(newItem);
			}

			return shopDB;
		}

		public Shops(Random r1, int randoLevel, string fileName, bool traditional)
		{
			List<shopItem> shopDB = new List<shopItem>();

			// Recreate product.csv with stuff.
			if (randoLevel == 1)
			{
				shopDB.AddRange(determineItems(new Weapons().shuffleTraditional(r1), weaponStores, r1));
				shopDB.AddRange(determineItems(new Armor().shuffleTraditional(r1), armorStores, r1));
				shopDB.AddRange(determineItems(traditional ? new Items().shuffleTraditional(r1) : new Items().shuffleModern(r1), itemStores, r1));

				// TODO:  Remove duplicates items from stores.
			}
			else
			{
				List<int> tierLimit = new List<int>
				{
					2, 3, 3, 4, 4, 5,
					2, 3, 3, 4, 4, 5,
					2, 2, 3, 3, 4, 5
				};
				int storeID = 0;

				foreach (int store in allStores)
				{
					int numberOfItems = r1.Next() % 8;
					for (int lnI = 0; lnI < numberOfItems; lnI++) 
					{
						shopItem newItem = new shopItem();
						int itemPct = r1.Next() % 100;
						newItem.group_id = store;

						// 75/95% chance to reduce tier by 1, 50/70% chance to reduce tier by 2 instead.
						int tier = tierLimit[storeID] -
							(itemPct <= (randoLevel == 2 ? 50 : 70) ? 2 : (itemPct <= (randoLevel == 2 ? 75 : 95) ? 1 : 0));
						tier = tier == 0 ? 1 : tier;

						if (weaponStores.Contains(store))
							newItem.content_id = new Weapons().selectItem(r1, randoLevel == 4 ? 0 : tier);
						else if (armorStores.Contains(store))
							newItem.content_id = new Armor().selectItem(r1, randoLevel == 4 ? 0 : tier);
						else if (itemStores.Contains(store))
							newItem.content_id = new Items().selectItem(r1, randoLevel == 4 ? 0 : tier, traditional);

						shopDB.Add(newItem);
					}
					storeID++;
				}

				// TODO:  Remove duplicates within each store.
			}
			shopDB.AddRange(determineItems(new Magic().shuffleShops(r1, 1), whiteMagicStores, r1));
			shopDB.AddRange(determineItems(new Magic().shuffleShops(r1, 2), blackMagicStores, r1));

			using (StreamWriter sw = new StreamWriter(fileName))
			{
				sw.WriteLine("id,content_id,group_id,coefficient,purchase_limit");
				int finalID = 0;
				foreach (shopItem si in shopDB)
				{
					finalID++;
					sw.WriteLine(finalID + "," + si.content_id + "," + si.group_id + "," + si.coefficient + "," + si.purchase_limit);
				}
				finalID++;
				sw.WriteLine("141,59,37,0,1");
				sw.WriteLine("142,34,38,0,0");
				sw.WriteLine("143,32,38,0,0");
				sw.WriteLine("145,35,38,0,0");
				sw.WriteLine("146,36,38,0,0");
				sw.WriteLine("201,0,101,30,0");
				sw.WriteLine("202,0,102,50,0");
				sw.WriteLine("203,0,103,100,0");
				sw.WriteLine("204,0,104,100,0");
				sw.WriteLine("205,0,105,200,0");
				sw.WriteLine("206,0,106,300,0");
				sw.WriteLine("207,0,107,500,0");
				sw.WriteLine("208,0,201,40,0");
				sw.WriteLine("209,0,202,80,0");
				sw.WriteLine("210,0,203,200,0");
				sw.WriteLine("211,0,204,400,0");
				sw.WriteLine("212,0,205,750,0");
				sw.WriteLine("213,0,206,750,0");
			}
		}
	}
}
