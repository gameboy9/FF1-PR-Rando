using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Inventory
{
	public static class MonsterParty
	{
		private class singleGroup
		{
			public int id { get; set; }
			public int battle_background_asset_id { get; set; }
			public int battle_bgm_asset_id { get; set; }
			public int appearance_production { get; set; }
			public int script_name { get; set; }
			public int battle_pattern1 { get; set; }
			public int battle_pattern2 { get; set; }
			public int battle_pattern3 { get; set; }
			public int battle_pattern4 { get; set; }
			public int battle_pattern5 { get; set; }
			public int battle_pattern6 { get; set; }
			public int not_escape { get; set; }
			public int battle_flag_group_id { get; set; }
			public int get_value { get; set; }
			public int get_ap { get; set; }
			public int monster1 { get; set; }
			public int monster1_x_position { get; set; }
			public int monster1_y_position { get; set; }
			public int monster1_group { get; set; }
			public int monster2 { get; set; }
			public int monster2_x_position { get; set; }
			public int monster2_y_position { get; set; }
			public int monster2_group { get; set; }
			public int monster3 { get; set; }
			public int monster3_x_position { get; set; }
			public int monster3_y_position { get; set; }
			public int monster3_group { get; set; }
			public int monster4 { get; set; }
			public int monster4_x_position { get; set; }
			public int monster4_y_position { get; set; }
			public int monster4_group { get; set; }
			public int monster5 { get; set; }
			public int monster5_x_position { get; set; }
			public int monster5_y_position { get; set; }
			public int monster5_group { get; set; }
			public int monster6 { get; set; }
			public int monster6_x_position { get; set; }
			public int monster6_y_position { get; set; }
			public int monster6_group { get; set; }
			public int monster7 { get; set; }
			public int monster7_x_position { get; set; }
			public int monster7_y_position { get; set; }
			public int monster7_group { get; set; }
			public int monster8 { get; set; }
			public int monster8_x_position { get; set; }
			public int monster8_y_position { get; set; }
			public int monster8_group { get; set; }
			public int monster9 { get; set; }
			public int monster9_x_position { get; set; }
			public int monster9_y_position { get; set; }
			public int monster9_group { get; set; }
		}

		public static void mandatoryRandomEncounters(Random r1, string csvDirectory, bool randomize)
		{
			List<singleGroup> monsterGroups = new List<singleGroup>();
			using (StreamReader reader = new StreamReader(Path.Combine("data", "assets", "monster_party.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				monsterGroups = csv.GetRecords<singleGroup>().ToList();

			// Mandatory fights as defined by FF1/NES.
			List<int> mandatoryFights = new List<int>
			{
				89, 90, // Wizards / Piscodemons (also 88 - treasure boss)
				473, 474, 475, 476, // Earth Elemental (also 102 - treasure boss)
				103, 104, 323, 324, 477, 478, 479, 480, 481, 761, 762, 769, 770, 771, // Hellhound; Ogre Mage
				116, 493, 494, 800, 812, // Fire Elementals (also 115 - treasure boss)
				129, 130, 131, 132, 133, 513, 514, 515, 516, 517, 518, 519, 520, 818, // Ice Gigas; Winter Wolf (also 128 - treasure boss)
				141, 142, 143, 527, 528, 529, 530, 531, 532, // Minotaur Zombie, Troll
				830, 614, 615, 616, 617, // Phantom / Ghosts (also 197 - treasure boss)
				203, 204, 618, 619, 620, 621, 626, 627, 628, 629, 819, // Water Elementals (also 202 - treasure boss)
				230, 636, 637, 638, 663, 664, 665, 805, 814, // Zombie Dragons (also 229 - Ordeals boss)
				644, 645, 806, // Blue Dragons (also 239 - Mirage Tower boss)
				262, 263, 673, 674, // Purple Worms
				266, 678, 679, 680, 794, 821, // Green Dragons
				747, 748, 810, // Evil Eyes (also 312 - Ice Cave boss)
				787, // Sahagin Prince / Chief
				788, 789 // Iron Golems
			};

			// We want to keep these fights as mandatory.
			List<int> reallyMandatory = new List<int>
			{
				88, // Piscodemons @ Marsh Cave
				229, // Zombie Dragons @ Ordeals
				312, // Evil Eyes @ Ice Cave
				350, // Garland
				338, 339, 340, 341, 342, 343, 344, 345, 346, // Fiends / Chaos
				347, // Vampire at Earth Cave
				348, // Astos
				349 // Pirates
			};

			// 24 + 92 (mandatory fight list) = 116 random mandatories

			if (!randomize)
			{
				foreach (singleGroup group in monsterGroups.Where(c => mandatoryFights.Contains(c.id)))
					group.not_escape = 2;
			} else
			{
				foreach (singleGroup group in monsterGroups.Where(c => !reallyMandatory.Contains(c.id)))
					group.not_escape = 0;

				// Determine the 119 non-boss fights that will be randomized.
				for (int i = 0; i < 116; i++)
				{
					singleGroup group = monsterGroups[r1.Next() % monsterGroups.Count];
					// Redraw if "not_escape" is already set.
					if (group.not_escape == 2)
						i--;
					else
						group.not_escape = 2;
				}
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, "monster_party.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(monsterGroups);
			}

		}
	}
}
