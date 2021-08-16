using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Inventory
{
	public class EventJSON
	{
		public class Rootobject
		{
			public Systemflag SystemFlag { get; set; }
			public Segment[] Segments { get; set; }
			public string[] ScriptLocal { get; set; }
			public int[] ScriptLocalValue { get; set; }
			public Mnemonic[] Mnemonics { get; set; }
			public Animation[] Animations { get; set; }
			public string Name { get; set; }
			public Title Title { get; set; }
		}

		public class Systemflag
		{
			public int SkipInitialize { get; set; }
			public int KeepPlayerPuppet { get; set; }
			public int KeepBadStatusVisual { get; set; }
			public int RidingVehicle { get; set; }
		}

		public class Title
		{
			public string main { get; set; }
			public string sub { get; set; }
		}

		public class Segment
		{
			public string Label { get; set; }
			public int EntryPoint { get; set; }
			public int Count { get; set; }
		}

		public class Mnemonic
		{
			public string label { get; set; }
			public string mnemonic { get; set; }
			public Operands operands { get; set; }
			public int type { get; set; }
			public string comment { get; set; }
		}

		public class Operands
		{
			public int?[] iValues { get; set; }
			public float?[] rValues { get; set; }
			public string[] sValues { get; set; }
		}

		public class Animation
		{
			public string name { get; set; }
			public Frame[] frames { get; set; }
			public float play_speed { get; set; }
			public int play_mode { get; set; }
			public bool is_reverse { get; set; }
			public string next_anim_name { get; set; }
		}

		public class Frame
		{
			public string sprite_name { get; set; }
			public float offsetx { get; set; }
			public float offsety { get; set; }
			public float alpha { get; set; }
			public Rgb rgb { get; set; }
			public bool flip { get; set; }
		}

		public class Rgb
		{
			public float r { get; set; }
			public float g { get; set; }
			public float b { get; set; }
			public float a { get; set; }
		}
	}
}
