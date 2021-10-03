using FF1_PRR.Inventory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF1_PRR.Common.Common;

namespace FF1_PRR.Randomize
{
	public class Treasure
	{
		private class ChestInfo
		{
			public int flag_id { get; set; }
			public string map { get; set; }
			public string submap { get; set; } 
			public int entity_id { get; set; }
			public int content_id { get; set; }
			public int content_num { get; set; }
			public string script_id { get; set; }
		}

		List<ChestInfo> treasureList = new List<ChestInfo>();

		public Treasure(Random r1, int randoLevel, string fileName, bool traditional)
		{

		}
	}
}
