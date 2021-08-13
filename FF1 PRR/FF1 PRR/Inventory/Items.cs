using System;
using System.Collections.Generic;
using static FF1_PRR.Common.Common;

namespace FF1_PRR.Inventory
{
	public class Items
	{
		public const int potion = 2; // t1
		public const int antidote = 11; // t1
		public const int goldNeedle = 14; // t2
		public const int sleepingBag = 17; // t1
		public const int tent = 18; // t2
		public const int cottage = 19; // t2
		public const int hiPotion = 3; // t3
		public const int xPotion = 4; // t4
		public const int ether = 5; // t3
		public const int dryEther = 7; // t4
		public const int elixer = 8; // t5
		public const int phoenixDown = 10; // t4
		public const int remedy = 15; // t3
		public const int eyeDrops = 12; // t2
		public const int echoGrass = 13; // t2
		public const int strengthTonic = 34; // t5
		public const int giantTonic = 32; // t5
		public const int protectDrink = 35; // t5
		public const int speedDrink = 36; // t5

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { potion, antidote, sleepingBag },
			  new List<int> { goldNeedle, tent, cottage, eyeDrops, echoGrass },
			  new List<int> { hiPotion, ether, remedy },
			  new List<int> { phoenixDown, dryEther, xPotion },
			  new List<int> { elixer, strengthTonic, giantTonic, protectDrink, speedDrink } 
		};

		public List<int> all = new List<int>
		{
			potion, antidote, sleepingBag,
			goldNeedle, tent, cottage, eyeDrops, echoGrass,
			hiPotion, ether, remedy,
			phoenixDown, dryEther, xPotion,
			elixer, strengthTonic, giantTonic, protectDrink, speedDrink
		};

		public List<List<int>> tiersTraditional = new List<List<int>>
			{ new List<int> { potion, antidote, sleepingBag },
			  new List<int> { goldNeedle, tent },
			  new List<int> { cottage }
		};

		public List<int> allTraditional = new List<int>
		{
			potion, antidote, sleepingBag,
			goldNeedle, tent, cottage
		};

		public int selectItem(Random r1, int tier, bool traditional)
		{
			if (traditional)
			{
				if (tier >= tiersTraditional.Count) tier = tiersTraditional.Count;
				tier--;
				return tier == -1 ? allTraditional[r1.Next() % all.Count] : 
					tiersTraditional[tier][r1.Next() % tiersTraditional[tier].Count];
			}
			else
			{
				if (tier >= tiers.Count) tier = tiers.Count;
				tier--;
				return tier == -1 ? all[r1.Next() % all.Count] : tiers[tier][r1.Next() % tiers[tier].Count];
			}
		}

		public List<int> shuffleTraditional(Random r1)
		{
			List<int> shuffler = new List<int> {
				potion, antidote, sleepingBag,
				potion, antidote, sleepingBag, tent,
				potion, antidote, goldNeedle, tent, cottage,
				potion, antidote, tent, cottage,
				potion, antidote, goldNeedle, tent, cottage,
				potion, antidote, tent, cottage
			};

			shuffler.Shuffle(r1);
			return shuffler;
		}

		public List<int> shuffleModern(Random r1)
		{
			List<int> shuffler = new List<int> {
				potion, antidote, sleepingBag, phoenixDown,
				potion, ether, antidote, eyeDrops, phoenixDown,
				potion, antidote, goldNeedle, echoGrass, tent, cottage,
				potion, hiPotion, ether, phoenixDown, tent, cottage,
				hiPotion, ether, remedy, goldNeedle, cottage,
				hiPotion, ether, phoenixDown, tent, cottage
			};

			shuffler.Shuffle(r1);
			return shuffler;
		}
	}
}
