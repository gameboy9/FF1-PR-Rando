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
		public const int wCure = 213;
		public const int wProtect = 214;
		public const int wDia = 215;
		public const int wBlink = 216;
		public const int wInvis = 221;
		public const int wSilence = 222;
		public const int wBlindna = 223;
		public const int wNulShock = 224;
		public const int wCura = 229;
		public const int wNulBlaze = 230;
		public const int wDiara = 231;
		public const int wHeal = 232;
		public const int wPoisona = 237;
		public const int wNulFrost = 238;
		public const int wFear = 239;
		public const int wVox = 240;
		public const int wCuraga = 245;
		public const int wDiaga = 246;
		public const int wLife = 247;
		public const int wHealara = 248;
		public const int wStona = 253;
		public const int wProtera = 254;
		public const int wExit = 255;
		public const int wInvisira = 256;
		public const int wCuraja = 261;
		public const int wNulDeath = 262;
		public const int wDiaja = 263;
		public const int wHealaga = 264;
		public const int wFullLife = 269;
		public const int wNulAll = 270;
		public const int wHoly = 271;
		public const int wDispel = 272;

		public const int bFire = 217;
		public const int bFocus = 218;
		public const int bSleep = 219;
		public const int bThunder = 220;
		public const int bBlizzard = 225;
		public const int bTemper = 226;
		public const int bDark = 227;
		public const int bSlow = 228;
		public const int bFira = 233;
		public const int bThundara = 234;
		public const int bHold = 235;
		public const int bFocara = 236;
		public const int bSleepra = 241;
		public const int bConfuse = 242;
		public const int bHaste = 243;
		public const int bBlizzara = 244;
		public const int bFiraga = 249;
		public const int bTeleport = 250;
		public const int bScourge = 251;
		public const int bSlowra = 252;
		public const int bThundaga = 257;
		public const int bQuake = 258;
		public const int bDeath = 259;
		public const int bStun = 260;
		public const int bBlizzaga = 265;
		public const int bSaber = 266;
		public const int bBreak = 267;
		public const int bBlind = 268;
		public const int bFlare = 273;
		public const int bWarp = 274;
		public const int bStop = 275;
		public const int bKill = 276;

		//public List<List<int>> tiers = new List<List<int>>
		//	{ new List<int> { clothes, leatherArmor, chainMail, copperArmlet, leatherShield, leatherCap, helm, leatherGloves },
		//	  new List<int> { ironArmor, silverArmlet, ironShield, greatHelm, bronzeGloves },
		//	  new List<int> { mythrilMail, knightArmor, rubyArmlet, buckler, mythrilShield, mythrilHelm, steelGloves },
		//	  new List<int> { iceArmor, flameMail, iceShield, flameShield, diamondShield, protectCloak, diamondHelm, mythrilGloves, protectRing },
		//	  new List<int> { whiteRobe, blackRobe, diamondArmor, dragonMail, diamondArmlet, aegisShield, ribbon, healingHelm, gauntlets, giantGloves, diamondGloves }
		//};

		public List<int> all = new List<int>
		{
			bFire, bFocus, bSleep, bThunder,
			bBlizzard, bTemper, bDark, bSlow,
			bFira, bThundara, bHold, bFocara,
			bSleepra, bConfuse, bHaste, bBlizzara,
			bFiraga, bTeleport, bScourge, bSlowra,
			bThundaga, bQuake, bDeath, bStun,
			bBlizzaga, bSaber, bBreak, bBlind,
			bFlare, bWarp, bStop, bKill,

			wCure, wProtect, wDia, wBlink,
			wInvis, wSilence, wBlindna, wNulShock,
			wCura, wNulBlaze, wDiara, wHeal,
			wPoisona, wNulFrost, wFear, wVox,
			wCuraga, wDiaga, wLife, wHealara,
			wStona, wProtera, wExit, wInvisira,
			wCuraja, wNulDeath, wDiaja, wHealaga,
			wFullLife, wNulAll, wHoly, wDispel
		};

		public List<int> bAll = new List<int>
		{
			bFire, bFocus, bSleep, bThunder,
			bBlizzard, bTemper, bDark, bSlow,
			bFira, bThundara, bHold, bFocara,
			bSleepra, bConfuse, bHaste, bBlizzara,
			bFiraga, bTeleport, bScourge, bSlowra,
			bThundaga, bQuake, bDeath, bStun,
			bBlizzaga, bSaber, bBreak, bBlind,
			bFlare, bWarp, bStop, bKill
		};

		public List<int> wAll = new List<int>
		{
			wCure, wProtect, wDia, wBlink,
			wInvis, wSilence, wBlindna, wNulShock,
			wCura, wNulBlaze, wDiara, wHeal,
			wPoisona, wNulFrost, wFear, wVox,
			wCuraga, wDiaga, wLife, wHealara,
			wStona, wProtera, wExit, wInvisira,
			wCuraja, wNulDeath, wDiaja, wHealaga,
			wFullLife, wNulAll, wHoly, wDispel
		};

		//public int selectItem(Random r1, int tier)
		//{
		//	if (tier >= tiers.Count) tier = tiers.Count;
		//	tier--;
		//	return tier == -1 ? all[r1.Next() % all.Count] : tiers[tier][r1.Next() % tiers[tier].Count];
		//}

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

		public void shuffleMagic(Random r1, string fileName)
		{
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

			using (StreamWriter writer = new StreamWriter(fileName))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}
	}
}
