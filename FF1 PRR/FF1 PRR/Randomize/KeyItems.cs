using FF1_PRR.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
			int ff1Event { get; set; }
			int[] avoids { get; set; }

			public locationData(int ki, int ev, int[] avoid)
			{
				keyItem = ki;
				ff1Event = ev;
				avoids = avoid;
			}

			public int determineLocation(Random r1, int[] additionalAvoid)
			{
				bool legal = false;
				while (!legal)
				{
					ff1Event = r1.Next() % 26;
					if (!avoids.Contains(ff1Event) && !additionalAvoid.Contains(ff1Event))
						legal = true;
				}
				// If airship and canoe is found outside of the canal, canal must be awarded in lSarah, lCoroniaKing, lMarsh, lAstos, lMatoya, lElfPrince, lCoroniaTreasury, and lDwarf.
				// If airship is found inside of canal, canal and canoe can be anywhere.
				// If canoe is found inside of canal, canal can be expanded to the entire southern continent.

				return ff1Event;
			}
		}

		public KeyItems(Random r1)
		{
			List<locationData> ld = new List<locationData>();
			ld.Add(new locationData(lute, 0, new int[] { }));
			ld.Add(new locationData(crown, 0, new int[] { lAstos }));
			ld.Add(new locationData(crystalEye, 0, new int[] { lMatoya }));
			ld.Add(new locationData(joltTonic, 0, new int[] { lElfPrince }));
			ld.Add(new locationData(mysticKey, 0, new int[] { lCoroniaTreasury }));
			ld.Add(new locationData(nitroPowder, 0, new int[] { lDwarf }));
			ld.Add(new locationData(canal, 0, new int[] { lGaia, lWaterfall, lShrine5F, lKraken, lUnne, lLefein, lOrdeals, lAdamantite, lTiamat }));
			ld.Add(new locationData(starRuby, 0, new int[] { lSage }));
			ld.Add(new locationData(rod, 0, new int[] { lLich }));
			ld.Add(new locationData(earthCrystal, 0, new int[] { }));
			ld.Add(new locationData(canoe, 0, new int[] { lWaterfall }));
			ld.Add(new locationData(fireCrystal, 0, new int[] { }));
			ld.Add(new locationData(floater, 0, new int[] { lAirship }));
			ld.Add(new locationData(airship, 0, new int[] { lGaia, lWaterfall, lShrine5F, lKraken, lUnne, lLefein, lOrdeals, lAdamantite, lTiamat }));
			ld.Add(new locationData(cube, 0, new int[] { lAdamantite, lTiamat }));
			ld.Add(new locationData(oxyale, 0, new int[] { lShrine5F, lKraken }));
			ld.Add(new locationData(slab, 0, new int[] { lUnne }));
			ld.Add(new locationData(learnLufuin, 0, new int[] { lLefein }));
			ld.Add(new locationData(chime, 0, new int[] { lAdamantite, lKraken }));
			ld.Add(new locationData(waterCrystal, 0, new int[] { }));
			ld.Add(new locationData(airCrystal, 0, new int[] { }));
			ld.Add(new locationData(ratTail, 0, new int[] { }));
			ld.Add(new locationData(adamantite, 0, new int[] { lExcal }));
			ld.Add(new locationData(excalibur, 0, new int[] { }));
			ld.Add(new locationData(0, 0, new int[] { }));
			ld.Add(new locationData(0, 0, new int[] { }));

			List<int> complete = new List<int>();
			int airshipLocation = ld.Where(c => c.keyItem == airship).Single().determineLocation(r1, complete.ToArray());
			int canoeLocation;
			// If the airship was placed in a canoe location, we will have to avoid lMarilith, lIceCave, lAirship, lGaia, lWaterfall, lShrine5F, lKraken, lUnne, lLefein, lOrdeals, lAdamantite, lTiamat.
			if (airshipLocation == lAirship || airshipLocation == lMarilith || airshipLocation == lIceCave)
			{
				canoeLocation = ld.Where(c => c.keyItem == airship).Single()
					.determineLocation(r1, new int[] { airshipLocation, lMarilith, lIceCave, lAirship, lGaia, lWaterfall, lShrine5F, lKraken, lUnne, lLefein, lOrdeals, lAdamantite, lTiamat, lExcal });
			}
			else
			{
				canoeLocation = ld.Where(c => c.keyItem == airship).Single()
					.determineLocation(r1, new int[] { airshipLocation });
			}
			// If the airship and the canoe were placed outside of the canal, the canal must stay in-bounds.
			List<int> inbounds = new List<int>() { lSarah, lCoroniaKing, lPirate, lMarsh, lAstos, lMatoya, lElfPrince, lCoroniaTreasury, lDwarf };
			if (inbounds.Contains(airshipLocation) || inbounds.Contains(canoeLocation))
			{
				complete.Add(ld.Where(c => c.keyItem == canal).Single()
					.determineLocation(r1, new int[] { airshipLocation, canoeLocation }));
			} else
			{
				complete.Add(ld.Where(c => c.keyItem == canal).Single()
					.determineLocation(r1, new int[] { airshipLocation, canoeLocation, lVampire, lSage, lLich, lCrescentLake, lMarilith, lIceCave, lAirship, lGaia, lWaterfall, lShrine5F, lKraken, lUnne, lLefein, lOrdeals, lAdamantite, lTiamat, lExcal }));
			}
			complete.Add(airshipLocation);
			complete.Add(canoeLocation);
			// Now place the rest of the key items
			// Start with the more restricted items...
			complete.Add(ld.Where(c => c.keyItem == chime).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == cube).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == oxyale).Single().determineLocation(r1, complete.ToArray()));

			// Then only restricted at the turn-in spot...
			complete.Add(ld.Where(c => c.keyItem == crown).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == crystalEye).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == joltTonic).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == mysticKey).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == nitroPowder).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == starRuby).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == rod).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == floater).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == slab).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == learnLufuin).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == adamantite).Single().determineLocation(r1, complete.ToArray()));

			// Then the un-restricted items.
			complete.Add(ld.Where(c => c.keyItem == lute).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == earthCrystal).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == fireCrystal).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == waterCrystal).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == airCrystal).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == ratTail).Single().determineLocation(r1, complete.ToArray()));
			complete.Add(ld.Where(c => c.keyItem == excalibur).Single().determineLocation(r1, complete.ToArray()));

			// NOW to go through the dreaded act of updating all of the JSON files..........

			string json = "";
			EventJSON test = JsonConvert.DeserializeObject<EventJSON>(json);
		}
	}
}
