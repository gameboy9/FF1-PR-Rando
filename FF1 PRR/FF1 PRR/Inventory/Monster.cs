using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FF1_PRR.Inventory
{
	public class Monster
	{
		private class singleMonster
		{
			public int id { get; set; }
			public string mes_id_name { get; set; }
			public int cursor_x_position { get; set; }
			public int cursor_y_position { get; set; }
			public int in_type_id { get; set; }
			public int disappear_type_id { get; set; }
			public int species { get; set; }
			public int resistance_attribute { get; set; }
			public int resistance_condition { get; set; }
			public int initial_condition { get; set; }
			public int lv { get; set; }
			public int hp { get; set; }
			public int mp { get; set; }
			public int exp { get; set; }
			public int gill { get; set; }
			public int attack_count { get; set; }
			public int attack_plus { get; set; }
			public int attack_plus_group { get; set; }
			public int attack_attribute { get; set; }
			public int strength { get; set; }
			public int vitality { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int attack { get; set; }
			public int ability_attack { get; set; }
			public int defense { get; set; }
			public int ability_defense { get; set; }
			public int ability_defense_reat { get; set; }
			public int accuracy_rate { get; set; }
			public int dodge_times { get; set; }
			public int evasion_rate { get; set; }
			public int magic_evasion_rate { get; set; }
			public int ability_disturbed_rate { get; set; }
			public int critical_rate { get; set; }
			public int luck { get; set; }
			public int weight { get; set; }
			public int boss { get; set; }
			public int monster_flag_group_id { get; set; }
			public int drop_rate { get; set; }
			public int drop_content_id1 { get; set; }
			public int drop_content_id1_value { get; set; }
			public int drop_content_id2 { get; set; }
			public int drop_content_id2_value { get; set; }
			public int drop_content_id3 { get; set; }
			public int drop_content_id3_value { get; set; }
			public int drop_content_id4 { get; set; }
			public int drop_content_id4_value { get; set; }
			public int drop_content_id5 { get; set; }
			public int drop_content_id5_value { get; set; }
			public int drop_content_id6 { get; set; }
			public int drop_content_id6_value { get; set; }
			public int drop_content_id7 { get; set; }
			public int drop_content_id7_value { get; set; }
			public int drop_content_id8 { get; set; }
			public int drop_content_id8_value { get; set; }
			public int steal_content_id1 { get; set; }
			public int steal_content_id2 { get; set; }
			public int steal_content_id3 { get; set; }
			public int steal_content_id4 { get; set; }
			public int script_id { get; set; }
			public int monster_asset_id { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int p_use_ability_random_group_id { get; set; }
			public int command_group_type { get; set; }
			public int release_ability_random_group_id { get; set; }
			public int rage_ability_random_group_id { get; set; }
		}

		public Monster(Random r1, string fileName, double xpMultiplier, int xpBoost, double gpMultiplier, int gpBoost, double minStatAdjust, double maxStatAdjust)
		{
			List<singleMonster> records;

			using (StreamReader reader = new StreamReader(fileName))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				records = csv.GetRecords<singleMonster>().ToList();
			}

			foreach (singleMonster iMonster in records)
			{
				iMonster.exp = (int)(iMonster.exp * xpMultiplier);
				iMonster.exp += xpBoost;
				iMonster.gill = (int)(iMonster.gill * gpMultiplier);
				iMonster.gill += gpBoost;

				iMonster.hp = Common.Common.range((int)(iMonster.hp * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 2)), 1);
				iMonster.attack_count = Common.Common.range((int)(iMonster.attack_count * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 3)), 1, 99);
				iMonster.agility = Common.Common.range((int)(iMonster.agility * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 2)), 1, 99);
				iMonster.intelligence = Common.Common.range((int)(iMonster.intelligence * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 2)), 1, 99);
				iMonster.attack = Common.Common.range((int)(iMonster.attack * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 2)), 1, 255);
				iMonster.defense = Common.Common.range((int)(iMonster.defense * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 2)), 1, 240);
				iMonster.accuracy_rate = Common.Common.range((int)(iMonster.accuracy_rate * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 3)), 1, 255);
				iMonster.evasion_rate = Common.Common.range((int)(iMonster.evasion_rate * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 4)), 1, 240);
				iMonster.magic_evasion_rate = Common.Common.range((int)(iMonster.magic_evasion_rate * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 3)), 1, 240);
				iMonster.critical_rate = Common.Common.range((int)(iMonster.critical_rate * Common.Common.statAdjust(r1, minStatAdjust, 1, maxStatAdjust, 3)), 1, 99);
			}

			using (StreamWriter writer = new StreamWriter(fileName))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}
	}
}
