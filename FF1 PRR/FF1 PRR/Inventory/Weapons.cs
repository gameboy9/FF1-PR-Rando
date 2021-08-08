using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Inventory
{
	class Weapons
	{
		public const int knife = 63; // t1
		public const int dagger = 64; // t1
		public const int mythrilKnife = 65; // t2
		public const int catClaws = 67; // t5
		public const int rapier = 71; // t1
		public const int saber = 72; // t2
		public const int broadsword = 73; // t2
		public const int werebuster = 74; // t3
		public const int runeblade = 75; // t3
		public const int wyrmkiller = 76; // t3
		public const int coralSword = 77; // t3
		public const int longsword = 78; // t3
		public const int greatSword = 79; // t3
		public const int razer = 80; // t3
		public const int mythrilSword = 81; // t3
		public const int vorpalSword = 82; // t5
		public const int flameSword = 83; // t4
		public const int iceBrand = 86; // t4
		public const int defender = 87; // t5
		public const int sunBlade = 89; // t5
		public const int excalibur = 92; // t6
		public const int scimitar = 96; // t1
		public const int falchion = 97; // t2
		public const int sasukeBlade = 100; // t4
		public const int masamune = 103; // t6
		public const int nunchaku = 104; // t1
		public const int ironNunchaku = 105; // t1
		public const int battleAxe = 106; // t3
		public const int greatAxe = 107; // t3
		public const int mythrilAxe = 109; // t4
		public const int lightAxe = 110; // t5
		public const int hammer = 114; // t1
		public const int mythrilHammer = 115; // t1
		public const int thorHammer = 116; // t5
		public const int staff = 118; // t1
		public const int healingStaff = 119; // t4
		public const int powerStaff = 120; // t2
		public const int mageStaff = 121; // t5
		public const int crosier = 122; // t2
		public const int wizardStaff = 123; // t5

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { knife, dagger, rapier, scimitar, nunchaku, ironNunchaku, hammer, mythrilHammer, staff },
			  new List<int> { mythrilKnife, saber, broadsword, falchion, powerStaff, crosier },
			  new List<int> { werebuster, runeblade, wyrmkiller, coralSword, longsword, greatSword, razer, mythrilSword, battleAxe, greatAxe },
			  new List<int> { flameSword, iceBrand, sasukeBlade, mythrilAxe, healingStaff },
			  new List<int> { catClaws, vorpalSword, defender, sunBlade, lightAxe, thorHammer, mageStaff, wizardStaff },
			  new List<int> { excalibur, masamune }
		};
	}
}
