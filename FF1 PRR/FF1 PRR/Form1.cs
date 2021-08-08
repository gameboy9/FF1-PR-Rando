using FF1_PRR.Randomize;
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
	public partial class frmFF1PRR : Form
	{
		bool loading = true;
		Random r1 = new Random();

		public frmFF1PRR()
		{
			InitializeComponent();
		}

		public void determineFlags(object sender, EventArgs e)
		{
			if (loading) return;

			string flags = "";
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { chkShuffleBossSpots, chkKeyItems }));
			// Combo boxes time...
			flags += convertIntToChar(cboShops.SelectedIndex); // + (8 * cboShops.SelectedIndex) <----- Keep this for now; we'll use it later for sure.
			txtRandoFlags.Text = flags;

			flags = "";
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { chkCuteHats }));
			txtVisualFlags.Text = flags;
		}

		private void determineChecks(object sender, EventArgs e)
		{
			if (loading && txtRandoFlags.Text.Length < 2)
				txtRandoFlags.Text = "31";
			else if (txtRandoFlags.Text.Length < 2)
				return;

			if (loading && txtVisualFlags.Text.Length < 1)
				txtVisualFlags.Text = "0";
			else if (txtVisualFlags.Text.Length < 1)
				return;

			loading = true;

			string flags = txtRandoFlags.Text;
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(0, 1))), new CheckBox[] { chkShuffleBossSpots, chkKeyItems });
			cboShops.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(1, 1))) % 8;

			flags = txtVisualFlags.Text;
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(0, 1))), new CheckBox[] { chkCuteHats });

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

		private void frmFF1PRR_Load(object sender, EventArgs e)
		{
			txtSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();

			try
			{
				using (TextReader reader = File.OpenText("lastFF1PRR.txt"))
				{
					txtFF1PRFolder.Text = reader.ReadLine();
					txtSeed.Text = reader.ReadLine();
					txtRandoFlags.Text = reader.ReadLine();
					txtVisualFlags.Text = reader.ReadLine();
					determineChecks(null, null);

					//runChecksum();
					loading = false;
				}
			}
			catch
			{
				txtRandoFlags.Text = "31";
				txtVisualFlags.Text = "0";
				// ignore error
				loading = false;
				determineChecks(null, null);
			}

		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();
		}

		private void cmdRandomize_Click(object sender, EventArgs e)
		{
			if (cboShops.SelectedIndex > 0) randomize_shops();
			if (chkCuteHats.Checked)
			{
				// neongrey says: eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
				// Demerine says: eeeeeeeee
			}
		}

		private void randomize_shops()
		{
			Shops randoShops = new Shops(r1);
		}

		private void frmFF1PRR_FormClosing(object sender, FormClosingEventArgs e)
		{
			using (StreamWriter writer = File.CreateText("lastFF1PRR.txt"))
			{
				writer.WriteLine(txtFF1PRFolder.Text);
				writer.WriteLine(txtSeed.Text);
				writer.WriteLine(txtRandoFlags.Text);
				writer.WriteLine(txtVisualFlags.Text);
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
					txtFF1PRFolder.Text = fbd.SelectedPath;
			}
		}
	}
}
