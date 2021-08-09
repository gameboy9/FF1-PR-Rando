using FF1_PRR.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		const int mbElfheim3 = 15;
		const int mwElfheim4 = 16;
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

		List<int> weapons = new List<int> { wCornelia, wPravoka, wElfheim, wMelmond, wCrescentLake, wGaia };
		List<int> armor = new List<int> { aCornelia, aPravoka, aElfheim, aMelmond, aCrescentLake, aGaia };
		List<int> items = new List<int> { iCornelia, iPravoka, iElfheim, iCrescentLake, iGaia, iOnrac };
		List<int> blackMagic = new List<int> { mbCornelia, mbPravoka, mbElfheim3, mbElfheim4, mbMelmond, mbCrescentLake, mbGaia7, mbGaia8, mbOnrac, mbLufenia };
		List<int> whiteMagic = new List<int> { mwCornelia, mwPravoka, mwElfheim3, mwElfheim4, mwMelmond, mwCrescentLake, mwGaia7, mwGaia8, mwOnrac, mwLufenia };

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

		public Shops(Random r1, int randoLevel, string fileName, bool traditional)
		{
			List<shopItem> shopDB = new List<shopItem>();

			// Recreate product.csv with stuff.
			int finalID = 0;
			if (randoLevel == 1)
			{
				List<int> weapons = new Weapons().shuffleTraditional(r1);
				List<int> armor = new Armor().shuffleTraditional(r1);
				List<int> items = traditional ? new Items().shuffleTraditional(r1) : new Items().shuffleModern(r1);

				// TODO:  Draw numbers at random for each store.  No duplicates.  Shuffle items from there.  Remove duplicate items.
			} else
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
						finalID++;
						newItem.id = finalID;
						newItem.group_id = store;

						// 75/95% chance to reduce tier by 1, 50/70% chance to reduce tier by 2 instead.
						int tier = tierLimit[storeID] -
							(itemPct <= (randoLevel == 2 ? 50 : 70) ? 2 : (itemPct <= (randoLevel == 2 ? 75 : 95) ? 1 : 0));
						tier = tier == 0 ? 1 : tier;

						if (weapons.Contains(store))
							newItem.content_id = new Weapons().selectItem(r1, randoLevel == 4 ? 0 : tier);
						else if (armor.Contains(store))
							newItem.content_id = new Armor().selectItem(r1, randoLevel == 4 ? 0 : tier);
						else if (items.Contains(store))
							newItem.content_id = new Items().selectItem(r1, randoLevel == 4 ? 0 : tier, traditional);

						shopDB.Add(newItem);
					}
					storeID++;
				}
			}
		}
	}
}
