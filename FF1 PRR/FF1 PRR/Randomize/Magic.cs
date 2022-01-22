using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF1_PRR.Common.Common;
using FF1_PRR.Inventory;

namespace FF1_PRR.Inventory
{
	public class Magic
	{
		enum whiteMagic
		{
			wCure = 213,
			wProtect = 214,
			wDia = 215,
			wBlink = 216,
			wInvis = 221,
			wSilence = 222,
			wBlindna = 223,
			wNulShock = 224,
			wCura = 229,
			wNulBlaze = 230,
			wDiara = 231,
			wHeal = 232,
			wPoisona = 237,
			wNulFrost = 238,
			wFear = 239,
			wVox = 240,
			wCuraga = 245,
			wDiaga = 246,
			wLife = 247,
			wHealara = 248,
			wStona = 253,
			wProtera = 254,
			wExit = 255,
			wInvisira = 256,
			wCuraja = 261,
			wNulDeath = 262,
			wDiaja = 263,
			wHealaga = 264,
			wFullLife = 269,
			wNulAll = 270,
			wHoly = 271,
			wDispel = 272
		}

		enum blackMagic
		{
			bFire = 217,
			bFocus = 218,
			bSleep = 219,
			bThunder = 220,
			bBlizzard = 225,
			bTemper = 226,
			bDark = 227,
			bSlow = 228,
			bFira = 233,
			bThundara = 234,
			bHold = 235,
			bFocara = 236,
			bSleepra = 241,
			bConfuse = 242,
			bHaste = 243,
			bBlizzara = 244,
			bFiraga = 249,
			bTeleport = 250,
			bScourge = 251,
			bSlowra = 252,
			bThundaga = 257,
			bQuake = 258,
			bDeath = 259,
			bStun = 260,
			bBlizzaga = 265,
			bSaber = 266,
			bBreak = 267,
			bBlind = 268,
			bFlare = 273,
			bWarp = 274,
			bStop = 275,
			bKill = 276
		}

		public static List<int> bAll = Enum.GetValues(typeof(blackMagic)).Cast<int>().ToList();
		public static List<int> wAll = Enum.GetValues(typeof(whiteMagic)).Cast<int>().ToList();
		public static List<int> all = bAll.Concat(wAll).ToList();

		public static int WHITE_MAGIC = 1;
		public static int BLACK_MAGIC = 2;
		public static int DUPE_CURE_4 = 100;

		private List<ability> records;
		private string file;
		private string productpath;

		public Magic(Random r1, int randoLevel, string fileName, string product, bool shuffleShops, bool keepPermissions)
        {
			file = fileName;
			productpath = product;
			using (StreamReader reader = new StreamReader(fileName))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				records = csv.GetRecords<ability>().ToList();
			}
			shuffleMagic(r1, randoLevel, shuffleShops, keepPermissions);
		}

		public List<ability> getRecords()
        {
			return records;
        }

		public void writeToFile()
        {
			using (StreamWriter writer = new StreamWriter(file))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}

