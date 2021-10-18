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
		/*
		private void btnChestInfo_Click(object sender, EventArgs e)
		{
			string MAP_PATH = Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map");
			DirectoryInfo maproot = new DirectoryInfo(MAP_PATH);
			DirectoryInfo[] maps = maproot.GetDirectories();
			List<ChestInfo> chests = new List<ChestInfo>();
			foreach (DirectoryInfo map in maps)
			{
				var name = map.Name;
				if (name == "Map_Far" || name == "Map_Near" || name == "Map_Script" || name == "MapFilter")
				{
					continue;
				}
				DirectoryInfo[] submapsArray = map.GetDirectories();
				foreach (DirectoryInfo submap in submapsArray)
				{
					// submaps.Add(submap);
					string json = File.ReadAllText(Path.Combine(submap.FullName, "entity_default.json"));
					EvRoot entity_default = JsonConvert.DeserializeObject<EvRoot>(json);
					foreach (EvLayer layer in entity_default.layers)
					{
						foreach (EvObject obj in layer.objects)
						{
							foreach (EvProperty property in obj.properties)
							{
								// really makes you wish you had lenses huh
								if (property.name == "flag_id")
								{
									if (Int32.Parse(property.value) < 500)
									{
										chests.Add(new ChestInfo()
										{
											flag_id = property.value,
											map = map.Name,
											submap = submap.Name,
											entity_id = obj.properties.Find(x => x.name == "entity_id").value,
											content_id = obj.properties.Find(x => x.name == "content_id").value,
											content_num = obj.properties.Find(x => x.name == "content_num").value,
											script_id = obj.properties.Find(x => x.name == "script_id").value
										});
									}
								}
							}
						}
					}
				}
			}
			using (var writer = new StreamWriter("chestInfo.csv"))
			using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(chests);
			}
		}
		*/

		List<ChestInfo> treasureList = new List<ChestInfo>();

		public Treasure(Random r1, int randoLevel, string fileName, bool traditional)
		{

		}
	}
}
