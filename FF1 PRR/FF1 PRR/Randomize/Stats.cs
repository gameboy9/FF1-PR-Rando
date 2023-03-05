using CsvHelper;
using CsvHelper.Configuration.Attributes;
using FF1_PRR.Common;
using FF1_PRR.Inventory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF1_PRR.Randomize
{
    internal class Stats
    {
		private class message
		{
			[Index(0)]
			public string id { get; set; }
			[Index(1)]
			public string msgString { get; set; }
		}
		
		public class CharacterStatus
        {
            public int id { get; set; }
            public int gender { get; set; }
            public int dominant_arm { get; set; }
            public int lv { get; set; }
            public int exp { get; set; }
            public int growth_curve_group_id { get; set; }
            public int job_id { get; set; }
            public string mes_id_name { get; set; }
            public int in_type_id { get; set; }
            public int hp { get; set; }
            public int mp { get; set; }
            public int magical_times1 { get; set; }
            public int magical_times2 { get; set; }
            public int magical_times3 { get; set; }
            public int magical_times4 { get; set; }
            public int magical_times5 { get; set; }
            public int magical_times6 { get; set; }
            public int magical_times7 { get; set; }
            public int magical_times8 { get; set; }
            public int strength { get; set; }
            public int vitality { get; set; }
            public int agility { get; set; }
            public int intelligence { get; set; }
            public int spirit { get; set; }
            public int magic { get; set; }
            public int luck { get; set; }
            public int attack { get; set; }
            public int defense { get; set; }
            public int accuracy_rate { get; set; }
            public int dodge_times { get; set; }
            public int evasion_rate { get; set; }
            public int ability_defense { get; set; }
            public int magic_evasion_rate { get; set; }
            public int corps { get; set; }
            public int command_id1 { get; set; }
            public int command_id2 { get; set; }
            public int command_id3 { get; set; }
            public int command_id4 { get; set; }
            public int command_id5 { get; set; }
            public int command_id6 { get; set; }
            public int content_id1 { get; set; }
            public int content_id2 { get; set; }
            public int content_id3 { get; set; }
            public int content_id4 { get; set; }
            public int content_id5 { get; set; }
            public int content_id6 { get; set; }
            public int ability_random_group_id { get; set; }
            public int initial_condition_group { get; set; }
            public int character_asset_id { get; set; }
        }

        public class GrowthCurve
        {
            public int id { get; set; }
            public int group_id { get; set; }
            public int lv { get; set; }
            public int insert_type_1 { get; set; }
            public int hp_value1 { get; set; }
            public int hp_value2 { get; set; }
            public int mp_value1 { get; set; }
            public int mp_value2 { get; set; }
            public int insert_type_2 { get; set; }
            public int strength { get; set; }
            public int vitality { get; set; }
            public int agility { get; set; }
            public int intelligence { get; set; }
            public int spirit { get; set; }
            public int magic { get; set; }
            public int luck { get; set; }
            public int insert_type_3 { get; set; }
            public int accuracy_rate { get; set; }
            public int magic_evasion_rate { get; set; }
            public int magical_times1 { get; set; }
            public int magical_times2 { get; set; }
            public int magical_times3 { get; set; }
            public int magical_times4 { get; set; }
            public int magical_times5 { get; set; }
            public int magical_times6 { get; set; }
            public int magical_times7 { get; set; }
            public int magical_times8 { get; set; }
        }

        public static void RandomizeStats(int level, bool consistent, bool promotionBoost, Random r1, string directory, string messageDir)
        {
			// Stats range:
			// HP:			  25-35 to 885-1686.  Average 31-1261
			// Strength:      3-12 to 26-65.  Average 7-42
			// Vitality:      2-15 to 27-65.  Average 8-41
			// Agility:       5-15 to 29-55.  Average 8-41
			// Intelligence:  1-20 to 26-75.  Average 8-44
			// Luck:          5-15 to 35-70.  Average 8-44
			// Accuracy:	  5-15 to 103-505.  Average 10-304
			// Magic Evasion: 10-23 to 108-513.  Average 17-311

			// level 5: (adjust to 66% of minimum to 150% of maximum)
			// HP:  17-53 -> 600-2500	Average 31-1261
			// Str:  2-18 -> 17-99		Average 7-42
			// Vit:  1-23 -> 18-99		Average 8-41
			// Agi:  3-23 -> 20-85		Average 8-41
			// Int:  0-30 -> 17-115		Average 8-44
			// Luc:  3-23 -> 24-105		Average 8-44
			// Acc:  3-23 -> 69-758		Average 10-304
			// MEv:  7-35 -> 72-770		Average 17-311

			int[][] startingStats = new int[][] { new int[] { 35, 10, 15, 8, 1, 8, 10, 15 },
                                                  new int[] { 30, 5, 5, 15, 1, 15, 15, 13 },
                                                  new int[] { 33, 12, 10, 5, 1, 5, 8, 10 },
                                                  new int[] { 30, 5, 5, 10, 10, 5, 12, 20 },
                                                  new int[] { 33, 5, 8, 5, 15, 5, 5, 23 },
                                                  new int[] { 25, 3, 2, 5, 20, 10, 8, 23 } };
            int[][] endingStats = new int[][] { new int[] { 1686, 65, 49, 51, 26, 41, 402, 309 },
                                                new int[] { 1103, 46, 31, 55, 28, 70, 505, 307 },
                                                new int[] { 1610, 45, 65, 39, 34, 44, 302, 206 },
                                                new int[] { 1108, 39, 36, 37, 43, 39, 306, 314 },
                                                new int[] { 1176, 33, 37, 32, 56, 35, 201, 513 },
                                                new int[] { 885, 26, 27, 29, 75, 35, 204, 513 } };

            float[][] growthCurves = new float[][] { new float[] { 0.965f, 1.02f, 1.34f, 1.28f, 1.12f, 1.36f },
													 new float[] { 0.97f, 1.16f, 1.01f, 0.91f, 1.04f, 1.01f },
													 new float[] { 0.752f, 1.01f, 0.98f, 0.99f, 1.01f, 1.14f },
													 new float[] { 0.92f, 1.24f, 1.37f, 1.22f, 1.06f, 1.06f },
													 new float[] { 1.09f, 1.03f, 1.16f, 1.01f, 0.99f, 1.06f },
													 new float[] { 0.91f, 1.00f, 1.02f, 1.06f, 1.02f, 1.01f }};

            List<int> hpGrowth;
            List<int> strength;
            List<int> vitality;
            List<int> agility;
            List<int> intelligence;
            List<int> luck;

            string[] stats = new string[6];

			IEnumerable<CharacterStatus> startStats = readStartingStats(Path.Combine(directory, "character_status.csv"));
			IEnumerable<GrowthCurve> growth = readGrowthCurve(Path.Combine(directory, "growth_curve.csv"));
			// Shuffle stat gains.  Keep starting stats the same.  Create array of stat gains, then shuffle.
			if (level == 1)
            {
                for (int i = 0; i < 6; i++)
                {
                    IEnumerable<GrowthCurve> classGrowth = growth.Where(c => c.group_id == i + 1);
                    hpGrowth = classGrowth.Select(c => c.hp_value1).ToList();
					hpGrowth.Shuffle(r1);
					strength = classGrowth.Select(c => c.strength).ToList();
					strength.Shuffle(r1);
					vitality = classGrowth.Select(c => c.vitality).ToList();
					vitality.Shuffle(r1);
					agility = classGrowth.Select(c => c.agility).ToList();
					agility.Shuffle(r1);
					intelligence = classGrowth.Select(c => c.intelligence).ToList();
					intelligence.Shuffle(r1);
					luck = classGrowth.Select(c => c.luck).ToList();
					luck.Shuffle(r1);
					stats[i] = "Approx Maxs - HP:  " + calcStats(3, startingStats[i][0], hpGrowth, startingStats[i][2], vitality).ToString() + 
                        "  STR:  " + calcStats(3, startingStats[i][1], strength).ToString() +
						"  VIT:  " + calcStats(3, startingStats[i][2], vitality).ToString() +
						"  AGI:  " + calcStats(3, startingStats[i][3], agility).ToString() +
						"  INT:  " + calcStats(3, startingStats[i][4], intelligence).ToString() +
						"  LUC:  " + calcStats(3, startingStats[i][5], luck).ToString();

					for (int j = 0; j < hpGrowth.Count; j++)
                    {
                        GrowthCurve indLevel = classGrowth.Where(c => c.lv == j + 2).Single();
                        indLevel.hp_value1 = hpGrowth[j];
                        indLevel.strength = strength[j];
                        indLevel.vitality = vitality[j];
                        indLevel.agility = agility[j];
                        indLevel.intelligence = intelligence[j];
                        indLevel.luck = luck[j];
                    }

					IEnumerable<GrowthCurve> classGrowth2 = growth.Where(c => c.group_id == i + 7);
                    foreach (GrowthCurve indLevel in classGrowth2)
                    {
						indLevel.hp_value1 = (classGrowth.Where(c => c.lv == indLevel.lv).Single().hp_value1 == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.strength = (classGrowth.Where(c => c.lv == indLevel.lv).Single().strength == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.vitality = (classGrowth.Where(c => c.lv == indLevel.lv).Single().vitality == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.agility = (classGrowth.Where(c => c.lv == indLevel.lv).Single().agility == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.intelligence = (classGrowth.Where(c => c.lv == indLevel.lv).Single().intelligence == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.luck = (classGrowth.Where(c => c.lv == indLevel.lv).Single().luck == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
                    }
				}
			}

			// Percentage chance of strong level gains based on class.  Keep starting stats the same.  Create array of stat gains, then shuffle.
			if (level == 2)
			{
				for (int i = 0; i < 6; i++)
				{
					IEnumerable<GrowthCurve> classGrowth = growth.Where(c => c.group_id == i + 1);
					float hpPct = classGrowth.Count(c => c.hp_value1 == 1) / 98;
					float strPct = classGrowth.Count(c => c.strength == 1) / 98;
					float vitPct = classGrowth.Count(c => c.vitality == 1) / 98;
					float agiPct = classGrowth.Count(c => c.agility == 1) / 98;
					float intPct = classGrowth.Count(c => c.intelligence == 1) / 98;
					float luckPct = classGrowth.Count(c => c.luck == 1) / 98;

					foreach (GrowthCurve singleGrowth in classGrowth)
					{
						singleGrowth.hp_value1 = r1.Next() < hpPct ? 1 : 0;
						singleGrowth.strength = r1.Next() < strPct ? 1 : 0;
						singleGrowth.vitality = r1.Next() < vitPct ? 1 : 0;
						singleGrowth.agility = r1.Next() < agiPct ? 1 : 0;
						singleGrowth.intelligence = r1.Next() < intPct ? 1 : 0;
						singleGrowth.luck = r1.Next() < luckPct ? 1 : 0;
					}
					
					hpGrowth = classGrowth.Select(c => c.hp_value1).ToList();
					strength = classGrowth.Select(c => c.strength).ToList();
					vitality = classGrowth.Select(c => c.vitality).ToList();
					agility = classGrowth.Select(c => c.agility).ToList();
					intelligence = classGrowth.Select(c => c.intelligence).ToList();
					luck = classGrowth.Select(c => c.luck).ToList();

					stats[i] = "Max-HP:  " + calcStats(3, startingStats[i][0], hpGrowth, startingStats[i][2], vitality).ToString() +
						"/STR:  " + calcStats(3, startingStats[i][1], strength).ToString() +
						"/VIT:  " + calcStats(3, startingStats[i][2], vitality).ToString() +
						"/AGI:  " + calcStats(3, startingStats[i][3], agility).ToString() +
						"/INT:  " + calcStats(3, startingStats[i][4], intelligence).ToString() +
						"/LUC:  " + calcStats(3, startingStats[i][5], luck).ToString() +
						"/AC+:  " + classGrowth.Average(c => c.accuracy_rate).ToString("0.00") +
						"/MD+:  " + classGrowth.Average(c => c.magic_evasion_rate).ToString("0.00");

					IEnumerable<GrowthCurve> classGrowth2 = growth.Where(c => c.group_id == i + 7);
					foreach (GrowthCurve indLevel in classGrowth2)
					{
						indLevel.hp_value1 = (classGrowth.Where(c => c.lv == indLevel.lv).Single().hp_value1 == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.strength = (classGrowth.Where(c => c.lv == indLevel.lv).Single().strength == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.vitality = (classGrowth.Where(c => c.lv == indLevel.lv).Single().vitality == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.agility = (classGrowth.Where(c => c.lv == indLevel.lv).Single().agility == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.intelligence = (classGrowth.Where(c => c.lv == indLevel.lv).Single().intelligence == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
						indLevel.luck = (classGrowth.Where(c => c.lv == indLevel.lv).Single().luck == 1 ? 1 : promotionBoost && r1.Next() % 4 == 0 ? 1 : 0);
					}
				}
			}

			if (level <= 2 && consistent) // Stats will be consistent in higher levels of randomization
            {
                for (int i = 0; i < 6; i++)
                {
					IEnumerable<GrowthCurve> classGrowth = growth.Where(c => c.group_id == i + 1);
					int finalVitality = startingStats[i][2];
					foreach (GrowthCurve singleGrowth in classGrowth)
					{
                        //GrowthCurve indLevel = classGrowth.Where(c => c.lv == j + 2).Single();
                        singleGrowth.insert_type_1 = 1;
                        singleGrowth.insert_type_2 = 1;
						singleGrowth.hp_value1 = (singleGrowth.hp_value1 == 1 ? r1.Next() % 6 + 20 : 0) + (finalVitality / 4);
						singleGrowth.strength = singleGrowth.strength == 1 ? 1 : r1.Next() % 8 == 0 ? 1 : 0;
						singleGrowth.vitality = singleGrowth.vitality == 1 ? 1 : r1.Next() % 8 == 0 ? 1 : 0;
                        finalVitality += singleGrowth.vitality;
						singleGrowth.agility = singleGrowth.agility == 1 ? 1 : r1.Next() % 8 == 0 ? 1 : 0;
						singleGrowth.intelligence = singleGrowth.intelligence == 1 ? 1 : r1.Next() % 8 == 0 ? 1 : 0;
						singleGrowth.luck = singleGrowth.luck == 1 ? 1 : r1.Next() % 8 == 0 ? 1 : 0;
					}

					stats[i] = "Max-HP:  " + (startingStats[i][0] + classGrowth.Sum(c => c.hp_value1)).ToString() +
	                    "/STR:  " + (startingStats[i][0] + classGrowth.Sum(c => c.strength)).ToString() +
	                    "/VIT:  " + (startingStats[i][0] + classGrowth.Sum(c => c.vitality)).ToString() +
	                    "/AGI:  " + (startingStats[i][0] + classGrowth.Sum(c => c.agility)).ToString() +
	                    "/INT:  " + (startingStats[i][0] + classGrowth.Sum(c => c.intelligence)).ToString() +
	                    "/LUC:  " + (startingStats[i][0] + classGrowth.Sum(c => c.luck)).ToString() +
						"/AC+:  " + classGrowth.Average(c => c.accuracy_rate).ToString("0.00") +
						"/MD+:  " + classGrowth.Average(c => c.magic_evasion_rate).ToString("0.00");

					IEnumerable<GrowthCurve> classGrowth2 = growth.Where(c => c.group_id == i + 7);
					foreach (GrowthCurve indLevel in classGrowth2)
					{
						indLevel.insert_type_1 = 1;
						indLevel.insert_type_2 = 1;
						indLevel.hp_value1 = classGrowth.Where(c => c.lv == indLevel.lv).Single().hp_value1;
						indLevel.strength = classGrowth.Where(c => c.lv == indLevel.lv).Single().strength;
						indLevel.vitality = classGrowth.Where(c => c.lv == indLevel.lv).Single().vitality;
						indLevel.agility = classGrowth.Where(c => c.lv == indLevel.lv).Single().agility;
						indLevel.intelligence = classGrowth.Where(c => c.lv == indLevel.lv).Single().intelligence;
						indLevel.luck = classGrowth.Where(c => c.lv == indLevel.lv).Single().luck;
					}
				}
			}

			if (level >= 3)
			{
				
				for (int i = 0; i < 6; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						int variance = 0;
						int newStart = 0;
						int newEnd = 0;
						double growthCurveToUse = growthCurves[0][i];
						if (level == 3)
						{
							variance = startingStats[i][j] / 10;
							newStart = startingStats[i][j] - variance;
							variance = endingStats[i][j] / 10;
							newEnd = endingStats[i][j] + variance;
						}
						if (level == 4)
						{
							variance = startingStats[i][j] / 5;
							newStart = startingStats[i][j] - variance;
							newStart = startingStats[i][j] + (r1.Next() % (variance * 2));
							variance = endingStats[i][j] / 5;
							newEnd = endingStats[i][j] + variance;
							newEnd = endingStats[i][j] + (r1.Next() % (variance * 2));
							growthCurveToUse = Common.Common.statAdjust(r1, growthCurveToUse * 0.8 * 100, growthCurveToUse, growthCurveToUse * 1.25 * 100, 2) / 100;
						}
						// level 5: (adjust to 66% of minimum to 150% of maximum)
						// HP:  17-53 -> 600-2500	Average 31-1261
						// Str:  2-18 -> 17-99		Average 7-42
						// Vit:  1-23 -> 18-99		Average 8-41
						// Agi:  3-23 -> 20-85		Average 8-41
						// Int:  0-30 -> 17-115		Average 8-44
						// Luc:  3-23 -> 24-105		Average 8-44
						// Acc:  3-23 -> 69-758		Average 10-304
						// MEv:  7-35 -> 72-770		Average 17-311
						if (level == 5)
						{
							switch (j)
							{
								case 0:  newStart = (int)Common.Common.statAdjust(r1, 17, 31, 53, 1); newEnd = (int)Common.Common.statAdjust(r1, 600, 1261, 2500, 1); break;
								case 1:  newStart = (int)Common.Common.statAdjust(r1, 2, 7, 18, 1); newEnd = (int)Common.Common.statAdjust(r1, 17, 42, 99, 1); break;
								case 2:  newStart = (int)Common.Common.statAdjust(r1, 1, 8, 23, 1); newEnd = (int)Common.Common.statAdjust(r1, 18, 41, 99, 1); break;
								case 3:  newStart = (int)Common.Common.statAdjust(r1, 3, 8, 23, 1); newEnd = (int)Common.Common.statAdjust(r1, 20, 41, 85, 1); break;
								case 4:  newStart = (int)Common.Common.statAdjust(r1, 0, 8, 30, 1); newEnd = (int)Common.Common.statAdjust(r1, 17, 44, 115, 1); break;
								case 5:  newStart = (int)Common.Common.statAdjust(r1, 3, 8, 23, 1); newEnd = (int)Common.Common.statAdjust(r1, 24, 44, 105, 1); break;
								case 6:  newStart = (int)Common.Common.statAdjust(r1, 3, 10, 23, 1); newEnd = (int)Common.Common.statAdjust(r1, 69, 304, 758, 1); break;
								case 7:  newStart = (int)Common.Common.statAdjust(r1, 7, 17, 35, 1); newEnd = (int)Common.Common.statAdjust(r1, 72, 311, 770, 1); break;
							}
							growthCurveToUse = Common.Common.statAdjust(r1, 50, 100, 200, 2) / 100;
						}

						newEnd = Math.Max(newStart, newEnd);
						int[] newValues = inverted_power_curve(newStart, newEnd, 99, growthCurveToUse, r1);

						CharacterStatus startStat = startStats.Where(c => c.id == i + 1).Single();
						switch (j)
						{
							case 0:
								startStat.hp = newValues[0];
								break;
							case 1:
								startStat.strength = newValues[0];
								break;
							case 2:
								startStat.vitality = newValues[0];
								break;
							case 3:
								startStat.agility = newValues[0];
								break;
							case 4:
								startStat.intelligence = newValues[0];
								break;
							case 5:
								startStat.luck = newValues[0];
								break;
							case 6:
								startStat.accuracy_rate = newValues[0];
								break;
							case 7:
								startStat.magic_evasion_rate = newValues[0];
								break;
						}

						// TODO:  Set up starting stats from character_status.csv
						int k = 0;
						IEnumerable<GrowthCurve> classGrowth = growth.Where(c => c.group_id == i + 1);
						foreach (GrowthCurve singleGrowth in classGrowth)
						{
							switch (j)
							{
								case 0:
									singleGrowth.insert_type_1 = 1;
									singleGrowth.insert_type_2 = 1;
									singleGrowth.hp_value1 = newValues[k + 1] - newValues[k];
									break;
								case 1:
									singleGrowth.strength = newValues[k + 1] - newValues[k];
									break;
								case 2:
									singleGrowth.vitality = newValues[k + 1] - newValues[k];
									break;
								case 3:
									singleGrowth.agility = newValues[k + 1] - newValues[k];
									break;
								case 4:
									singleGrowth.intelligence = newValues[k + 1] - newValues[k];
									break;
								case 5:
									singleGrowth.luck = newValues[k + 1] - newValues[k];
									break;
								case 6:
									singleGrowth.accuracy_rate = newValues[k + 1] - newValues[k];
									break;
								case 7:
									singleGrowth.magic_evasion_rate = newValues[k + 1] - newValues[k];
									break;
							}
							k++;
						}
					}

					double boost = 1.0f;
					if (promotionBoost)
					{
						switch (level)
						{
							case 3:
								boost = 1.25;
								break;
							case 4:
								boost = Common.Common.statAdjust(r1, 110, 125, 140, 2) / 100;
								break;
							case 5:
								boost = Common.Common.statAdjust(r1, 100, 125, 200, 2) / 100;
								break;
						}
						boost = Common.Common.statAdjust(r1, 100, 125, 200, 2) / 100;

					}
					IEnumerable<GrowthCurve> classGrowthNew = growth.Where(c => c.group_id == i + 1);
					IEnumerable<GrowthCurve> classGrowth2 = growth.Where(c => c.group_id == i + 7);
					double[] oldVal = { 0, 0, 0, 0, 0, 0, 0, 0 };
					double[] newVal = { 0, 0, 0, 0, 0, 0, 0, 0 };
					foreach (GrowthCurve indLevel in classGrowth2)
					{
						indLevel.insert_type_1 = 1;
						indLevel.insert_type_2 = 1;
						oldVal[0] = newVal[0];
						newVal[0] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().hp_value1 * boost);
						indLevel.hp_value1 = (int)(Math.Floor(newVal[0]) - Math.Floor(oldVal[0]));
						oldVal[1] = newVal[1];
						newVal[1] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().strength * boost);
						indLevel.strength = (int)(Math.Floor(newVal[1]) - Math.Floor(oldVal[1]));
						oldVal[2] = newVal[2];
						newVal[2] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().vitality * boost);
						indLevel.vitality = (int)(Math.Floor(newVal[2]) - Math.Floor(oldVal[2]));
						oldVal[3] = newVal[3];
						newVal[3] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().agility * boost);
						indLevel.agility = (int)(Math.Floor(newVal[3]) - Math.Floor(oldVal[3]));
						oldVal[4] = newVal[4];
						newVal[4] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().intelligence * boost);
						indLevel.intelligence = (int)(Math.Floor(newVal[4]) - Math.Floor(oldVal[4]));
						oldVal[5] = newVal[5];
						newVal[5] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().luck * boost);
						indLevel.luck = (int)(Math.Floor(newVal[5]) - Math.Floor(oldVal[5]));
						oldVal[6] = newVal[6];
						newVal[6] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().accuracy_rate * boost);
						indLevel.accuracy_rate = (int)(Math.Floor(newVal[6]) - Math.Floor(oldVal[6]));
						oldVal[7] = newVal[7];
						newVal[7] += (classGrowthNew.Where(c => c.lv == indLevel.lv).Single().magic_evasion_rate * boost);
						indLevel.magic_evasion_rate = (int)(Math.Floor(newVal[7]) - Math.Floor(oldVal[7]));
					}

					CharacterStatus startStatNew = startStats.Where(c => c.id == i + 1).Single();

					stats[i] = "Max-HP:  " + (startStatNew.hp + classGrowthNew.Sum(c => c.hp_value1)).ToString() +
						"/STR:  " + (startStatNew.strength + classGrowthNew.Sum(c => c.strength)).ToString() +
						"/VIT:  " + (startStatNew.vitality + classGrowthNew.Sum(c => c.vitality)).ToString() +
						"/AGI:  " + (startStatNew.agility + classGrowthNew.Sum(c => c.agility)).ToString() +
						"/INT:  " + (startStatNew.intelligence + classGrowthNew.Sum(c => c.intelligence)).ToString() +
						"/LUC:  " + (startStatNew.luck + classGrowthNew.Sum(c => c.luck)).ToString() +
						"/AC+:  " + classGrowthNew.Average(c => c.accuracy_rate).ToString("0.00") +
						"/MD+:  " + classGrowthNew.Average(c => c.magic_evasion_rate).ToString("0.00");
				}
			}

			writeStartingStats(Path.Combine(directory, "character_status.csv"), startStats);
			writeGrowthCurve(Path.Combine(directory, "growth_curve.csv"), growth);

			// TODO:  Write new stats to system_en.txt, etc.
			List<message> records = new List<message>();
			using (StreamReader reader = new StreamReader(Path.Combine(messageDir, "system_en.txt")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = "\t";
				config.HasHeaderRecord = false;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					records = csv.GetRecords<message>().ToList();
			}

			for (int i = 1; i <= 6; i++)
			{
				message record = records.Where(c => c.id == "MSG_JOB_INF_0" + i.ToString()).Single();
				record.msgString = stats[i - 1];
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(messageDir, "system_en.txt")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = "\t";
				config.HasHeaderRecord = false;

				using (CsvWriter csv = new CsvWriter(writer, config))
					csv.WriteRecords(records);
			}
		}

		private static int calcStats(int style, int startStat, List<int> stats, int startStat2 = -1, List<int> stat2 = null)
        {
            double finalStat = startStat;
            double finalStat2 = startStat2;
            if (style == 3)
            {
                if (stat2 == null)
                {
                    foreach (int stat in stats)
						finalStat += stat >= 1 ? 1 : 0.125;
                } else
                {
                    int i = 0;
                    foreach (int stat in stats)
                    {
						finalStat += (stat >= 1 ? 22.5 : 0) + finalStat2 / 4;
						finalStat2 += finalStat += stat >= 1 ? 1 : 0.125;
						i++;
					}
				}
            } 
            else
            {
				foreach (int stat in stats)
					finalStat += stat;
			}
            return (int)finalStat;
        }

		public static List<CharacterStatus> readStartingStats(string fileName)
		{
			List<CharacterStatus> charStatsDB = new List<CharacterStatus>();
			using (var reader = new StreamReader(fileName))
			using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				charStatsDB = csv.GetRecords<CharacterStatus>().ToList();
			}
			return charStatsDB;
		}

		public static void writeStartingStats(string fileName, IEnumerable<CharacterStatus> charStatsDB)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(charStatsDB);
			}
		}

		public static List<GrowthCurve> readGrowthCurve(string fileName)
		{
			List<GrowthCurve> growthDB = new List<GrowthCurve>();
			using (var reader = new StreamReader(fileName))
			using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				growthDB = csv.GetRecords<GrowthCurve>().ToList();
			}
			return growthDB;
		}

		public static void writeGrowthCurve(string fileName, IEnumerable<GrowthCurve> growthDB)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(growthDB);
			}
		}

		private static int[] inverted_power_curve(int min, int max, int arraySize, double powToUse, Random r1)
		{
			int range = max - min;
			double p_range = Math.Pow(range, 1 / powToUse);
			int[] points = new int[arraySize];
			for (int i = 0; i < arraySize; i++)
			{
				double section = (double)r1.Next() / int.MaxValue;
				points[i] = (int)Math.Round(max - Math.Pow(section * p_range, powToUse));
			}
			Array.Sort(points);
			return points;
		}
	}
}