		public class ability
		{
			public int id { get; set; }
			public int sort_id { get; set; }
			public int ability_lv { get; set; }
			public int ability_group_id { get; set; }
			public int type_id { get; set; }
			public int attribute_id { get; set; }
			public int attribute_group_id { get; set; }
			public int system_id { get; set; }
			public int use_value { get; set; }
			public int standard_value { get; set; }
			public int adding_hit_rate { get; set; }
			public int valid_hit_rate { get; set; }
			public int weak_hit_rate { get; set; }
			public int attack_count { get; set; }
			public int accuracy_rate { get; set; }
			public int Impact_status { get; set; }
			public int use_job_group_id { get; set; }
			public int condition_group_id { get; set; }
			public int renge_id { get; set; }
			public int menu_renge_id { get; set; }
			public int battle_renge_id { get; set; }
			public int content_flag_group_id { get; set; }
			public int invalid_reflection { get; set; }
			public int invalid_boss { get; set; }
			public int resistance_attribute { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int menu_se_asset_id { get; set; }
			public int reaction_type { get; set; }
			public int menu_function_group_id { get; set; }
			public int battle_function_group_id { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
			public int ability_wait { get; set; }
			public string process_prog { get; set; }
			public int data_a { get; set; }
			public int data_b { get; set; }
			public int data_c { get; set; }
		}

		public void shuffleMagic(Random r1, int randoLevel, bool shuffleShops,  bool keepPermissions)
		{
			// Shuffle levels and price between the white spells and then the black spells.
			List<int> wMagic = new List<int> {
				4, 5, 6, 7,
				12, 13, 14, 15,
				20, 21, 22, 23,
				28, 29, 30, 31,
				36, 37, 38, 39,
				44, 45, 46, 47,
				52, 53, 54, 55,
				60, 61, 62, 63
			};
			List<int> bMagic = new List<int> {
				8, 9, 10, 11,
				16, 17, 18, 19,
				24, 25, 26, 27,
				32, 33, 34, 35,
				40, 41, 42, 43,
				48, 49, 50, 51,
				56, 57, 58, 59,
				64, 65, 66, 67
			};

			if (randoLevel == 1 || randoLevel == 2) // Standard and Pro
			{
				List<ability> spellbook = new List<ability>();
				List<int> levels = new List<int>();
				List<int> prices = new List<int>();
				// we have to go through it twice to get the level and price index in the correct order...
				foreach (ability spell in records)
				{
					if (spell.ability_group_id == 1 && spell.type_id == 1 && spell.id != DUPE_CURE_4)
					{
						spellbook.Insert(0, spell);
						spellbook[0].sort_id = spell.id + r1.Next(0, 100);
						levels.Add(spell.ability_lv);
						prices.Add(spell.buy);
					}
                }
				foreach (ability spell in records)
				{
					if (spell.ability_group_id == 1 && spell.type_id == 2 && spell.id != DUPE_CURE_4)
					{
						spellbook.Insert(0, spell);
						spellbook[0].sort_id = spell.id + r1.Next(0, 100);
						levels.Add(spell.ability_lv);
						prices.Add(spell.buy);
					}
				}
				if (randoLevel == 2)
                {
					// swap items by family
					sortByFamily(spellbook);
                }
				// sort by school, then sort ID
				spellbook.Sort((x, y) => {
					int bySchool = x.type_id.CompareTo(y.type_id);
					if (bySchool == 0)
                    {
						return x.sort_id.CompareTo(y.sort_id);
					}
					return bySchool;
				});

				foreach (ability spell in spellbook)
				{
					spell.ability_lv = levels[0];
					spell.buy = prices[0];
					levels.RemoveAt(0);
					prices.RemoveAt(0);
				}
			}
			
			if (randoLevel == 3 || randoLevel == 4) // Wild and Chaos
			{
				// just make 640 swaps per type to randomize
				for (int lnI = 0; lnI < 1280; lnI++)
				{
					List<int> magic = lnI < 640 ? wMagic : bMagic; 

					int ln1 = magic[r1.Next() % magic.Count];
					int ln2 = magic[r1.Next() % magic.Count];
					int buy = records[ln1].buy;
					int level = records[ln1].ability_lv;
					records[ln1].buy = records[ln2].buy;
					records[ln1].ability_lv = records[ln2].ability_lv;
					records[ln2].buy = buy;
					records[ln2].ability_lv = level;
				}
			}

			if (!keepPermissions)
			{
				List<int> permissions = new List<int> {
					42, 42, 27, 43,
					42, 42, 42, 42,
					42, 42, 27, 27,
					45, 45, 27, 46,
					45, 27, 46, 27,
					27, 46, 50, 46,
					24, 46, 24, 27,
					24, 24, 24, 24,

					44, 44, 44, 44,
					44, 44, 44, 44,
					44, 44, 44, 44,
					44, 44, 44, 44,
					47, 48, 49, 47,
					49, 29, 29, 29,
					49, 22, 22, 29,
					22, 22, 22, 22
				};

				int lnJ = 0;
				for (int lnI = 1; lnI <= 8; lnI++)
				{
					foreach (int wm in wMagic)
					{
						if (records[wm].ability_lv == lnI)
						{
							records[wm].use_job_group_id = permissions[lnJ];
							lnJ++;
						}
					}
				}
				for (int lnI = 1; lnI <= 8; lnI++)
				{
					foreach (int bm in bMagic)
					{
						if (records[bm].ability_lv == lnI)
						{
							records[bm].use_job_group_id = permissions[lnJ];
							lnJ++;
						}
					}
				}
			}

			//clear out old spell inventory
			List<ShopItem> shopDB = Product.readShopDB(productpath);
			shopDB = shopDB.FindAll(x => !Product.allMagicStores.Contains(x.group_id));

			//then, add the new spell inventory
			shopDB.AddRange(determineSpells(r1, randoLevel, shuffleShops));

			//and write out the product.csv
			Product.writeShopDB(productpath, shopDB);
			//and the ability.csv
			writeToFile();
		}

		private void sortByFamily(List<ability> spellbook)
        {
			List<List<int>> spellFamilies = new List<List<int>>()
			{
				new List<int>(){(int)blackMagic.bFire,    (int)blackMagic.bFira,    (int)blackMagic.bFiraga,  (int)blackMagic.bFlare},
				new List<int>(){(int)blackMagic.bBlizzard,(int)blackMagic.bBlizzara,(int)blackMagic.bBlizzaga,(int)blackMagic.bFlare},
				new List<int>(){(int)blackMagic.bThunder, (int)blackMagic.bThundara,(int)blackMagic.bThundaga,(int)blackMagic.bFlare},
				new List<int>(){(int)blackMagic.bFocus,   (int)blackMagic.bFocara},
				new List<int>(){(int)blackMagic.bSleep,   (int)blackMagic.bSleepra},
				new List<int>(){(int)blackMagic.bDark,    (int)blackMagic.bBlind},
				new List<int>(){(int)blackMagic.bSlow,    (int)blackMagic.bSlowra},
				new List<int>(){(int)blackMagic.bHold,    (int)blackMagic.bStun},
				new List<int>(){(int)blackMagic.bTeleport,(int)blackMagic.bWarp},
				new List<int>(){(int)blackMagic.bDeath,   (int)blackMagic.bKill},
				new List<int>(){(int)blackMagic.bStun,    (int)blackMagic.bBlind,   (int)blackMagic.bKill},

				new List<int>(){(int)whiteMagic.wCure,    (int)whiteMagic.wCura,    (int)whiteMagic.wCuraga,(int)whiteMagic.wCuraja},
				new List<int>(){(int)whiteMagic.wProtect, (int)whiteMagic.wProtera},
				new List<int>(){(int)whiteMagic.wDia,     (int)whiteMagic.wDiara,   (int)whiteMagic.wDiaga, (int)whiteMagic.wDiaja, (int)whiteMagic.wHoly},
				new List<int>(){(int)whiteMagic.wNulShock,(int)whiteMagic.wNulAll},
				new List<int>(){(int)whiteMagic.wInvis,   (int)whiteMagic.wInvisira},
				new List<int>(){(int)whiteMagic.wNulBlaze,(int)whiteMagic.wNulAll},
				new List<int>(){(int)whiteMagic.wHeal,    (int)whiteMagic.wHealara, (int)whiteMagic.wHealaga},
				new List<int>(){(int)whiteMagic.wNulFrost,(int)whiteMagic.wNulAll},
				new List<int>(){(int)whiteMagic.wLife,    (int)whiteMagic.wFullLife},
				new List<int>(){(int)whiteMagic.wNulDeath,(int)whiteMagic.wNulAll}
			};
			foreach (List<int> family in spellFamilies)
            {
				List<int> sort_ids = new List<int>();
				List<ability> spells = new List<ability>();
				foreach (int index in family)
                {
					ability spell = spellbook.Find(x => x.id == index - 208);
					spells.Add(spell);
					sort_ids.Add(spell.sort_id);
                }
				sort_ids.Sort();
				foreach (ability spell in spells)
                {
					spell.sort_id = sort_ids[0];
					sort_ids.RemoveAt(0);
                }
            }
        }

		private List<ShopItem> determineSpells(Random r1, int randoLevel, bool shuffleShops)
		{
			List<ShopItem> magicShopDB = new List<ShopItem>();
			int[,] magicMemory = new int[2, 8];
			int productID = 250;
		    List<int> shopLookup = new List<int>{
										0,0,0,0,
										1,1,1,1,
										2,2,2,2,
										3,3,3,3,
										4,4,4,4,
										5,5,5,5,
										6,6,8,8,
										7,7,9,9
									};
		    List<int> wmShops = Product.whiteMagicStores;
		    List<int> bmShops = Product.blackMagicStores;
			if (shuffleShops)
			{
				//this is a lot of steps for something that would be one line in a real language
				int wmHead = wmShops[0];
				int bmHead = bmShops[0];
				wmShops = wmShops.Skip(1).ToList();
				bmShops = bmShops.Skip(1).ToList();
				wmShops.Shuffle(r1);
				bmShops.Shuffle(r1);
				wmShops.Insert(0, wmHead);
				bmShops.Insert(0, bmHead);
			}
			if (randoLevel == 4)
            {
				shopLookup.Shuffle(r1);
				wmShops.Shuffle(r1);
				bmShops.Shuffle(r1);
            }

			foreach (ability spell in records)
			{
				if (spell.ability_group_id == 1 && spell.id != DUPE_CURE_4) //if it's a spell and not chaos's special Cure4
				{
					ShopItem newItem = new ShopItem();
					newItem.id = productID++;
					newItem.content_id = spell.id + 208; //Magic Constant for Ability ID -> shop ID map
					List<int> shopType = (spell.type_id == 1) ? wmShops : bmShops;
					newItem.group_id = shopType[shopLookup[(spell.ability_lv - 1) * 4 + magicMemory[spell.type_id - 1, spell.ability_lv - 1]]];
						//determineMagicShop(magicMemory, spell.type_id, spell.ability_lv);
					magicMemory[spell.type_id - 1, spell.ability_lv - 1]++;
					magicShopDB.Add(newItem);
				}
			}

			return magicShopDB;
		}
	}
}
