using CsvHelper;
using FF1_PRR.Inventory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF1_PRR.Common.Common;

namespace FF1_PRR.Inventory
{
	public class ShopItem
	{
		public int id { get; set; }
		public int content_id { get; set; } // Item
		public int group_id { get; set; } // Store #
		public int coefficient { get; set; } // Inn/House of Healing cost
		public int purchase_limit { get; set; } // 0 = unlimited
	}
	public class Product
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

		public static List<int> weaponStores = new List<int> { wCornelia, wPravoka, wElfheim, wMelmond, wCrescentLake, wGaia };
		public static List<int> armorStores = new List<int> { aCornelia, aPravoka, aElfheim, aMelmond, aCrescentLake, aGaia };
		public static List<int> itemStores = new List<int> { iCornelia, iPravoka, iElfheim, iCrescentLake, iGaia, iOnrac, caravan2 };
		public static List<int> blackMagicStores = new List<int> { mbCornelia, mbPravoka, mbElfheim3, mbElfheim4, mbMelmond, mbCrescentLake, mbGaia7, mbGaia8, mbOnrac, mbLufenia };
		public static List<int> whiteMagicStores = new List<int> { mwCornelia, mwPravoka, mwElfheim3, mwElfheim4, mwMelmond, mwCrescentLake, mwGaia7, mwGaia8, mwOnrac, mwLufenia };
		public static List<int> allMagicStores = new List<int> { mbCornelia, mbPravoka, mbElfheim3, mbElfheim4, mbMelmond, mbCrescentLake, mbGaia7, mbGaia8, mbOnrac, mbLufenia,
				mwCornelia, mwPravoka, mwElfheim3, mwElfheim4, mwMelmond, mwCrescentLake, mwGaia7, mwGaia8, mwOnrac, mwLufenia };

		public static List<int> allStores = new List<int>
		{
			wCornelia, wPravoka, wElfheim, wMelmond, wCrescentLake, wGaia,
			aCornelia, aPravoka, aElfheim, aMelmond, aCrescentLake, aGaia,
			iCornelia, iPravoka, iElfheim, iCrescentLake, iGaia, iOnrac, caravan2
		};


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

		public static List<ShopItem> readShopDB(string fileName)
		{
			List<ShopItem> shopDB = new List<ShopItem>();
			using (var reader = new StreamReader(fileName))
			using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				shopDB = csv.GetRecords<ShopItem>().ToList();
			}
			return shopDB;
		}

		public static void writeShopDB(string fileName, List<ShopItem> shopDB)
		{ 
			using (StreamWriter writer = new StreamWriter(fileName))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(shopDB);
			}
		}
	}
}
