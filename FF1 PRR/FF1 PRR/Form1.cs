using FF1_PRR.Randomize;
using FF1_PRR.Inventory;
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
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { ShuffleBossSpots, KeyItems, Traditional }));
			// Combo boxes time...
			flags += convertIntToChar(RandoShop.SelectedIndex); // + (8 * cboShops.SelectedIndex) <----- Keep this for now; we'll use it later for sure.
			RandoFlags.Text = flags;

			flags = "";
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { CuteHats }));
			VisualFlags.Text = flags;
		}

		private void determineChecks(object sender, EventArgs e)
		{
			if (loading && RandoFlags.Text.Length < 2)
				RandoFlags.Text = "31";
			else if (RandoFlags.Text.Length < 2)
				return;

			if (loading && VisualFlags.Text.Length < 1)
				VisualFlags.Text = "0";
			else if (VisualFlags.Text.Length < 1)
				return;

			loading = true;

			string flags = RandoFlags.Text;
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(0, 1))), new CheckBox[] { ShuffleBossSpots, KeyItems, Traditional });
			RandoShop.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(1, 1))) % 8;

			flags = VisualFlags.Text;
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(0, 1))), new CheckBox[] { CuteHats });

			// TEMPORARY:  Keep commented; we will be using combo boxes eventually
			//cboStorePrices.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(8, 1))) / 8;

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
				RandoFlags.Text = "31";
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

		private void Randomize_Click(object sender, EventArgs e)
		{
			r1 = new Random(Convert.ToInt32(RandoSeed.Text));
			if (RandoShop.SelectedIndex > 0) randomizeShops();
			randomizeMagic();
			randomizeKeyItems();
			monsterBoost();
			if (CuteHats.Checked)
			{
				// neongrey says: eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
				// Demerine says: eeeeeeeee
			}

			NewChecksum.Text = "COMPLETE";
		}

		private void randomizeShops()
		{
			Shops randoShops = new Shops(r1, RandoShop.SelectedIndex, 
				Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "product.csv"), 
				Traditional.Checked);
		}

		private void randomizeMagic()
		{
			new Inventory.Magic().shuffleMagic(r1,
				Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "ability.csv"));
		}

		private void randomizeKeyItems()
		{
			KeyItems randoKeyItems = new KeyItems(r1,
				Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"));
		}

		private void monsterBoost()
		{
			Monster monsters = new Monster(r1, Path.Combine(FF1PRFolder.Text, "FINAL FANTASY_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "monster.csv"), 5, 500, 5, 500);
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
