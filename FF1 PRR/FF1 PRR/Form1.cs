using FF1_PRR.Randomize;
using FF1_PRR.Inventory;
using Newtonsoft.Json;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF1_PRR
{
	public partial class FF1PRR : Form
	{
		bool loading = true;
		Random r1;

		public FF1PRR()
		{
			InitializeComponent();
		}

		public void DetermineFlags(object sender, EventArgs e)
		{
			if (loading) return;

			string flags = "";
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { ShuffleBossSpots, KeyItems, Traditional, randoMagic, keepMagicPermissions }));
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { flagTraditionalTreasure, flagRebalanceBosses, flagFiendsDropRibbons, flagRebalancePrices, flagRestoreCritRating, flagWandsAddInt }));
			// Combo boxes time...
			flags += convertIntToChar(RandoShop.SelectedIndex + (8 * monsterXPGPBoost.SelectedIndex));
			flags += convertIntToChar(flagT.SelectedIndex + (8 * 0));
			RandoFlags.Text = flags;

			flags = "";
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { CuteHats }));
			VisualFlags.Text = flags;
		}

		private void determineChecks(object sender, EventArgs e)
		{
			if (loading && RandoFlags.Text.Length < 4)
				RandoFlags.Text = "BwA2";
			else if (RandoFlags.Text.Length < 4)
				return;

			if (loading && VisualFlags.Text.Length < 1)
				VisualFlags.Text = "0";
			else if (VisualFlags.Text.Length < 1)
				return;

			loading = true;

			string flags = RandoFlags.Text;
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(0, 1))), new CheckBox[] { ShuffleBossSpots, KeyItems, Traditional, randoMagic, keepMagicPermissions });
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(1, 1))), new CheckBox[] { flagTraditionalTreasure, flagRebalanceBosses, flagFiendsDropRibbons, flagRebalancePrices, flagRestoreCritRating, flagWandsAddInt });
			RandoShop.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(2, 1))) % 8;
			monsterXPGPBoost.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(2, 1))) / 8;
			flagT.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(3, 1))) % 8;

			flags = VisualFlags.Text;
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(0, 1))), new CheckBox[] { CuteHats });

			loading = false;
		}

		private int checkboxesToNumber(CheckBox[] boxes)
		{
			int number = 0;
			for (int lnI = 0; lnI < Math.Min(boxes.Length, 6); lnI++)
				number += boxes[lnI].Checked ? (int)Math.Pow(2, lnI) : 0;

			return number;
		}

		private int numberToCheckboxes(int number, CheckBox[] boxes)
		{
			for (int lnI = 0; lnI < Math.Min(boxes.Length, 6); lnI++)
				boxes[lnI].Checked = number % ((int)Math.Pow(2, lnI + 1)) >= (int)Math.Pow(2, lnI);

			return number;
		}

		private string convertIntToChar(int number)
		{
			if (number >= 0 && number <= 9)
				return number.ToString();
			if (number >= 10 && number <= 35)
				return Convert.ToChar(55 + number).ToString();
			if (number >= 36 && number <= 61)
				return Convert.ToChar(61 + number).ToString();
			if (number == 62) return "!";
			if (number == 63) return "@";
			return "";
		}

		private int convertChartoInt(char character)
		{
			if (character >= Convert.ToChar("0") && character <= Convert.ToChar("9"))
				return character - 48;
			if (character >= Convert.ToChar("A") && character <= Convert.ToChar("Z"))
				return character - 55;
			if (character >= Convert.ToChar("a") && character <= Convert.ToChar("z"))
				return character - 61;
			if (character == Convert.ToChar("!")) return 62;
			if (character == Convert.ToChar("@")) return 63;
			return 0;
		}

		private void FF1PRR_Load(object sender, EventArgs e)
		{
			RandoSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();

			try
			{
				using (TextReader reader = File.OpenText("lastFF1PRR.txt"))
				{
					FF1PRFolder.Text = reader.ReadLine();
					RandoSeed.Text = reader.ReadLine();
					RandoFlags.Text = reader.ReadLine();
					VisualFlags.Text = reader.ReadLine();
					determineChecks(null, null);

					//runChecksum();
					loading = false;
				}
			}
			catch
			{
				RandoFlags.Text = "BA";
				VisualFlags.Text = "0";
				// ignore error
				loading = false;
				determineChecks(null, null);
			}

		}

		private void NewSeed_Click(object sender, EventArgs e)
		{
			RandoSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();
		}

		private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			// Get the subdirectories for the specified directory.
			DirectoryInfo dir = new DirectoryInfo(sourceDirName);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException(
					"Source directory does not exist or could not be found: "
					+ sourceDirName);
			}

			DirectoryInfo[] dirs = dir.GetDirectories();

			// If the destination directory doesn't exist, create it.       
			Directory.CreateDirectory(destDirName);

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo file in files)
			{
				string tempPath = Path.Combine(destDirName, file.Name);
				file.CopyTo(tempPath, true);
			}

			// If copying subdirectories, copy them and their contents to new location.
			if (copySubDirs)
			{
				foreach (DirectoryInfo subdir in dirs)
				{
					string tempPath = Path.Combine(destDirName, subdir.Name);
					DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
				}
			}
		}

		private void restoreVanilla()
        {
			string[] DATA_MASTER = {
				"ability.csv", // used by Magic randomization
				"product.csv", // used by Shop randomization
				"weapon.csv",  // used by balance flags
				"monster.csv", // used by xp boost & monster flags
				"item.csv",    // used by price rebalance flag
				"armor.csv"    // used by price rebalance flag
			};
			string[] DATA_MESSAGE =
			{
				"system_en.txt" // used by Key Item randomization
            };

			string DATA_MASTER_PATH = Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master");
			string DATA_MESSAGE_PATH = Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Message");
			string RES_MAP_PATH = Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map");

			foreach (string i in DATA_MASTER){
				string outputPath = Path.Combine(DATA_MASTER_PATH, i);
				string sourcePath = Path.Combine("data", "assets", i);
				File.Copy(sourcePath, outputPath, true);
			}
			foreach (string i in DATA_MESSAGE){
				string outputPath = Path.Combine(DATA_MESSAGE_PATH, i);
				string sourcePath = Path.Combine("data", "assets", i);
				File.Copy(sourcePath, outputPath, true);
			}
			DirectoryCopy(Path.Combine("data", "maps"), RES_MAP_PATH, true);

		}

		private void btnRestoreVanilla_Click(object sender, EventArgs e)
		{
			restoreVanilla();
		}

		private void btnRandomize_Click(object sender, EventArgs e)
		{
			NewChecksum.Text = "Please wait...";
			this.Refresh();

			restoreVanilla();

			// Copy over modded files
			string DATA_PATH = Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data");
			string MAP_PATH = Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map");
			File.Copy(Path.Combine("data", "mods", "system_en.txt"), Path.Combine(DATA_PATH, "Message", "system_en.txt"), true);
			if (Traditional.Checked) File.Copy(Path.Combine("data", "mods", "productTraditional.csv"), Path.Combine(DATA_PATH, "Master", "product.csv"), true);
			else File.Copy(Path.Combine("data", "mods", "product.csv"), Path.Combine(DATA_PATH, "Master", "product.csv"), true);
			DirectoryCopy(Path.Combine("data", "mods", "Map"), MAP_PATH, true);

			// Begin randomization
			r1 = new Random(Convert.ToInt32(RandoSeed.Text));
			doDatabaseEdits();
			Magic magicData = randomizeMagic(randoMagic.Checked, keepMagicPermissions.Checked);
			if (RandoShop.SelectedIndex > 0) randomizeShops(magicData);
			if (KeyItems.Checked) randomizeKeyItems();
			if (flagT.SelectedIndex > 0) randomizeTreasure();
			monsterBoost();
			if (CuteHats.Checked)
			{
				// neongrey says: eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
				// Demerine says: eeeeeeeee
			}

			NewChecksum.Text = "COMPLETE";
		}
		private class DatabaseEdit
        {
			public string file { get; set; }
			public string name { get; set; } 
			public string id { get; set; } 
			public string field { get; set; }
			public string value { get; set; }
			public string comment { get; set; }
			public int CompareTo(DatabaseEdit edit)
			{
				// A null value means that this object is greater.
				if (edit == null)
					return 1;

				else
					return this.file.CompareTo(edit.file);
			}
		}
		private List<DatabaseEdit> addEdits(string filename)
        {
			List<DatabaseEdit> edits;
			using (StreamReader reader = new StreamReader(Path.Combine("data", filename)))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
			{
				edits = csv.GetRecords<DatabaseEdit>().ToList();
			}
			return edits;
		}
		private void doDatabaseEdits()
        {
			List<DatabaseEdit> editsToMake = new List<DatabaseEdit>();
			string dataPath = Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master");
			if (flagRebalancePrices.Checked)
            {
				// Advance the RNG
				r1.NextBytes(new byte[1]);
				editsToMake.AddRange(addEdits("dataRebalancePrices.csv"));
			}
			if (flagFiendsDropRibbons.Checked)
            {
				// Advance the RNG
				r1.NextBytes(new byte[2]);
				editsToMake.AddRange(addEdits("dataFiendsDropRibbons.csv"));
			}
			if (flagRebalanceBosses.Checked)
            {
				// Advance the RNG
				r1.NextBytes(new byte[4]);
				editsToMake.AddRange(addEdits("dataRebalanceBosses.csv"));
			}
			if (flagRestoreCritRating.Checked)
            {
				// Advance the RNG
				r1.NextBytes(new byte[8]);
				editsToMake.AddRange(addEdits("dataRestoreCritRating.csv"));
			}
			if (flagWandsAddInt.Checked)
            {
				// Advance the RNG
				r1.NextBytes(new byte[16]);
				editsToMake.AddRange(addEdits("dataWandsAddInt.csv"));
			}

			// Now apply the edits
            foreach (var editsByFile in editsToMake.GroupBy(x => x.file))
            {
				List<dynamic> fileToEdit;
				using (StreamReader reader = new StreamReader(Path.Combine(dataPath, editsByFile.Key)))
				using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				{
					fileToEdit = csv.GetRecords<dynamic>().ToList();
					foreach (var edit in editsByFile)
                    {
						var itemDict = fileToEdit.Find(x => x.id == edit.id) as IDictionary<string, object>;
						itemDict[edit.field] = edit.value;
                    }
				}
				using (StreamWriter writer = new StreamWriter(Path.Combine(dataPath, editsByFile.Key)))
				using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
				{
					csv.WriteRecords(fileToEdit);
				}
			}
		}
		private void randomizeShops(Magic magicData)
		{
			Shops randoShops = new Shops(r1, RandoShop.SelectedIndex, 
				Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "product.csv"), 
				Traditional.Checked, magicData);
		}

		private Magic randomizeMagic(bool randomizeMagic, bool keepPermissions)
		{
			Magic magicData = new Inventory.Magic(
				Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "ability.csv"));
			if (randomizeMagic) magicData.shuffleMagic(r1, keepPermissions);
			magicData.writeToFile();
			return magicData;
		}

		private void randomizeKeyItems()
		{
			KeyItems randoKeyItems = new KeyItems(r1,
				Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"));
		}
		private void randomizeTreasure()
        {
			Treasure randoChests = new Treasure(r1, flagT.SelectedIndex,
				Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"),
				flagTraditionalTreasure.Checked, flagFiendsDropRibbons.Checked);
		}

		private void monsterBoost()
		{
			double xp = monsterXPGPBoost.SelectedIndex == 0 ? 0.5 :
				monsterXPGPBoost.SelectedIndex == 1 ? 1.0 :
				monsterXPGPBoost.SelectedIndex == 2 ? 1.5 :
				monsterXPGPBoost.SelectedIndex == 3 ? 2.0 :
				monsterXPGPBoost.SelectedIndex == 4 ? 3.0 :
				monsterXPGPBoost.SelectedIndex == 5 ? 4.0 :
				monsterXPGPBoost.SelectedIndex == 6 ? 5.0 : 10;
			Monster monsters = new Monster(r1, Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "monster.csv"), xp, 0, xp, 0);
		}

		private void frmFF1PRR_FormClosing(object sender, FormClosingEventArgs e)
		{
			using (StreamWriter writer = File.CreateText("lastFF1PRR.txt"))
			{
				writer.WriteLine(FF1PRFolder.Text);
				writer.WriteLine(RandoSeed.Text);
				writer.WriteLine(RandoFlags.Text);
				writer.WriteLine(VisualFlags.Text);
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
					FF1PRFolder.Text = fbd.SelectedPath;
			}
		}
    }
}
