using FF1_PRR.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Randomize
{
	public class KeyItems
	{
		// 24 flags
		enum flags
		{
			lute = 5,
			crown = 10,
			crystalEye = 11,
			joltTonic = 12,
			mysticKey = 13,
			nitroPowder = 14,
			canal = 15,
			starRuby = 17,
			rod = 19,
			earthCrystal = 21,
			canoe = 22,
			fireCrystal = 23,
			floater = 24,
			airship = 25, // Also SysCall
			cube = 26,
			oxyale = 29,
			slab = 31,
			learnLufuin = 32,
			chime = 33,
			waterCrystal = 34,
			airCrystal = 35,
			ratTail = 45,
			adamantite = 47,
			excalibur = 48
		}

		// 26 locations
		enum locations
		{
			sarah = 1,
			coroniaKing = 2,
			pirate = 3,
			marsh = 4,
			astos = 5,
			matoya = 6,
			elfPrince = 7,
			coroniaTreasury = 8,
			dwarf = 9,
			excal = 10,
			vampire = 11,
			sage = 12,
			lich = 13,
			crescentLake = 14,
			marilith = 15,
			iceCave = 16,
			airship = 17,
			gaia = 18,
			waterfall = 19,
			shrine5F = 20,
			kraken = 21,
			unne = 22,
			lefein = 23,
			ordeals = 24,
			adamantite = 25,
			tiamat = 26
		}

		private class locationData
		{
			public int keyItem { get; set; }
			public int ff1Event { get; set; }

			public locationData(int ki, int ev)
			{
				keyItem = ki;
				ff1Event = ev;
			}
		}

		public KeyItems(Random r1, string directory)
		{
			List<locationData> ld = new List<locationData>();
			List<int> complete = new List<int>();

			Process p = new Process();
			p.StartInfo = new ProcessStartInfo(Path.Combine("clingo", "clingo"), Path.Combine("clingo", "KeyItemSolvingShip.lp") + " " + Path.Combine("clingo", "KeyItemDataShip.lp") + " --sign-def=3 --seed=" + r1.Next().ToString().Trim() + " --outf=2")
			{
				RedirectStandardOutput = true,
				UseShellExecute = false
			};
			p.Start();
			p.WaitForExit();

			//The output of the shell command will be in the outPut variable after the 
			//following line is executed
			var clingoJSON = p.StandardOutput.ReadToEnd();

			ClingoKeyItem events = JsonConvert.DeserializeObject<ClingoKeyItem>(clingoJSON);
			foreach (string pairValue in events.Call[0].Witnesses[0].Value)
			{
				string[] values = pairValue.Replace("pair(", "").Replace(")", "").Split(",");
				int keyItem = -1;
				int location = -1;

				switch (values[0])
				{
					case "lute": keyItem = (int)flags.lute; break;
					case "crown": keyItem = (int)flags.crown; break;
					case "crystal": keyItem = (int)flags.crystalEye; break;
					case "jolt_tonic": keyItem = (int)flags.joltTonic; break;
					case "mystic_key": keyItem = (int)flags.mysticKey; break;
					case "nitro_powder": keyItem = (int)flags.nitroPowder; break;
					case "canal": keyItem = (int)flags.canal; break;
					case "star_ruby": keyItem = (int)flags.starRuby; break;
					case "rod": keyItem = (int)flags.rod; break;
					case "levistone": keyItem = (int)flags.floater; break;
					//case "gear": keyItem = gear; break;
					case "rats_tail": keyItem = (int)flags.ratTail; break;
					case "oxyale": keyItem = (int)flags.oxyale; break;
					case "rosetta_stone": keyItem = (int)flags.slab; break;
					case "chime": keyItem = (int)flags.chime; break;
					case "warp_cube": keyItem = (int)flags.cube; break;
					case "adamantite": keyItem = (int)flags.adamantite; break;
					case "excalibur": keyItem = (int)flags.excalibur; break;
					case "earth": keyItem = (int)flags.earthCrystal; break;
					case "fire": keyItem = (int)flags.fireCrystal; break;
					case "water": keyItem = (int)flags.waterCrystal; break;
					case "air": keyItem = (int)flags.airCrystal; break;
					case "lufienish": keyItem = (int)flags.learnLufuin; break;
				}

				switch (values[1])
				{
					case "sara": location = (int)locations.sarah; break;
					case "king": location = (int)locations.coroniaKing; break;
					case "bikke": location = (int)locations.pirate; break;
					case "marsh": location = (int)locations.marsh; break;
					case "astos": location = (int)locations.astos; break;
					case "matoya": location = (int)locations.matoya; break;
					case "elf": location = (int)locations.elfPrince; break;
					case "locked_cornelia": location = (int)locations.coroniaTreasury; break;
					case "nerrick": location = (int)locations.dwarf; break;
					case "vampire": location = (int)locations.vampire; break;
					case "sarda": location = (int)locations.sage; break;
					case "ice": location = (int)locations.iceCave; break;
					case "citadel_of_trials": location = (int)locations.ordeals; break;
					case "fairy": location = (int)locations.gaia; break;
					case "mermaids": location = (int)locations.shrine5F; break;
					case "lefien": location = (int)locations.lefein; break;
					case "waterfall": location = (int)locations.waterfall; break;
					case "sky2": location = (int)locations.adamantite; break;
					case "smyth": location = (int)locations.excal; break;
					case "lich": location = (int)locations.lich; break;
					case "kary": location = (int)locations.marilith; break;
					case "kraken": location = (int)locations.kraken; break;
					case "tiamat": location = (int)locations.tiamat; break;
					case "dr_unne": location = (int)locations.unne ; break;
				}

				if (keyItem != -1 && location != -1)
				{
					ld.Add(new locationData(keyItem, location));
					complete.Add(location);
				}
			}

			List<int> allLocs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
			List<int> bad = allLocs.Except(complete).ToList();

			foreach (int reallyBad in bad)
				ld.Add(new locationData(0, reallyBad));

			// NOW to go through the dreaded act of updating all of the JSON files..........
			foreach (locationData loc in ld)
			{
				string file = "";
				string file2 = "";
				switch (loc.ff1Event)
				{
					case (int)locations.sarah:
						file = Path.Combine(directory, "Map_20011", "Map_20011_2", "sc_e_0004_1.json");
						file2 = Path.Combine(directory, "Map_20011", "Map_20011_2", "sc_e_0004_2.json");
						break;
					case (int)locations.coroniaKing: file = Path.Combine(directory, "Map_20011", "Map_20011_2", "sc_e_0003_3.json"); break;
					case (int)locations.pirate: file = Path.Combine(directory, "Map_20040", "Map_20040", "sc_e_0009_2.json"); break;
					case (int)locations.marsh: file = Path.Combine(directory, "Map_30021", "Map_30021_3", "sc_e_0010_1.json"); break;
					case (int)locations.astos: file = Path.Combine(directory, "Map_20081", "Map_20081_1", "sc_e_0011_2.json"); break;
					case (int)locations.matoya: file = Path.Combine(directory, "Map_20031", "Map_20031_1", "sc_e_0012.json"); break;
					case (int)locations.elfPrince: file = Path.Combine(directory, "Map_20071", "Map_20071_1", "sc_e_0013.json"); break;
					case (int)locations.coroniaTreasury: file = Path.Combine(directory, "Map_20011", "Map_20011_1", "sc_e_0014.json"); break;
					case (int)locations.dwarf: file = Path.Combine(directory, "Map_20051", "Map_20051_1", "sc_e_0015.json"); break;
					case (int)locations.excal: file = Path.Combine(directory, "Map_20051", "Map_20051_1", "sc_e_0052.json"); break;
					case (int)locations.vampire: file = Path.Combine(directory, "Map_30031", "Map_30031_3", "sc_e_0017.json"); break;
					case (int)locations.sage: file = Path.Combine(directory, "Map_20101", "Map_20101_1", "sc_e_0019.json"); break;
					case (int)locations.lich: file = Path.Combine(directory, "Map_30031", "Map_30031_5", "sc_e_0021_2.json"); break;
					case (int)locations.crescentLake: file = Path.Combine(directory, "Map_20110", "Map_20110", "sc_e_0022.json"); break;
					case (int)locations.marilith: file = Path.Combine(directory, "Map_30051", "Map_30051_6", "sc_e_0023_2.json"); break;
					case (int)locations.iceCave: file = Path.Combine(directory, "Map_30061", "Map_30061_4", "sc_e_0024_2.json"); break;
					case (int)locations.airship: file = Path.Combine(directory, "Map_10010", "Map_10010", "sc_e_0025_4.json"); break;
					case (int)locations.gaia:	file = Path.Combine(directory, "Map_20150", "Map_20150", "sc_e_0029.json");	break;
					case (int)locations.waterfall: file = Path.Combine(directory, "Map_30091", "Map_30091_1", "sc_e_0026.json"); break;
					case (int)locations.shrine5F: file = Path.Combine(directory, "Map_30081", "Map_30081_8", "sc_e_0033.json"); break;
					case (int)locations.kraken: file = Path.Combine(directory, "Map_30081", "Map_30081_1", "sc_e_0036_2.json"); break;
					case (int)locations.unne:	file = Path.Combine(directory, "Map_20090", "Map_20090", "sc_e_0034.json");	break;
					case (int)locations.lefein: file = Path.Combine(directory, "Map_20160", "Map_20160", "sc_e_0035.json"); break;
					case (int)locations.ordeals: file = Path.Combine(directory, "Map_30071", "Map_30071_3", "sc_e_0047.json"); break;
					case (int)locations.adamantite: file = Path.Combine(directory, "Map_30111", "Map_30111_2", "sc_e_0051.json"); break;
					case (int)locations.tiamat: file = Path.Combine(directory, "Map_30111", "Map_30111_5", "sc_e_0037_2.json"); break;
				}

				for (int i = 1; i <= 2; i++)
				{
					string fileToUse = (i == 1 ? file : file2 != "" ? file2 : null);
					if (fileToUse != null)
						JsonRewrite(fileToUse, loc);
				}
			}

			// SetVehicle - 3/145/160 for airship.  4/145/162 for ship.
		}

		private void JsonRewrite(string fileName, locationData loc)
		{
			string json = File.ReadAllText(fileName);
			EventJSON jEvents = JsonConvert.DeserializeObject<EventJSON>(json);
			foreach (var singleScript in jEvents.Mnemonics)
			{
				if (singleScript.mnemonic == "MsgFunfare")
					singleScript.operands.sValues[0] = "MSG_KEY_" + (loc.keyItem > 0 ? loc.keyItem.ToString() : "A1");
				if (singleScript.mnemonic == "GetItem" && singleScript.operands.iValues[1] >= 0)
				{
					int keyItem = 2;
					switch (loc.keyItem)
					{
						case (int)flags.floater: keyItem = 55; break;
						case (int)flags.chime: keyItem = 56; break;
						case (int)flags.cube: keyItem = 58; break;
						case (int)flags.oxyale: keyItem = 60; break;
						case (int)flags.crown: keyItem = 46; break;
						case (int)flags.crystalEye: keyItem = 47; break;
						case (int)flags.joltTonic: keyItem = 48; break;
						case (int)flags.mysticKey: keyItem = 49; break;
						case (int)flags.nitroPowder: keyItem = 50; break;
						case (int)flags.starRuby: keyItem = 53; break;
						case (int)flags.rod: keyItem = 54; break;
						case (int)flags.slab: keyItem = 52; break;
						case (int)flags.adamantite: keyItem = 51; break;
						case (int)flags.lute: keyItem = 45; break;
						case (int)flags.ratTail: keyItem = 57; break;
						case (int)flags.excalibur: keyItem = 92; break;
					}
					singleScript.operands.iValues[0] = keyItem;
					singleScript.operands.iValues[1] = keyItem == 2 ? 0 : 1;
				}
				if (singleScript.mnemonic == "SetFlag" && singleScript.operands.iValues[0] < 100 && singleScript.operands.sValues[0] == "ScenarioFlag1")
					singleScript.operands.iValues[0] = loc.keyItem > 0 ? loc.keyItem : 0;
			}

			JsonSerializer serializer = new JsonSerializer();

			using (StreamWriter sw = new StreamWriter(fileName))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, jEvents);
			}
		}
	}
}
