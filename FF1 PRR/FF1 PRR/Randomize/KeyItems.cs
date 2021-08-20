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
		public const int lute = 5;
		public const int crown = 10;
		public const int crystalEye = 11;
		public const int joltTonic = 12;
		public const int mysticKey = 13;
		public const int nitroPowder = 14;
		public const int canal = 15;
		public const int starRuby = 17;
		public const int rod = 19;
		public const int earthCrystal = 21;
		public const int canoe = 22;
		public const int fireCrystal = 23;
		public const int floater = 24;
		public const int airship = 25; // Also SysCall
		public const int cube = 26;
		public const int oxyale = 29;
		public const int slab = 31;
		public const int learnLufuin = 32;
		public const int chime = 33;
		public const int waterCrystal = 34;
		public const int airCrystal = 35;
		public const int ratTail = 45;
		public const int adamantite = 47;
		public const int excalibur = 48;

		// 26 locations
		public const int lSarah = 1;
		public const int lCoroniaKing = 2;
		public const int lPirate = 3;
		public const int lMarsh = 4;
		public const int lAstos = 5;
		public const int lMatoya = 6;
		public const int lElfPrince = 7;
		public const int lCoroniaTreasury = 8;
		public const int lDwarf = 9;
		public const int lExcal = 10;
		public const int lVampire = 11;
		public const int lSage = 12;
		public const int lLich = 13;
		public const int lCrescentLake = 14;
		public const int lMarilith = 15;
		public const int lIceCave = 16;
		public const int lAirship = 17;
		public const int lGaia = 18;
		public const int lWaterfall = 19;
		public const int lShrine5F = 20;
		public const int lKraken = 21;
		public const int lUnne = 22;
		public const int lLefein = 23;
		public const int lOrdeals = 24;
		public const int lAdamantite = 25;
		public const int lTiamat = 26;

		private class locationData
		{
			public int keyItem { get; set; }
			public int ff1Event { get; set; }
			int[] avoids { get; set; }
			string jsonFile { get; set; }

			public locationData(int ki, int ev)
			{
				keyItem = ki;
				ff1Event = ev;
			}

			public int determineLocation(Random r1, int[] additionalAvoid)
			{
				bool legal = false;
				while (!legal)
				{
					ff1Event = (r1.Next() % 26) + 1;
					if (!avoids.Contains(ff1Event) && !additionalAvoid.Contains(ff1Event))
						legal = true;
				}
				// If airship and canoe is found outside of the canal, canal must be awarded in lSarah, lCoroniaKing, lMarsh, lAstos, lMatoya, lElfPrince, lCoroniaTreasury, and lDwarf.
				// If airship is found inside of canal, canal and canoe can be anywhere.
				// If canoe is found inside of canal, canal can be expanded to the entire southern continent.

				return ff1Event;
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
					case "lute": keyItem = lute; break;
					case "crown": keyItem = crown; break;
					case "crystal": keyItem = crystalEye; break;
					case "jolt_tonic": keyItem = joltTonic; break;
					case "mystic_key": keyItem = mysticKey; break;
					case "nitro_powder": keyItem = nitroPowder; break;
					case "canal": keyItem = canal; break;
					case "star_ruby": keyItem = starRuby; break;
					case "rod": keyItem = rod; break;
					case "levistone": keyItem = floater; break;
					//case "gear": keyItem = gear; break;
					case "rats_tail": keyItem = ratTail; break;
					case "oxyale": keyItem = oxyale; break;
					case "rosetta_stone": keyItem = slab; break;
					case "chime": keyItem = chime; break;
					case "warp_cube": keyItem = cube; break;
					case "adamantite": keyItem = adamantite; break;
					case "excalibur": keyItem = excalibur; break;
					case "earth": keyItem = earthCrystal; break;
					case "fire": keyItem = fireCrystal; break;
					case "water": keyItem = waterCrystal; break;
					case "air": keyItem = airCrystal; break;
					case "lufienish": keyItem = learnLufuin; break;
				}

				switch (values[1])
				{
					case "sara": location = lSarah; break;
					case "king": location = lCoroniaKing; break;
					case "bikke": location = lPirate; break;
					case "marsh": location = lMarsh; break;
					case "astos": location = lAstos; break;
					case "matoya": location = lMatoya; break;
					case "elf": location = lElfPrince; break;
					case "locked_cornelia": location = lCoroniaTreasury; break;
					case "nerrick": location = lDwarf; break;
					case "vampire": location = lVampire; break;
					case "sarda": location = lSage; break;
					case "ice": location = lIceCave; break;
					case "citadel_of_trials": location = lOrdeals; break;
					case "fairy": location = lGaia; break;
					case "mermaids": location = lShrine5F; break;
					case "lefien": location = lLefein; break;
					case "waterfall": location = lWaterfall; break;
					case "sky2": location = lAdamantite; break;
					case "smyth": location = lExcal; break;
					case "lich": location = lLich; break;
					case "kary": location = lMarilith; break;
					case "kraken": location = lKraken; break;
					case "tiamat": location = lTiamat; break;
					case "dr_unne": location = lUnne ; break;
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
					case lSarah:
						file = Path.Combine(directory, "Map_20011", "Map_20011_2", "sc_e_0004_1.json");
						file2 = Path.Combine(directory, "Map_20011", "Map_20011_2", "sc_e_0004_2.json");
						break;
					case lCoroniaKing: file = Path.Combine(directory, "Map_20011", "Map_20011_2", "sc_e_0003_3.json"); break;
					case lPirate: file = Path.Combine(directory, "Map_20040", "Map_20040", "sc_e_0009_2.json"); break;
					case lMarsh: file = Path.Combine(directory, "Map_30021", "Map_30021_3", "sc_e_0010_1.json"); break;
					case lAstos: file = Path.Combine(directory, "Map_20081", "Map_20081_1", "sc_e_0011_2.json"); break;
					case lMatoya: file = Path.Combine(directory, "Map_20031", "Map_20031_1", "sc_e_0012.json"); break;
					case lElfPrince: file = Path.Combine(directory, "Map_20071", "Map_20071_1", "sc_e_0013.json"); break;
					case lCoroniaTreasury: file = Path.Combine(directory, "Map_20011", "Map_20011_1", "sc_e_0014.json"); break;
					case lDwarf: file = Path.Combine(directory, "Map_20051", "Map_20051_1", "sc_e_0015.json"); break;
					case lExcal: file = Path.Combine(directory, "Map_20051", "Map_20051_1", "sc_e_0052.json"); break;
					case lVampire: file = Path.Combine(directory, "Map_30031", "Map_30031_3", "sc_e_0017.json"); break;
					case lSage: file = Path.Combine(directory, "Map_20101", "Map_20101_1", "sc_e_0019.json"); break;
					case lLich: file = Path.Combine(directory, "Map_30031", "Map_30031_5", "sc_e_0021_2.json"); break;
					case lCrescentLake: file = Path.Combine(directory, "Map_20110", "Map_20110", "sc_e_0022.json"); break;
					case lMarilith: file = Path.Combine(directory, "Map_30051", "Map_30051_6", "sc_e_0023_2.json"); break;
					case lIceCave: file = Path.Combine(directory, "Map_30061", "Map_30061_4", "sc_e_0024_2.json"); break;
					case lAirship: file = Path.Combine(directory, "Map_10010", "Map_10010", "sc_e_0025_4.json"); break;
					case lGaia:	file = Path.Combine(directory, "Map_20150", "Map_20150", "sc_e_0029.json");	break;
					case lWaterfall: file = Path.Combine(directory, "Map_30091", "Map_30091_1", "sc_e_0026.json"); break;
					case lShrine5F: file = Path.Combine(directory, "Map_30081", "Map_30081_8", "sc_e_0033.json"); break;
					case lKraken: file = Path.Combine(directory, "Map_30081", "Map_30081_1", "sc_e_0036_2.json"); break;
					case lUnne:	file = Path.Combine(directory, "Map_20090", "Map_20090", "sc_e_0034.json");	break;
					case lLefein: file = Path.Combine(directory, "Map_20160", "Map_20160", "sc_e_0035.json"); break;
					case lOrdeals: file = Path.Combine(directory, "Map_30071", "Map_30071_3", "sc_e_0047.json"); break;
					case lAdamantite: file = Path.Combine(directory, "Map_30111", "Map_30111_2", "sc_e_0051.json"); break;
					case lTiamat: file = Path.Combine(directory, "Map_30111", "Map_30111_5", "sc_e_0037_2.json"); break;
				}

				string json = File.ReadAllText(file);
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
							case floater: keyItem = 55; break;
							case chime: keyItem = 56; break;
							case cube: keyItem = 58; break;
							case oxyale: keyItem = 60; break;
							case crown: keyItem = 46; break;
							case crystalEye: keyItem = 47; break;
							case joltTonic: keyItem = 48; break;
							case mysticKey: keyItem = 49; break;
							case nitroPowder: keyItem = 50; break;
							case starRuby: keyItem = 53; break;
							case rod: keyItem = 54; break;
							case slab: keyItem = 52; break;
							case adamantite: keyItem = 51; break;
							case lute: keyItem = 45; break;
							case ratTail: keyItem = 57; break;
							case excalibur: keyItem = 92; break;
						}
						singleScript.operands.iValues[0] = keyItem;
						singleScript.operands.iValues[1] = keyItem == 2 ? 0 : 1;
					}
					if (singleScript.mnemonic == "SetFlag" && singleScript.operands.iValues[0] < 100 && singleScript.operands.sValues[0] == "ScenarioFlag1")
						singleScript.operands.iValues[0] = loc.keyItem > 0 ? loc.keyItem : 0;
				}

				JsonSerializer serializer = new JsonSerializer();

				using (StreamWriter sw = new StreamWriter(file))
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, jEvents);
				}

				if (file2 != "")
				{
					json = File.ReadAllText(file2);
					jEvents = JsonConvert.DeserializeObject<EventJSON>(json);
					foreach (var singleScript in jEvents.Mnemonics)
					{
						if (singleScript.mnemonic == "MsgFunfare" && singleScript.operands.iValues[1] >= 0)
							singleScript.operands.sValues[0] = "MSG_KEY_" + (loc.keyItem > 0 ? loc.keyItem.ToString() : "A1");
						if (singleScript.mnemonic == "GetItem" && singleScript.operands.iValues[1] >= 0)
						{
							int keyItem = 2;
							switch (loc.keyItem) {
								case floater: keyItem = 55; break;
								case chime: keyItem = 56; break;
								case cube: keyItem = 58; break;
								case oxyale: keyItem = 60; break;
								case crown: keyItem = 46; break;
								case crystalEye: keyItem = 47; break;
								case joltTonic: keyItem = 48; break;
								case mysticKey: keyItem = 49; break;
								case nitroPowder: keyItem = 50; break;
								case starRuby: keyItem = 53; break;
								case rod: keyItem = 54; break;
								case slab: keyItem = 52; break;
								case adamantite: keyItem = 51; break;
								case lute: keyItem = 45; break;
								case ratTail: keyItem = 57; break;
								case excalibur: keyItem = 92; break;
							}
							singleScript.operands.iValues[0] = keyItem;
							singleScript.operands.iValues[1] = keyItem == 2 ? 0 : 1;
						}
						if (singleScript.mnemonic == "SetFlag" && singleScript.operands.iValues[0] < 100)
							singleScript.operands.iValues[0] = loc.keyItem > 0 ? loc.keyItem : 0;
					}

					using (StreamWriter sw = new StreamWriter(file2))
					using (JsonWriter writer = new JsonTextWriter(sw))
					{
						serializer.Serialize(writer, jEvents);
					}
				}
			}

			// SetVehicle - 3/145/160 for airship.  4/145/162 for ship.

		}
	}
}
