using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
