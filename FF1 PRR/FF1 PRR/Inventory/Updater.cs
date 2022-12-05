using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1_PRR.Inventory
{
	public class Updater
	{
		public Updater(string directory, ref DateTime lastGameAssets)
		{
			DateTime currentGameAssets = File.GetLastWriteTime("GameAssets.zip");
			// Round down to prevent bad comparisons.
			currentGameAssets = new DateTime(currentGameAssets.Year, currentGameAssets.Month, currentGameAssets.Day, currentGameAssets.Hour, currentGameAssets.Minute, 0);
			if (DateTime.Compare(currentGameAssets, lastGameAssets) > 0)
			{
				ZipFile.ExtractToDirectory("BepInEx.zip", directory, true);

				ZipFile.ExtractToDirectory("GameAssets.zip", Path.Combine(directory, "FINAL FANTASY_Data", "StreamingAssets", "Assets"), true);
				lastGameAssets = currentGameAssets;
			}
		}
	}
}
