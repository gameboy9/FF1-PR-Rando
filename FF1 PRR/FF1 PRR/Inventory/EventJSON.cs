using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Common
{
	// JSON Objects for sc_e_xxxx.json files
	public class EventJSON
	{
		public Systemflag SystemFlag { get; set; }
		public Segment[] Segments { get; set; }
		public string[] ScriptLocal { get; set; }
		public int[] ScriptLocalValue { get; set; }
		public Mnemonic[] Mnemonics { get; set; }
		public Animation[] Animations { get; set; }
		public string Name { get; set; }
		public Title1 Title { get; set; }

		public class Systemflag
		{
			public int SkipInitialize { get; set; }
			public int KeepPlayerPuppet { get; set; }
			public int KeepBadStatusVisual { get; set; }
			public int RidingVehicle { get; set; }
		}

		public class Title1
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

	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	// JSON Objects for ev_e_xxxx.json and entity_deafult.json files 
	public class EvProperty
	{
		public string name { get; set; }
		public string type { get; set; }
		public string value { get; set; }
	}

	public class EvObject
	{
		public int gid { get; set; }
		public int height { get; set; }
		public int id { get; set; }
		public string name { get; set; }
		public List<EvProperty> properties { get; set; }
		public int rotation { get; set; }
		public string type { get; set; }
		public bool visible { get; set; }
		public int width { get; set; }
		public int x { get; set; }
		public int y { get; set; }
	}

	public class EvLayer
	{
		public string draworder { get; set; }
		public int id { get; set; }
		public string name { get; set; }
		public List<EvObject> objects { get; set; }
		public double opacity { get; set; }
		public string type { get; set; }
		public bool visible { get; set; }
		public int x { get; set; }
		public int y { get; set; }
	}

	public class EvRoot
	{
		public int id { get; set; }
		public List<EvLayer> layers { get; set; }
		public string name { get; set; }
		public double opacity { get; set; }
		public string type { get; set; }
		public bool visible { get; set; }
		public int x { get; set; }
		public int y { get; set; }
		public int width { get; set; }
		public int height { get; set; }
	}
}
