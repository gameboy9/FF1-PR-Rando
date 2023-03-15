
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
			this.components = new System.ComponentModel.Container();
			this.btnRandomize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.FF1PRFolder = new System.Windows.Forms.TextBox();
			this.CuteHats = new System.Windows.Forms.CheckBox();
			this.flagBossShuffle = new System.Windows.Forms.CheckBox();
			this.flagKeyItems = new System.Windows.Forms.CheckBox();
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
			this.modeShops = new System.Windows.Forms.ComboBox();
			this.flagShopsTrad = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.flagMagicShuffleShops = new System.Windows.Forms.CheckBox();
			this.flagMagicKeepPermissions = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.modeXPBoost = new System.Windows.Forms.ComboBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label8 = new System.Windows.Forms.Label();
			this.modeTreasure = new System.Windows.Forms.ComboBox();
			this.flagTreasureTrad = new System.Windows.Forms.CheckBox();
			this.flagRebalancePrices = new System.Windows.Forms.CheckBox();
			this.flagRestoreCritRating = new System.Windows.Forms.CheckBox();
			this.flagWandsAddInt = new System.Windows.Forms.CheckBox();
			this.flagFiendsDropRibbons = new System.Windows.Forms.CheckBox();
			this.flagRebalanceBosses = new System.Windows.Forms.CheckBox();
			this.btnRestoreVanilla = new System.Windows.Forms.Button();
			this.flagReduceEncounterRate = new System.Windows.Forms.CheckBox();
			this.flagReduceChaosHP = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.modeMagic = new System.Windows.Forms.ComboBox();
			this.flagNoEscapeNES = new System.Windows.Forms.CheckBox();
			this.flagNoEscapeRandomize = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.modeMonsterStatAdjustment = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.modeHeroStats = new System.Windows.Forms.ComboBox();
			this.flagHeroStatsStandardize = new System.Windows.Forms.CheckBox();
			this.statExplanation = new System.Windows.Forms.Button();
			this.flagBoostPromoted = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnInstall = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRandomize
			// 
			this.btnRandomize.Location = new System.Drawing.Point(649, 654);
			this.btnRandomize.Margin = new System.Windows.Forms.Padding(2);
			this.btnRandomize.Name = "btnRandomize";
			this.btnRandomize.Padding = new System.Windows.Forms.Padding(3);
			this.btnRandomize.Size = new System.Drawing.Size(120, 33);
			this.btnRandomize.TabIndex = 0;
			this.btnRandomize.Text = "Randomize!";
			this.btnRandomize.UseVisualStyleBackColor = true;
			this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(2);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(104, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "FF1 PR Folder";
			// 
			// FF1PRFolder
			// 
			this.FF1PRFolder.Location = new System.Drawing.Point(128, 14);
			this.FF1PRFolder.Margin = new System.Windows.Forms.Padding(2);
			this.FF1PRFolder.Name = "FF1PRFolder";
			this.FF1PRFolder.Size = new System.Drawing.Size(547, 27);
			this.FF1PRFolder.TabIndex = 2;
			this.FF1PRFolder.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\FINAL FANTASY PR";
			// 
			// CuteHats
			// 
			this.CuteHats.AutoSize = true;
			this.CuteHats.Location = new System.Drawing.Point(485, 128);
			this.CuteHats.Margin = new System.Windows.Forms.Padding(2);
			this.CuteHats.Name = "CuteHats";
			this.CuteHats.Padding = new System.Windows.Forms.Padding(3);
			this.CuteHats.Size = new System.Drawing.Size(101, 30);
			this.CuteHats.TabIndex = 3;
			this.CuteHats.Text = "Cute Hats";
			this.toolTip1.SetToolTip(this.CuteHats, "Your hat is cute.");
			this.CuteHats.UseVisualStyleBackColor = true;
			this.CuteHats.Visible = false;
			this.CuteHats.Click += new System.EventHandler(this.DetermineFlags);
			// 
			// flagBossShuffle
			// 
			this.flagBossShuffle.AutoSize = true;
			this.flagBossShuffle.Enabled = false;
			this.flagBossShuffle.Location = new System.Drawing.Point(172, 22);
			this.flagBossShuffle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.flagBossShuffle.Name = "flagBossShuffle";
			this.flagBossShuffle.Padding = new System.Windows.Forms.Padding(3);
			this.flagBossShuffle.Size = new System.Drawing.Size(158, 30);
			this.flagBossShuffle.TabIndex = 4;
			this.flagBossShuffle.Text = "Shuffle Boss Spots";
			this.toolTip1.SetToolTip(this.flagBossShuffle, "Change which boss appears at which boss location.");
			this.flagBossShuffle.UseVisualStyleBackColor = true;
			this.flagBossShuffle.Visible = false;
			this.flagBossShuffle.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagKeyItems
			// 
			this.flagKeyItems.AutoSize = true;
			this.flagKeyItems.Checked = true;
			this.flagKeyItems.CheckState = System.Windows.Forms.CheckState.Checked;
			this.flagKeyItems.Location = new System.Drawing.Point(12, 128);
			this.flagKeyItems.Margin = new System.Windows.Forms.Padding(2);
			this.flagKeyItems.Name = "flagKeyItems";
			this.flagKeyItems.Padding = new System.Windows.Forms.Padding(3);
			this.flagKeyItems.Size = new System.Drawing.Size(180, 30);
			this.flagKeyItems.TabIndex = 5;
			this.flagKeyItems.Text = "Randomize &Key Items";
			this.toolTip1.SetToolTip(this.flagKeyItems, "Change which key item appears at each location. All key items are guaranteed to b" +
        "e accessible.");
			this.flagKeyItems.UseVisualStyleBackColor = true;
			this.flagKeyItems.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Margin = new System.Windows.Forms.Padding(2);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(3);
			this.label2.Size = new System.Drawing.Size(120, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Gameplay Flags";
			// 
			// RandoFlags
			// 
			this.RandoFlags.Location = new System.Drawing.Point(128, 52);
			this.RandoFlags.Margin = new System.Windows.Forms.Padding(2);
			this.RandoFlags.Name = "RandoFlags";
			this.RandoFlags.Size = new System.Drawing.Size(346, 27);
			this.RandoFlags.TabIndex = 7;
			// 
			// NewChecksum
			// 
			this.NewChecksum.AutoSize = true;
			this.NewChecksum.Location = new System.Drawing.Point(12, 658);
			this.NewChecksum.Margin = new System.Windows.Forms.Padding(2);
			this.NewChecksum.Name = "NewChecksum";
			this.NewChecksum.Padding = new System.Windows.Forms.Padding(3);
			this.NewChecksum.Size = new System.Drawing.Size(273, 26);
			this.NewChecksum.TabIndex = 8;
			this.NewChecksum.Text = "New Checksum:  (Not Randomized Yet)";
			// 
			// RandoSeed
			// 
			this.RandoSeed.Location = new System.Drawing.Point(542, 52);
			this.RandoSeed.Margin = new System.Windows.Forms.Padding(2);
			this.RandoSeed.Name = "RandoSeed";
			this.RandoSeed.Size = new System.Drawing.Size(154, 27);
			this.RandoSeed.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(485, 51);
			this.label3.Margin = new System.Windows.Forms.Padding(2);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(3);
			this.label3.Size = new System.Drawing.Size(48, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "Seed";
			// 
			// NewSeed
			// 
			this.NewSeed.Location = new System.Drawing.Point(710, 50);
			this.NewSeed.Margin = new System.Windows.Forms.Padding(2);
			this.NewSeed.Name = "NewSeed";
			this.NewSeed.Padding = new System.Windows.Forms.Padding(3);
			this.NewSeed.Size = new System.Drawing.Size(59, 33);
			this.NewSeed.TabIndex = 11;
			this.NewSeed.Text = "New";
			this.NewSeed.UseVisualStyleBackColor = true;
			this.NewSeed.Click += new System.EventHandler(this.NewSeed_Click);
			// 
			// VisualFlags
			// 
			this.VisualFlags.Location = new System.Drawing.Point(128, 91);
			this.VisualFlags.Margin = new System.Windows.Forms.Padding(2);
			this.VisualFlags.Name = "VisualFlags";
			this.VisualFlags.Size = new System.Drawing.Size(346, 27);
			this.VisualFlags.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 89);
			this.label4.Margin = new System.Windows.Forms.Padding(2);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(3);
			this.label4.Size = new System.Drawing.Size(114, 26);
			this.label4.TabIndex = 12;
			this.label4.Text = "Cosmetic Flags";
			// 
			// BrowseForFolder
			// 
			this.BrowseForFolder.Location = new System.Drawing.Point(686, 12);
			this.BrowseForFolder.Margin = new System.Windows.Forms.Padding(2);
			this.BrowseForFolder.Name = "BrowseForFolder";
			this.BrowseForFolder.Padding = new System.Windows.Forms.Padding(3);
			this.BrowseForFolder.Size = new System.Drawing.Size(82, 32);
			this.BrowseForFolder.TabIndex = 14;
			this.BrowseForFolder.Text = "Browse";
			this.BrowseForFolder.UseVisualStyleBackColor = true;
			this.BrowseForFolder.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 28);
			this.label5.Margin = new System.Windows.Forms.Padding(6);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(3);
			this.label5.Size = new System.Drawing.Size(58, 26);
			this.label5.TabIndex = 15;
			this.label5.Text = "&Shops:";
			this.toolTip1.SetToolTip(this.label5, "Randomize shop contents. None: . Shuffle: . Standard: . Pro: . Wild: .");
			// 
			// modeShops
			// 
			this.modeShops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeShops.FormattingEnabled = true;
			this.modeShops.Items.AddRange(new object[] {
            "None",
            "Shuffle"});
			this.modeShops.Location = new System.Drawing.Point(121, 26);
			this.modeShops.Margin = new System.Windows.Forms.Padding(6);
			this.modeShops.Name = "modeShops";
			this.modeShops.Size = new System.Drawing.Size(151, 28);
			this.modeShops.TabIndex = 16;
			this.toolTip1.SetToolTip(this.modeShops, "Randomize shop contents. None: . Shuffle: . Standard: . Pro: . Wild: .");
			this.modeShops.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagShopsTrad
			// 
			this.flagShopsTrad.AutoSize = true;
			this.flagShopsTrad.Location = new System.Drawing.Point(282, 24);
			this.flagShopsTrad.Margin = new System.Windows.Forms.Padding(6);
			this.flagShopsTrad.Name = "flagShopsTrad";
			this.flagShopsTrad.Padding = new System.Windows.Forms.Padding(3);
			this.flagShopsTrad.Size = new System.Drawing.Size(160, 30);
			this.flagShopsTrad.TabIndex = 17;
			this.flagShopsTrad.Text = "E&xclude DoS items";
			this.toolTip1.SetToolTip(this.flagShopsTrad, "Remove newer items (Ether, Phoenix Down, etc) from shops.");
			this.flagShopsTrad.UseVisualStyleBackColor = true;
			this.flagShopsTrad.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 262);
			this.label6.Margin = new System.Windows.Forms.Padding(2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 20);
			this.label6.TabIndex = 18;
			// 
			// flagMagicShuffleShops
			// 
			this.flagMagicShuffleShops.AutoSize = true;
			this.flagMagicShuffleShops.Location = new System.Drawing.Point(11, 60);
			this.flagMagicShuffleShops.Margin = new System.Windows.Forms.Padding(6);
			this.flagMagicShuffleShops.Name = "flagMagicShuffleShops";
			this.flagMagicShuffleShops.Padding = new System.Windows.Forms.Padding(3);
			this.flagMagicShuffleShops.Size = new System.Drawing.Size(127, 30);
			this.flagMagicShuffleShops.TabIndex = 19;
			this.flagMagicShuffleShops.Text = "Shuffle Shops";
			this.toolTip1.SetToolTip(this.flagMagicShuffleShops, "Change which spell level is available at each shop.");
			this.flagMagicShuffleShops.UseVisualStyleBackColor = true;
			this.flagMagicShuffleShops.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagMagicKeepPermissions
			// 
			this.flagMagicKeepPermissions.AutoSize = true;
			this.flagMagicKeepPermissions.Location = new System.Drawing.Point(150, 59);
			this.flagMagicKeepPermissions.Margin = new System.Windows.Forms.Padding(6);
			this.flagMagicKeepPermissions.Name = "flagMagicKeepPermissions";
			this.flagMagicKeepPermissions.Padding = new System.Windows.Forms.Padding(3);
			this.flagMagicKeepPermissions.Size = new System.Drawing.Size(151, 30);
			this.flagMagicKeepPermissions.TabIndex = 20;
			this.flagMagicKeepPermissions.Text = "&Keep Permissions";
			this.toolTip1.SetToolTip(this.flagMagicKeepPermissions, "Preserve who may learn each spell, rather than adjusting to the spell\'s new slot." +
        " (eg, level 1 Flare can still only be learned by Black Wizard)");
			this.flagMagicKeepPermissions.UseVisualStyleBackColor = true;
			this.flagMagicKeepPermissions.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 28);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(3);
			this.label7.Size = new System.Drawing.Size(98, 26);
			this.label7.TabIndex = 21;
			this.label7.Text = "&XP/Gil Boost";
			this.toolTip1.SetToolTip(this.label7, "How much to increase earned XP and Gil.");
			// 
			// modeXPBoost
			// 
			this.modeXPBoost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeXPBoost.FormattingEnabled = true;
			this.modeXPBoost.Items.AddRange(new object[] {
            "0.5x",
            "1.0x",
            "1.5x",
            "2.0x",
            "3.0x",
            "4.0x",
            "5.0x",
            "10.0x"});
			this.modeXPBoost.Location = new System.Drawing.Point(106, 26);
			this.modeXPBoost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.modeXPBoost.Name = "modeXPBoost";
			this.modeXPBoost.Size = new System.Drawing.Size(69, 28);
			this.modeXPBoost.TabIndex = 22;
			this.toolTip1.SetToolTip(this.modeXPBoost, "How much to increase earned XP and Gil.");
			this.modeXPBoost.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 67);
			this.label8.Margin = new System.Windows.Forms.Padding(6);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(3);
			this.label8.Size = new System.Drawing.Size(73, 26);
			this.label8.TabIndex = 18;
			this.label8.Text = "&Treasure:";
			this.toolTip1.SetToolTip(this.label8, "Randomize treasure chest contents. None: . Shuffle: . Standard: . Pro: . Wild: .");
			// 
			// modeTreasure
			// 
			this.modeTreasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeTreasure.FormattingEnabled = true;
			this.modeTreasure.Items.AddRange(new object[] {
            "None",
            "Shuffle"});
			this.modeTreasure.Location = new System.Drawing.Point(121, 65);
			this.modeTreasure.Margin = new System.Windows.Forms.Padding(6);
			this.modeTreasure.Name = "modeTreasure";
			this.modeTreasure.Size = new System.Drawing.Size(151, 28);
			this.modeTreasure.TabIndex = 19;
			this.toolTip1.SetToolTip(this.modeTreasure, "Randomize treasure chest contents. None: . Shuffle: . Standard: . Pro: . Wild: .");
			this.modeTreasure.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagTreasureTrad
			// 
			this.flagTreasureTrad.AutoSize = true;
			this.flagTreasureTrad.Enabled = false;
			this.flagTreasureTrad.Location = new System.Drawing.Point(282, 63);
			this.flagTreasureTrad.Margin = new System.Windows.Forms.Padding(6);
			this.flagTreasureTrad.Name = "flagTreasureTrad";
			this.flagTreasureTrad.Padding = new System.Windows.Forms.Padding(3);
			this.flagTreasureTrad.Size = new System.Drawing.Size(160, 30);
			this.flagTreasureTrad.TabIndex = 20;
			this.flagTreasureTrad.Text = "E&xclude DoS items";
			this.toolTip1.SetToolTip(this.flagTreasureTrad, "Remove newer items (Ether, Phoenix Down, etc) from shops.");
			this.flagTreasureTrad.UseVisualStyleBackColor = true;
			this.flagTreasureTrad.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagRebalancePrices
			// 
			this.flagRebalancePrices.AutoSize = true;
			this.flagRebalancePrices.Location = new System.Drawing.Point(5, 54);
			this.flagRebalancePrices.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.flagRebalancePrices.Name = "flagRebalancePrices";
			this.flagRebalancePrices.Padding = new System.Windows.Forms.Padding(3);
			this.flagRebalancePrices.Size = new System.Drawing.Size(183, 30);
			this.flagRebalancePrices.TabIndex = 21;
			this.flagRebalancePrices.Text = "Rebalance item prices";
			this.toolTip1.SetToolTip(this.flagRebalancePrices, "Adjust item prices for a more balanced experience. Increases price of HP/MP resto" +
        "rative items and Phoenix Down.");
			this.flagRebalancePrices.UseVisualStyleBackColor = true;
			this.flagRebalancePrices.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagRestoreCritRating
			// 
			this.flagRestoreCritRating.AutoSize = true;
			this.flagRestoreCritRating.Location = new System.Drawing.Point(3, 51);
			this.flagRestoreCritRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.flagRestoreCritRating.Name = "flagRestoreCritRating";
			this.flagRestoreCritRating.Padding = new System.Windows.Forms.Padding(3);
			this.flagRestoreCritRating.Size = new System.Drawing.Size(155, 30);
			this.flagRestoreCritRating.TabIndex = 22;
			this.flagRestoreCritRating.Text = "Restore crit rating";
			this.toolTip1.SetToolTip(this.flagRestoreCritRating, "Weapon critical rate changed to reflect original NES data.");
			this.flagRestoreCritRating.UseVisualStyleBackColor = true;
			this.flagRestoreCritRating.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagWandsAddInt
			// 
			this.flagWandsAddInt.AutoSize = true;
			this.flagWandsAddInt.Location = new System.Drawing.Point(6, 84);
			this.flagWandsAddInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.flagWandsAddInt.Name = "flagWandsAddInt";
			this.flagWandsAddInt.Padding = new System.Windows.Forms.Padding(3);
			this.flagWandsAddInt.Size = new System.Drawing.Size(138, 30);
			this.flagWandsAddInt.TabIndex = 23;
			this.flagWandsAddInt.Text = "Wands add INT";
			this.toolTip1.SetToolTip(this.flagWandsAddInt, "Staves and Hammers increase the user\'s Intelligence when equipped.");
			this.flagWandsAddInt.UseVisualStyleBackColor = true;
			this.flagWandsAddInt.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagFiendsDropRibbons
			// 
			this.flagFiendsDropRibbons.AutoSize = true;
			this.flagFiendsDropRibbons.Location = new System.Drawing.Point(5, 80);
			this.flagFiendsDropRibbons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.flagFiendsDropRibbons.Name = "flagFiendsDropRibbons";
			this.flagFiendsDropRibbons.Padding = new System.Windows.Forms.Padding(3);
			this.flagFiendsDropRibbons.Size = new System.Drawing.Size(173, 30);
			this.flagFiendsDropRibbons.TabIndex = 5;
			this.flagFiendsDropRibbons.Text = "Fiends drop Ribbons";
			this.toolTip1.SetToolTip(this.flagFiendsDropRibbons, "Receive Ribbons for defeating each elemental dungeon boss, and remove them from s" +
        "hops and chests.");
			this.flagFiendsDropRibbons.UseVisualStyleBackColor = true;
			this.flagFiendsDropRibbons.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagRebalanceBosses
			// 
			this.flagRebalanceBosses.AutoSize = true;
			this.flagRebalanceBosses.Location = new System.Drawing.Point(7, 52);
			this.flagRebalanceBosses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.flagRebalanceBosses.Name = "flagRebalanceBosses";
			this.flagRebalanceBosses.Padding = new System.Windows.Forms.Padding(3);
			this.flagRebalanceBosses.Size = new System.Drawing.Size(131, 30);
			this.flagRebalanceBosses.TabIndex = 6;
			this.flagRebalanceBosses.Text = "Harder bosses";
			this.toolTip1.SetToolTip(this.flagRebalanceBosses, "Increase HP of several bosses, notably Death Eye and the Fiend refights.");
			this.flagRebalanceBosses.UseVisualStyleBackColor = true;
			this.flagRebalanceBosses.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// btnRestoreVanilla
			// 
			this.btnRestoreVanilla.Location = new System.Drawing.Point(649, 621);
			this.btnRestoreVanilla.Margin = new System.Windows.Forms.Padding(2);
			this.btnRestoreVanilla.Name = "btnRestoreVanilla";
			this.btnRestoreVanilla.Padding = new System.Windows.Forms.Padding(3);
			this.btnRestoreVanilla.Size = new System.Drawing.Size(120, 33);
			this.btnRestoreVanilla.TabIndex = 27;
			this.btnRestoreVanilla.Text = "Restore vanilla";
			this.toolTip1.SetToolTip(this.btnRestoreVanilla, "Undo previous randomization and restore files to a vanilla configuration.");
			this.btnRestoreVanilla.UseVisualStyleBackColor = true;
			this.btnRestoreVanilla.Click += new System.EventHandler(this.btnRestoreVanilla_Click);
			// 
			// flagReduceEncounterRate
			// 
			this.flagReduceEncounterRate.AutoSize = true;
			this.flagReduceEncounterRate.Location = new System.Drawing.Point(6, 112);
			this.flagReduceEncounterRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.flagReduceEncounterRate.Name = "flagReduceEncounterRate";
			this.flagReduceEncounterRate.Padding = new System.Windows.Forms.Padding(3);
			this.flagReduceEncounterRate.Size = new System.Drawing.Size(186, 30);
			this.flagReduceEncounterRate.TabIndex = 24;
			this.flagReduceEncounterRate.Text = "Reduce encounter rate";
			this.toolTip1.SetToolTip(this.flagReduceEncounterRate, "Reduces rate of random encounters significantly on the ocean and slightly everywh" +
        "ere else.");
			this.flagReduceEncounterRate.UseVisualStyleBackColor = true;
			this.flagReduceEncounterRate.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagReduceChaosHP
			// 
			this.flagReduceChaosHP.AutoSize = true;
			this.flagReduceChaosHP.Location = new System.Drawing.Point(6, 22);
			this.flagReduceChaosHP.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.flagReduceChaosHP.Name = "flagReduceChaosHP";
			this.flagReduceChaosHP.Padding = new System.Windows.Forms.Padding(3);
			this.flagReduceChaosHP.Size = new System.Drawing.Size(153, 30);
			this.flagReduceChaosHP.TabIndex = 7;
			this.flagReduceChaosHP.Text = "Reduce Chaos HP";
			this.toolTip1.SetToolTip(this.flagReduceChaosHP, "Decrease HP of Chaos to 9600.");
			this.flagReduceChaosHP.UseVisualStyleBackColor = true;
			this.flagReduceChaosHP.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 30);
			this.label9.Margin = new System.Windows.Forms.Padding(6);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(3);
			this.label9.Size = new System.Drawing.Size(59, 26);
			this.label9.TabIndex = 21;
			this.label9.Text = "&Magic:";
			this.toolTip1.SetToolTip(this.label9, "Randomize magic spells. None: . Standard: . Pro: . Wild: . Chaos: .");
			// 
			// modeMagic
			// 
			this.modeMagic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeMagic.FormattingEnabled = true;
			this.modeMagic.Items.AddRange(new object[] {
            "None",
            "Standard",
            "Pro",
            "Wild",
            "Chaos"});
			this.modeMagic.Location = new System.Drawing.Point(121, 28);
			this.modeMagic.Margin = new System.Windows.Forms.Padding(6);
			this.modeMagic.Name = "modeMagic";
			this.modeMagic.Size = new System.Drawing.Size(151, 28);
			this.modeMagic.TabIndex = 22;
			this.toolTip1.SetToolTip(this.modeMagic, "Randomize magic spells. None: . Standard: . Pro: . Wild: . Chaos: .");
			this.modeMagic.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagNoEscapeNES
			// 
			this.flagNoEscapeNES.AutoSize = true;
			this.flagNoEscapeNES.Location = new System.Drawing.Point(172, 51);
			this.flagNoEscapeNES.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.flagNoEscapeNES.Name = "flagNoEscapeNES";
			this.flagNoEscapeNES.Padding = new System.Windows.Forms.Padding(3);
			this.flagNoEscapeNES.Size = new System.Drawing.Size(291, 30);
			this.flagNoEscapeNES.TabIndex = 8;
			this.flagNoEscapeNES.Text = "Add NES \"No Escape\" Rnd. Encounters";
			this.toolTip1.SetToolTip(this.flagNoEscapeNES, "Change which boss appears at which boss location.");
			this.flagNoEscapeNES.UseVisualStyleBackColor = true;
			this.flagNoEscapeNES.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagNoEscapeRandomize
			// 
			this.flagNoEscapeRandomize.AutoSize = true;
			this.flagNoEscapeRandomize.Location = new System.Drawing.Point(172, 80);
			this.flagNoEscapeRandomize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.flagNoEscapeRandomize.Name = "flagNoEscapeRandomize";
			this.flagNoEscapeRandomize.Padding = new System.Windows.Forms.Padding(3);
			this.flagNoEscapeRandomize.Size = new System.Drawing.Size(274, 30);
			this.flagNoEscapeRandomize.TabIndex = 9;
			this.flagNoEscapeRandomize.Text = "Randomize \"No Escape\" Encounters";
			this.toolTip1.SetToolTip(this.flagNoEscapeRandomize, "Change which boss appears at which boss location.");
			this.flagNoEscapeRandomize.UseVisualStyleBackColor = true;
			this.flagNoEscapeRandomize.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(5, 114);
			this.label10.Name = "label10";
			this.label10.Padding = new System.Windows.Forms.Padding(3);
			this.label10.Size = new System.Drawing.Size(121, 26);
			this.label10.TabIndex = 22;
			this.label10.Text = "Stat Adjustment";
			this.toolTip1.SetToolTip(this.label10, "How much to increase earned XP and Gil.");
			// 
			// modeMonsterStatAdjustment
			// 
			this.modeMonsterStatAdjustment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeMonsterStatAdjustment.FormattingEnabled = true;
			this.modeMonsterStatAdjustment.Items.AddRange(new object[] {
            "100%",
            "66%-150%",
            "50%-200%",
            "33%-300%",
            "25%-400%",
            "20%-500%",
            "100%-125%",
            "100%-150%",
            "100%-200%",
            "100%-300%",
            "100%-400%",
            "100%-500%"});
			this.modeMonsterStatAdjustment.Location = new System.Drawing.Point(138, 114);
			this.modeMonsterStatAdjustment.Margin = new System.Windows.Forms.Padding(6);
			this.modeMonsterStatAdjustment.Name = "modeMonsterStatAdjustment";
			this.modeMonsterStatAdjustment.Size = new System.Drawing.Size(151, 28);
			this.modeMonsterStatAdjustment.TabIndex = 23;
			this.toolTip1.SetToolTip(this.modeMonsterStatAdjustment, "Randomize magic spells. None: . Standard: . Pro: . Wild: . Chaos: .");
			this.modeMonsterStatAdjustment.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 95);
			this.label11.Margin = new System.Windows.Forms.Padding(6);
			this.label11.Name = "label11";
			this.label11.Padding = new System.Windows.Forms.Padding(3);
			this.label11.Size = new System.Drawing.Size(87, 26);
			this.label11.TabIndex = 23;
			this.label11.Text = "Hero Stats:";
			this.toolTip1.SetToolTip(this.label11, "Randomize magic spells. None: . Standard: . Pro: . Wild: . Chaos: .");
			// 
			// modeHeroStats
			// 
			this.modeHeroStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeHeroStats.FormattingEnabled = true;
			this.modeHeroStats.Items.AddRange(new object[] {
            "None",
            "Shuffle",
            "Standard",
            "Silly",
            "Wild",
            "Chaos"});
			this.modeHeroStats.Location = new System.Drawing.Point(121, 94);
			this.modeHeroStats.Margin = new System.Windows.Forms.Padding(6);
			this.modeHeroStats.Name = "modeHeroStats";
			this.modeHeroStats.Size = new System.Drawing.Size(151, 28);
			this.modeHeroStats.TabIndex = 24;
			this.toolTip1.SetToolTip(this.modeHeroStats, "Randomize magic spells. None: . Standard: . Pro: . Wild: . Chaos: .");
			this.modeHeroStats.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// flagHeroStatsStandardize
			// 
			this.flagHeroStatsStandardize.AutoSize = true;
			this.flagHeroStatsStandardize.Location = new System.Drawing.Point(121, 131);
			this.flagHeroStatsStandardize.Margin = new System.Windows.Forms.Padding(6);
			this.flagHeroStatsStandardize.Name = "flagHeroStatsStandardize";
			this.flagHeroStatsStandardize.Padding = new System.Windows.Forms.Padding(3);
			this.flagHeroStatsStandardize.Size = new System.Drawing.Size(116, 30);
			this.flagHeroStatsStandardize.TabIndex = 25;
			this.flagHeroStatsStandardize.Text = "Standardize";
			this.toolTip1.SetToolTip(this.flagHeroStatsStandardize, "Preserve who may learn each spell, rather than adjusting to the spell\'s new slot." +
        " (eg, level 1 Flare can still only be learned by Black Wizard)");
			this.flagHeroStatsStandardize.UseVisualStyleBackColor = true;
			this.flagHeroStatsStandardize.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// statExplanation
			// 
			this.statExplanation.Location = new System.Drawing.Point(280, 93);
			this.statExplanation.Margin = new System.Windows.Forms.Padding(2);
			this.statExplanation.Name = "statExplanation";
			this.statExplanation.Padding = new System.Windows.Forms.Padding(3);
			this.statExplanation.Size = new System.Drawing.Size(28, 33);
			this.statExplanation.TabIndex = 28;
			this.statExplanation.Text = "?";
			this.toolTip1.SetToolTip(this.statExplanation, "Undo previous randomization and restore files to a vanilla configuration.");
			this.statExplanation.UseVisualStyleBackColor = true;
			this.statExplanation.Click += new System.EventHandler(this.statExplanation_Click);
			// 
			// flagBoostPromoted
			// 
			this.flagBoostPromoted.AutoSize = true;
			this.flagBoostPromoted.Location = new System.Drawing.Point(249, 131);
			this.flagBoostPromoted.Margin = new System.Windows.Forms.Padding(6);
			this.flagBoostPromoted.Name = "flagBoostPromoted";
			this.flagBoostPromoted.Padding = new System.Windows.Forms.Padding(3);
			this.flagBoostPromoted.Size = new System.Drawing.Size(195, 30);
			this.flagBoostPromoted.TabIndex = 29;
			this.flagBoostPromoted.Text = "Boost promoted classes";
			this.toolTip1.SetToolTip(this.flagBoostPromoted, "Preserve who may learn each spell, rather than adjusting to the spell\'s new slot." +
        " (eg, level 1 Flare can still only be learned by Black Wizard)");
			this.flagBoostPromoted.UseVisualStyleBackColor = true;
			this.flagBoostPromoted.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.modeTreasure);
			this.groupBox1.Controls.Add(this.flagTreasureTrad);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.modeShops);
			this.groupBox1.Controls.Add(this.flagShopsTrad);
			this.groupBox1.Location = new System.Drawing.Point(7, 165);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(465, 117);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Items && Equipment";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.flagReduceEncounterRate);
			this.groupBox2.Controls.Add(this.flagWandsAddInt);
			this.groupBox2.Controls.Add(this.flagRebalancePrices);
			this.groupBox2.Controls.Add(this.modeXPBoost);
			this.groupBox2.Controls.Add(this.flagRestoreCritRating);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(485, 165);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(274, 201);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Balance";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.flagBoostPromoted);
			this.groupBox3.Controls.Add(this.statExplanation);
			this.groupBox3.Controls.Add(this.flagHeroStatsStandardize);
			this.groupBox3.Controls.Add(this.modeHeroStats);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.flagMagicShuffleShops);
			this.groupBox3.Controls.Add(this.modeMagic);
			this.groupBox3.Controls.Add(this.flagMagicKeepPermissions);
			this.groupBox3.Location = new System.Drawing.Point(7, 290);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(465, 169);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Abilities";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.modeMonsterStatAdjustment);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.flagNoEscapeRandomize);
			this.groupBox4.Controls.Add(this.flagNoEscapeNES);
			this.groupBox4.Controls.Add(this.flagReduceChaosHP);
			this.groupBox4.Controls.Add(this.flagRebalanceBosses);
			this.groupBox4.Controls.Add(this.flagFiendsDropRibbons);
			this.groupBox4.Controls.Add(this.flagBossShuffle);
			this.groupBox4.Location = new System.Drawing.Point(7, 478);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(465, 165);
			this.groupBox4.TabIndex = 26;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Monsters && Bosses";
			// 
			// btnInstall
			// 
			this.btnInstall.Location = new System.Drawing.Point(649, 508);
			this.btnInstall.Margin = new System.Windows.Forms.Padding(2);
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.Padding = new System.Windows.Forms.Padding(3);
			this.btnInstall.Size = new System.Drawing.Size(120, 33);
			this.btnInstall.TabIndex = 28;
			this.btnInstall.Text = "Install";
			this.btnInstall.UseVisualStyleBackColor = true;
			this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
			// 
			// FF1PRR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 694);
			this.Controls.Add(this.btnInstall);
			this.Controls.Add(this.btnRestoreVanilla);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.BrowseForFolder);
			this.Controls.Add(this.VisualFlags);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NewSeed);
			this.Controls.Add(this.RandoSeed);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.NewChecksum);
			this.Controls.Add(this.RandoFlags);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.flagKeyItems);
			this.Controls.Add(this.CuteHats);
			this.Controls.Add(this.FF1PRFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRandomize);
			this.Name = "FF1PRR";
			this.Text = "Final Fantasy 1 Pixel Remaster Randomizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFF1PRR_FormClosing);
			this.Load += new System.EventHandler(this.FF1PRR_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRandomize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FF1PRFolder;
		private System.Windows.Forms.CheckBox CuteHats;
		private System.Windows.Forms.CheckBox flagBossShuffle;
		private System.Windows.Forms.CheckBox flagKeyItems;
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
		private System.Windows.Forms.ComboBox modeShops;
		private System.Windows.Forms.CheckBox flagShopsTrad;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox flagMagicShuffleShops;
		private System.Windows.Forms.CheckBox flagMagicKeepPermissions;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox modeXPBoost;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox flagRestoreCritRating;
        private System.Windows.Forms.CheckBox flagRebalancePrices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox modeTreasure;
        private System.Windows.Forms.CheckBox flagTreasureTrad;
        private System.Windows.Forms.CheckBox flagWandsAddInt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox flagRebalanceBosses;
        private System.Windows.Forms.CheckBox flagFiendsDropRibbons;
        private System.Windows.Forms.Button btnRestoreVanilla;
        private System.Windows.Forms.CheckBox flagReduceEncounterRate;
        private System.Windows.Forms.CheckBox flagReduceChaosHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox modeMagic;
		private System.Windows.Forms.CheckBox flagNoEscapeRandomize;
		private System.Windows.Forms.CheckBox flagNoEscapeNES;
		private System.Windows.Forms.ComboBox modeMonsterStatAdjustment;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.CheckBox flagHeroStatsStandardize;
		private System.Windows.Forms.ComboBox modeHeroStats;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button statExplanation;
		private System.Windows.Forms.CheckBox flagBoostPromoted;
	}
}

