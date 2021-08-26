
namespace FF1_PRR
{
	partial class FF1PRR
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Randomize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.FF1PRFolder = new System.Windows.Forms.TextBox();
			this.CuteHats = new System.Windows.Forms.CheckBox();
			this.ShuffleBossSpots = new System.Windows.Forms.CheckBox();
			this.KeyItems = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RandoFlags = new System.Windows.Forms.TextBox();
			this.NewChecksum = new System.Windows.Forms.Label();
			this.RandoSeed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NewSeed = new System.Windows.Forms.Button();
			this.VisualFlags = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BrowseForFolder = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.RandoShop = new System.Windows.Forms.ComboBox();
			this.Traditional = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.randoMagic = new System.Windows.Forms.CheckBox();
			this.keepMagicPermissions = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.monsterXPGPBoost = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Randomize
			// 
			this.Randomize.Location = new System.Drawing.Point(668, 409);
			this.Randomize.Name = "Randomize";
			this.Randomize.Size = new System.Drawing.Size(120, 29);
			this.Randomize.TabIndex = 0;
			this.Randomize.Text = "Randomize!";
			this.Randomize.UseVisualStyleBackColor = true;
			this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "FF1 PR Folder";
			// 
			// FF1PRFolder
			// 
			this.FF1PRFolder.Location = new System.Drawing.Point(116, 6);
			this.FF1PRFolder.Name = "FF1PRFolder";
			this.FF1PRFolder.Size = new System.Drawing.Size(502, 27);
			this.FF1PRFolder.TabIndex = 2;
			// 
			// CuteHats
			// 
			this.CuteHats.AutoSize = true;
			this.CuteHats.Location = new System.Drawing.Point(485, 128);
			this.CuteHats.Name = "CuteHats";
			this.CuteHats.Size = new System.Drawing.Size(95, 24);
			this.CuteHats.TabIndex = 3;
			this.CuteHats.Text = "Cute Hats";
			this.CuteHats.UseVisualStyleBackColor = true;
			this.CuteHats.Click += new System.EventHandler(this.DetermineFlags);
			// 
			// ShuffleBossSpots
			// 
			this.ShuffleBossSpots.AutoSize = true;
			this.ShuffleBossSpots.Location = new System.Drawing.Point(12, 128);
			this.ShuffleBossSpots.Name = "ShuffleBossSpots";
			this.ShuffleBossSpots.Size = new System.Drawing.Size(152, 24);
			this.ShuffleBossSpots.TabIndex = 4;
			this.ShuffleBossSpots.Text = "Shuffle Boss Spots";
			this.ShuffleBossSpots.UseVisualStyleBackColor = true;
			this.ShuffleBossSpots.Click += new System.EventHandler(this.DetermineFlags);
			// 
			// KeyItems
			// 
			this.KeyItems.AutoSize = true;
			this.KeyItems.Location = new System.Drawing.Point(12, 199);
			this.KeyItems.Name = "KeyItems";
			this.KeyItems.Size = new System.Drawing.Size(174, 24);
			this.KeyItems.TabIndex = 5;
			this.KeyItems.Text = "Randomize Key Items";
			this.KeyItems.UseVisualStyleBackColor = true;
			this.KeyItems.Click += new System.EventHandler(this.DetermineFlags);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Rando Flags";
			// 
			// RandoFlags
			// 
			this.RandoFlags.Location = new System.Drawing.Point(116, 47);
			this.RandoFlags.Name = "RandoFlags";
			this.RandoFlags.Size = new System.Drawing.Size(346, 27);
			this.RandoFlags.TabIndex = 7;
			// 
			// NewChecksum
			// 
			this.NewChecksum.AutoSize = true;
			this.NewChecksum.Location = new System.Drawing.Point(12, 413);
			this.NewChecksum.Name = "NewChecksum";
			this.NewChecksum.Size = new System.Drawing.Size(267, 20);
			this.NewChecksum.TabIndex = 8;
			this.NewChecksum.Text = "New Checksum:  (Not Randomized Yet)";
			// 
			// RandoSeed
			// 
			this.RandoSeed.Location = new System.Drawing.Point(554, 44);
			this.RandoSeed.Name = "RandoSeed";
			this.RandoSeed.Size = new System.Drawing.Size(160, 27);
			this.RandoSeed.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(485, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Seed";
			// 
			// NewSeed
			// 
			this.NewSeed.Location = new System.Drawing.Point(729, 43);
			this.NewSeed.Name = "NewSeed";
			this.NewSeed.Size = new System.Drawing.Size(59, 29);
			this.NewSeed.TabIndex = 11;
			this.NewSeed.Text = "New";
			this.NewSeed.UseVisualStyleBackColor = true;
			this.NewSeed.Click += new System.EventHandler(this.NewSeed_Click);
			// 
			// VisualFlags
			// 
			this.VisualFlags.Location = new System.Drawing.Point(116, 84);
			this.VisualFlags.Name = "VisualFlags";
			this.VisualFlags.Size = new System.Drawing.Size(346, 27);
			this.VisualFlags.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Visual Flags";
			// 
			// BrowseForFolder
			// 
			this.BrowseForFolder.Location = new System.Drawing.Point(693, 6);
			this.BrowseForFolder.Name = "BrowseForFolder";
			this.BrowseForFolder.Size = new System.Drawing.Size(95, 28);
			this.BrowseForFolder.TabIndex = 14;
			this.BrowseForFolder.Text = "Browse";
			this.BrowseForFolder.UseVisualStyleBackColor = true;
			this.BrowseForFolder.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(291, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Weapon/Armor/Item Shop Randomization";
			// 
			// RandoShop
			// 
			this.RandoShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RandoShop.FormattingEnabled = true;
			this.RandoShop.Items.AddRange(new object[] {
            "None",
            "Shuffle",
            "Standard",
            "Pro",
            "Wild"});
			this.RandoShop.Location = new System.Drawing.Point(309, 233);
			this.RandoShop.Name = "RandoShop";
			this.RandoShop.Size = new System.Drawing.Size(151, 28);
			this.RandoShop.TabIndex = 16;
			this.RandoShop.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// Traditional
			// 
			this.Traditional.AutoSize = true;
			this.Traditional.Location = new System.Drawing.Point(480, 235);
			this.Traditional.Name = "Traditional";
			this.Traditional.Size = new System.Drawing.Size(102, 24);
			this.Traditional.TabIndex = 17;
			this.Traditional.Text = "NES Shops";
			this.Traditional.UseVisualStyleBackColor = true;
			this.Traditional.Click += new System.EventHandler(this.DetermineFlags);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 262);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 20);
			this.label6.TabIndex = 18;
			// 
			// randoMagic
			// 
			this.randoMagic.AutoSize = true;
			this.randoMagic.Location = new System.Drawing.Point(12, 269);
			this.randoMagic.Name = "randoMagic";
			this.randoMagic.Size = new System.Drawing.Size(151, 24);
			this.randoMagic.TabIndex = 19;
			this.randoMagic.Text = "Randomize Magic";
			this.randoMagic.UseVisualStyleBackColor = true;
			this.randoMagic.Click += new System.EventHandler(this.DetermineFlags);
			// 
			// keepMagicPermissions
			// 
			this.keepMagicPermissions.AutoSize = true;
			this.keepMagicPermissions.Location = new System.Drawing.Point(187, 269);
			this.keepMagicPermissions.Name = "keepMagicPermissions";
			this.keepMagicPermissions.Size = new System.Drawing.Size(145, 24);
			this.keepMagicPermissions.TabIndex = 20;
			this.keepMagicPermissions.Text = "Keep Permissions";
			this.keepMagicPermissions.UseVisualStyleBackColor = true;
			this.keepMagicPermissions.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 165);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 20);
			this.label7.TabIndex = 21;
			this.label7.Text = "Monster XP/GP Boosting";
			// 
			// monsterXPGPBoost
			// 
			this.monsterXPGPBoost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.monsterXPGPBoost.FormattingEnabled = true;
			this.monsterXPGPBoost.Items.AddRange(new object[] {
            "0.5x",
            "1.0x",
            "1.5x",
            "2.0x",
            "3.0x",
            "4.0x",
            "5.0x",
            "10.0x"});
			this.monsterXPGPBoost.Location = new System.Drawing.Point(205, 162);
			this.monsterXPGPBoost.Name = "monsterXPGPBoost";
			this.monsterXPGPBoost.Size = new System.Drawing.Size(151, 28);
			this.monsterXPGPBoost.TabIndex = 22;
			this.monsterXPGPBoost.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// FF1PRR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.monsterXPGPBoost);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.keepMagicPermissions);
			this.Controls.Add(this.randoMagic);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Traditional);
			this.Controls.Add(this.RandoShop);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BrowseForFolder);
			this.Controls.Add(this.VisualFlags);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NewSeed);
			this.Controls.Add(this.RandoSeed);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.NewChecksum);
			this.Controls.Add(this.RandoFlags);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.KeyItems);
			this.Controls.Add(this.ShuffleBossSpots);
			this.Controls.Add(this.CuteHats);
			this.Controls.Add(this.FF1PRFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Randomize);
			this.Name = "FF1PRR";
			this.Text = "Final Fantasy 1 Pixel Remaster Randomizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFF1PRR_FormClosing);
			this.Load += new System.EventHandler(this.FF1PRR_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Randomize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FF1PRFolder;
		private System.Windows.Forms.CheckBox CuteHats;
		private System.Windows.Forms.CheckBox ShuffleBossSpots;
		private System.Windows.Forms.CheckBox KeyItems;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox RandoFlags;
		private System.Windows.Forms.Label NewChecksum;
		private System.Windows.Forms.TextBox RandoSeed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button NewSeed;
		private System.Windows.Forms.TextBox VisualFlags;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BrowseForFolder;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox RandoShop;
		private System.Windows.Forms.CheckBox Traditional;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox randoMagic;
		private System.Windows.Forms.CheckBox keepMagicPermissions;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox monsterXPGPBoost;
	}
}

