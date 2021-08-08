using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Inventory
{
	class Armor
	{
		public const int clothes = 134; // t1
		public const int whiteRobe = 136; // t5
		public const int blackRobe = 137; // t5
		public const int leatherArmor = 145; // t1
		public const int chainMail = 146; // t1
		public const int mythrilMail = 147; // t3
		public const int ironArmor = 148; // t2
		public const int iceArmor = 149; // t4
		public const int flameMail = 150; // t4
		public const int knightArmor = 151; // t3
		public const int diamondArmor = 153; // t5
		public const int dragonMail = 154; // t5
		public const int copperArmlet = 156; // t1
		public const int silverArmlet = 157; // t2
		public const int rubyArmlet = 158; // t3
		public const int diamondArmlet = 160; // t5
		public const int leatherShield = 161; // t1
		public const int buckler = 162; // t3
		public const int ironShield = 163; // t2
		public const int mythrilShield = 164; // t3
		public const int iceShield = 165; // t4
		public const int flameShield = 166; // t4
		public const int diamondShield = 168; // t4
		public const int aegisShield = 170; // t5
		public const int protectCloak = 173; // t4
		public const int leatherCap = 175; // t1
		public const int ribbon = 183; // t5
		public const int helm = 184; // t1
		public const int greatHelm = 185; // t2
		public const int healingHelm = 186; // t5
		public const int mythrilHelm = 187; // t3
		public const int diamondHelm = 188; // t4
		public const int leatherGloves = 191; // t1
		public const int bronzeGloves = 192; // t2
		public const int steelGloves = 193; // t3
		public const int gauntlets = 194; // t5
		public const int giantGloves = 195; // t5
		public const int mythrilGloves = 197; // t4
		public const int diamondGloves = 198; // t5
		public const int protectRing = 202; // t4

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { clothes, leatherArmor, chainMail, copperArmlet, leatherShield, leatherCap, helm, leatherGloves },
			  new List<int> { ironArmor, silverArmlet, ironShield, greatHelm, bronzeGloves },
			  new List<int> { mythrilMail, knightArmor, rubyArmlet, buckler, mythrilShield, mythrilHelm, steelGloves },
			  new List<int> { iceArmor, flameMail, iceShield, flameShield, diamondShield, protectCloak, diamondHelm, mythrilGloves, protectRing },
			  new List<int> { whiteRobe, blackRobe, diamondArmor, dragonMail, diamondArmlet, aegisShield, ribbon, healingHelm, gauntlets, giantGloves, diamondGloves }
		};
	}
}
