using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF1_PRR.Common.Common;

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

		public List<int> all = Enum.GetValues(typeof(whiteMagic)).Cast<int>().ToList(); // Black magic will be added in shuffleMagic
		public List<int> bAll = Enum.GetValues(typeof(blackMagic)).Cast<int>().ToList();
		public List<int> wAll = Enum.GetValues(typeof(whiteMagic)).Cast<int>().ToList();

		public List<int> shuffleShops(Random r1, int type)
		{
			List<int> shuffler = type == 0 ? all : type == 1 ? wAll : bAll;

			shuffler.Shuffle(r1);
			return shuffler;
		}

		private class ability
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

		public void shuffleMagic(Random r1, bool keepPermissions, string fileName)
		{
			all.AddRange(Enum.GetValues(typeof(blackMagic)).Cast<int>().ToList());
			List<ability> records;

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

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "ability.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				records = csv.GetRecords<ability>().ToList();
			}

			// TODO:  id + (r1.Next() % 100), sort from there.
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

			using (StreamWriter writer = new StreamWriter(fileName))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}
	}
}
