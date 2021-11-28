using CsvHelper;
using Newtonsoft.Json;
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

		public Treasure(Random r1, int randoLevel, string datapath, bool traditional, bool fiendsRibbons)
		{
			using (var reader = new StreamReader(Path.Combine("data", "chestInfo.csv")))
			using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				treasureList = csv.GetRecords<ChestInfo>().ToList();
			}

			if (randoLevel == 1 || true) // Shuffle
            {
				List<(int,int)> contentsList = new List<(int,int)>();
				foreach (ChestInfo chest in treasureList)
                {
					contentsList.Add((chest.content_id, chest.content_num));
				}
				contentsList.Shuffle(r1);
				foreach (ChestInfo chest in treasureList)
				{
					(chest.content_id, chest.content_num) = contentsList[0];
					contentsList.RemoveAt(0);
				}
			}

			if (randoLevel == 2) // Standard
			{

			}
			if (randoLevel == 3) // Pro
			{

			}
			if (randoLevel == 4) // Wild
			{

			}

			// Now write the chests back
			foreach (var chestsByFile in treasureList.GroupBy(x => x.submap))
			{
				string filename = Path.Combine(datapath, chestsByFile.First().map, chestsByFile.First().submap, "entity_default.json");
				string json = File.ReadAllText(filename);
				EvRoot entity_default = JsonConvert.DeserializeObject<EvRoot>(json);
				foreach (var chest in chestsByFile)
				{
					foreach (EvLayer layer in entity_default.layers)
					{
						foreach (EvObject obj in layer.objects)
						{
							foreach (EvProperty property in obj.properties)
							{
								// really makes you wish you had lenses huh
								if (property.name == "flag_id")
								{
									if (Int32.Parse(property.value) == chest.flag_id)
									{
										if (fiendsRibbons && Armor.ribbon == chest.content_id)
                                        {
											obj.properties.Find(x => x.name == "content_id").value = Items.potion.ToString();
                                        }
										else
                                        {
											obj.properties.Find(x => x.name == "content_id").value = chest.content_id.ToString();
										}
										obj.properties.Find(x => x.name == "content_num").value = chest.content_num.ToString();
										obj.properties.Find(x => x.name == "message_key").value = (chest.content_id == 1) ? "MSG_OTHER_12" : "MSG_OTHER_11";
										goto NextChest;
									}
								}
							}
						}
					}
				NextChest:
					continue;
				}
				JsonSerializer serializer = new JsonSerializer();

				using (StreamWriter sw = new StreamWriter(filename))
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, entity_default);
				}
			}
		}
	}
}
