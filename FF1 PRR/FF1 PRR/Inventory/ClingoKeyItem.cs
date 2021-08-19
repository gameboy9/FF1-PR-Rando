using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Inventory
{
	class ClingoKeyItem
	{
		public string Solver { get; set; }
		public string[] Input { get; set; }
		public Call1[] Call { get; set; }
		public string Result { get; set; }
		public Models1 Models { get; set; }
		public int Calls { get; set; }
		public Time1 Time { get; set; }

		public class Models1
		{
			public int Number { get; set; }
			public string More { get; set; }
		}

		public class Time1
		{
			public float Total { get; set; }
			public float Solve { get; set; }
			public float Model { get; set; }
			public float Unsat { get; set; }
			public float CPU { get; set; }
		}

		public class Call1
		{
			public Witness[] Witnesses { get; set; }
		}

		public class Witness
		{
			public string[] Value { get; set; }
		}
	}
}
