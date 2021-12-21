
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
            this.randoMagic = new System.Windows.Forms.CheckBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(1055, 866);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Padding = new System.Windows.Forms.Padding(5);
            this.btnRandomize.Size = new System.Drawing.Size(195, 53);
            this.btnRandomize.TabIndex = 0;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(169, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "FF1 PR Folder";
            // 
            // FF1PRFolder
            // 
            this.FF1PRFolder.Location = new System.Drawing.Point(208, 22);
            this.FF1PRFolder.Name = "FF1PRFolder";
            this.FF1PRFolder.Size = new System.Drawing.Size(886, 39);
            this.FF1PRFolder.TabIndex = 2;
            this.FF1PRFolder.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\FINAL FANTASY PR";
            // 
            // CuteHats
            // 
            this.CuteHats.AutoSize = true;
            this.CuteHats.Location = new System.Drawing.Point(788, 205);
            this.CuteHats.Name = "CuteHats";
            this.CuteHats.Padding = new System.Windows.Forms.Padding(5);
            this.CuteHats.Size = new System.Drawing.Size(160, 46);
            this.CuteHats.TabIndex = 3;
            this.CuteHats.Text = "Cute Hats";
            this.toolTip1.SetToolTip(this.CuteHats, "Your hat is cute.");
            this.CuteHats.UseVisualStyleBackColor = true;
            this.CuteHats.Click += new System.EventHandler(this.DetermineFlags);
            // 
            // flagBossShuffle
            // 
            this.flagBossShuffle.AutoSize = true;
            this.flagBossShuffle.Enabled = false;
            this.flagBossShuffle.Location = new System.Drawing.Point(280, 36);
            this.flagBossShuffle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagBossShuffle.Name = "flagBossShuffle";
            this.flagBossShuffle.Padding = new System.Windows.Forms.Padding(5);
            this.flagBossShuffle.Size = new System.Drawing.Size(253, 46);
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
            this.flagKeyItems.Location = new System.Drawing.Point(20, 205);
            this.flagKeyItems.Name = "flagKeyItems";
            this.flagKeyItems.Padding = new System.Windows.Forms.Padding(5);
            this.flagKeyItems.Size = new System.Drawing.Size(286, 46);
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
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(191, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gameplay Flags";
            // 
            // RandoFlags
            // 
            this.RandoFlags.Location = new System.Drawing.Point(208, 83);
            this.RandoFlags.Name = "RandoFlags";
            this.RandoFlags.Size = new System.Drawing.Size(560, 39);
            this.RandoFlags.TabIndex = 7;
            // 
            // NewChecksum
            // 
            this.NewChecksum.AutoSize = true;
            this.NewChecksum.Location = new System.Drawing.Point(20, 872);
            this.NewChecksum.Margin = new System.Windows.Forms.Padding(3);
            this.NewChecksum.Name = "NewChecksum";
            this.NewChecksum.Padding = new System.Windows.Forms.Padding(5);
            this.NewChecksum.Size = new System.Drawing.Size(441, 42);
            this.NewChecksum.TabIndex = 8;
            this.NewChecksum.Text = "New Checksum:  (Not Randomized Yet)";
            // 
            // RandoSeed
            // 
            this.RandoSeed.Location = new System.Drawing.Point(881, 83);
            this.RandoSeed.Name = "RandoSeed";
            this.RandoSeed.Size = new System.Drawing.Size(248, 39);
            this.RandoSeed.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(77, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seed";
            // 
            // NewSeed
            // 
            this.NewSeed.Location = new System.Drawing.Point(1154, 80);
            this.NewSeed.Name = "NewSeed";
            this.NewSeed.Padding = new System.Windows.Forms.Padding(5);
            this.NewSeed.Size = new System.Drawing.Size(96, 53);
            this.NewSeed.TabIndex = 11;
            this.NewSeed.Text = "New";
            this.NewSeed.UseVisualStyleBackColor = true;
            this.NewSeed.Click += new System.EventHandler(this.NewSeed_Click);
            // 
            // VisualFlags
            // 
            this.VisualFlags.Location = new System.Drawing.Point(208, 146);
            this.VisualFlags.Name = "VisualFlags";
            this.VisualFlags.Size = new System.Drawing.Size(560, 39);
            this.VisualFlags.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(183, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cosmetic Flags";
            // 
            // BrowseForFolder
            // 
            this.BrowseForFolder.Location = new System.Drawing.Point(1115, 19);
            this.BrowseForFolder.Name = "BrowseForFolder";
            this.BrowseForFolder.Padding = new System.Windows.Forms.Padding(5);
            this.BrowseForFolder.Size = new System.Drawing.Size(133, 51);
            this.BrowseForFolder.TabIndex = 14;
            this.BrowseForFolder.Text = "Browse";
            this.BrowseForFolder.UseVisualStyleBackColor = true;
            this.BrowseForFolder.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(94, 42);
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
            this.modeShops.Location = new System.Drawing.Point(197, 42);
            this.modeShops.Margin = new System.Windows.Forms.Padding(10);
            this.modeShops.Name = "modeShops";
            this.modeShops.Size = new System.Drawing.Size(243, 40);
            this.modeShops.TabIndex = 16;
            this.toolTip1.SetToolTip(this.modeShops, "Randomize shop contents. None: . Shuffle: . Standard: . Pro: . Wild: .");
            this.modeShops.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // flagShopsTrad
            // 
            this.flagShopsTrad.AutoSize = true;
            this.flagShopsTrad.Location = new System.Drawing.Point(458, 38);
            this.flagShopsTrad.Margin = new System.Windows.Forms.Padding(10);
            this.flagShopsTrad.Name = "flagShopsTrad";
            this.flagShopsTrad.Padding = new System.Windows.Forms.Padding(5);
            this.flagShopsTrad.Size = new System.Drawing.Size(253, 46);
            this.flagShopsTrad.TabIndex = 17;
            this.flagShopsTrad.Text = "E&xclude DoS items";
            this.toolTip1.SetToolTip(this.flagShopsTrad, "Remove newer items (Ether, Phoenix Down, etc) from shops.");
            this.flagShopsTrad.UseVisualStyleBackColor = true;
            this.flagShopsTrad.CheckedChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 18;
            // 
            // randoMagic
            // 
            this.randoMagic.AutoSize = true;
            this.randoMagic.Checked = true;
            this.randoMagic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randoMagic.Location = new System.Drawing.Point(13, 45);
            this.randoMagic.Margin = new System.Windows.Forms.Padding(10);
            this.randoMagic.Name = "randoMagic";
            this.randoMagic.Padding = new System.Windows.Forms.Padding(5);
            this.randoMagic.Size = new System.Drawing.Size(247, 46);
            this.randoMagic.TabIndex = 19;
            this.randoMagic.Text = "Randomize &Magic";
            this.toolTip1.SetToolTip(this.randoMagic, "Change which spells are available at each level, and in which shops they can be p" +
        "urchased.");
            this.randoMagic.UseVisualStyleBackColor = true;
            this.randoMagic.CheckedChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // flagMagicKeepPermissions
            // 
            this.flagMagicKeepPermissions.AutoSize = true;
            this.flagMagicKeepPermissions.Location = new System.Drawing.Point(280, 45);
            this.flagMagicKeepPermissions.Margin = new System.Windows.Forms.Padding(10);
            this.flagMagicKeepPermissions.Name = "flagMagicKeepPermissions";
            this.flagMagicKeepPermissions.Padding = new System.Windows.Forms.Padding(5);
            this.flagMagicKeepPermissions.Size = new System.Drawing.Size(241, 46);
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
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(155, 42);
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
            this.modeXPBoost.Location = new System.Drawing.Point(172, 42);
            this.modeXPBoost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.modeXPBoost.Name = "modeXPBoost";
            this.modeXPBoost.Size = new System.Drawing.Size(80, 40);
            this.modeXPBoost.TabIndex = 22;
            this.toolTip1.SetToolTip(this.modeXPBoost, "How much to increase earned XP and Gil.");
            this.modeXPBoost.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(118, 42);
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
            this.modeTreasure.Location = new System.Drawing.Point(197, 104);
            this.modeTreasure.Margin = new System.Windows.Forms.Padding(10);
            this.modeTreasure.Name = "modeTreasure";
            this.modeTreasure.Size = new System.Drawing.Size(243, 40);
            this.modeTreasure.TabIndex = 19;
            this.toolTip1.SetToolTip(this.modeTreasure, "Randomize treasure chest contents. None: . Shuffle: . Standard: . Pro: . Wild: .");
            this.modeTreasure.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // flagTreasureTrad
            // 
            this.flagTreasureTrad.AutoSize = true;
            this.flagTreasureTrad.Enabled = false;
            this.flagTreasureTrad.Location = new System.Drawing.Point(458, 101);
            this.flagTreasureTrad.Margin = new System.Windows.Forms.Padding(10);
            this.flagTreasureTrad.Name = "flagTreasureTrad";
            this.flagTreasureTrad.Padding = new System.Windows.Forms.Padding(5);
            this.flagTreasureTrad.Size = new System.Drawing.Size(253, 46);
            this.flagTreasureTrad.TabIndex = 20;
            this.flagTreasureTrad.Text = "E&xclude DoS items";
            this.toolTip1.SetToolTip(this.flagTreasureTrad, "Remove newer items (Ether, Phoenix Down, etc) from shops.");
            this.flagTreasureTrad.UseVisualStyleBackColor = true;
            this.flagTreasureTrad.CheckedChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // flagRebalancePrices
            // 
            this.flagRebalancePrices.AutoSize = true;
            this.flagRebalancePrices.Location = new System.Drawing.Point(8, 86);
            this.flagRebalancePrices.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagRebalancePrices.Name = "flagRebalancePrices";
            this.flagRebalancePrices.Padding = new System.Windows.Forms.Padding(5);
            this.flagRebalancePrices.Size = new System.Drawing.Size(288, 46);
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
            this.flagRestoreCritRating.Location = new System.Drawing.Point(8, 131);
            this.flagRestoreCritRating.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagRestoreCritRating.Name = "flagRestoreCritRating";
            this.flagRestoreCritRating.Padding = new System.Windows.Forms.Padding(5);
            this.flagRestoreCritRating.Size = new System.Drawing.Size(244, 46);
            this.flagRestoreCritRating.TabIndex = 22;
            this.flagRestoreCritRating.Text = "Restore crit rating";
            this.toolTip1.SetToolTip(this.flagRestoreCritRating, "Weapon critical rate changed to reflect original NES data.");
            this.flagRestoreCritRating.UseVisualStyleBackColor = true;
            this.flagRestoreCritRating.CheckedChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // flagWandsAddInt
            // 
            this.flagWandsAddInt.AutoSize = true;
            this.flagWandsAddInt.Location = new System.Drawing.Point(8, 178);
            this.flagWandsAddInt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagWandsAddInt.Name = "flagWandsAddInt";
            this.flagWandsAddInt.Padding = new System.Windows.Forms.Padding(5);
            this.flagWandsAddInt.Size = new System.Drawing.Size(218, 46);
            this.flagWandsAddInt.TabIndex = 23;
            this.flagWandsAddInt.Text = "Wands add INT";
            this.toolTip1.SetToolTip(this.flagWandsAddInt, "Staves and Hammers increase the user\'s Intelligence when equipped.");
            this.flagWandsAddInt.UseVisualStyleBackColor = true;
            this.flagWandsAddInt.CheckedChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // flagFiendsDropRibbons
            // 
            this.flagFiendsDropRibbons.AutoSize = true;
            this.flagFiendsDropRibbons.Location = new System.Drawing.Point(8, 126);
            this.flagFiendsDropRibbons.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagFiendsDropRibbons.Name = "flagFiendsDropRibbons";
            this.flagFiendsDropRibbons.Padding = new System.Windows.Forms.Padding(5);
            this.flagFiendsDropRibbons.Size = new System.Drawing.Size(275, 46);
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
            this.flagRebalanceBosses.Location = new System.Drawing.Point(8, 82);
            this.flagRebalanceBosses.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagRebalanceBosses.Name = "flagRebalanceBosses";
            this.flagRebalanceBosses.Padding = new System.Windows.Forms.Padding(5);
            this.flagRebalanceBosses.Size = new System.Drawing.Size(206, 46);
            this.flagRebalanceBosses.TabIndex = 6;
            this.flagRebalanceBosses.Text = "Harder bosses";
            this.toolTip1.SetToolTip(this.flagRebalanceBosses, "Increase HP of several bosses, notably Death Eye and the Fiend refights.");
            this.flagRebalanceBosses.UseVisualStyleBackColor = true;
            this.flagRebalanceBosses.CheckedChanged += new System.EventHandler(this.DetermineFlags);
            // 
            // btnRestoreVanilla
            // 
            this.btnRestoreVanilla.Location = new System.Drawing.Point(1055, 813);
            this.btnRestoreVanilla.Name = "btnRestoreVanilla";
            this.btnRestoreVanilla.Padding = new System.Windows.Forms.Padding(5);
            this.btnRestoreVanilla.Size = new System.Drawing.Size(195, 53);
            this.btnRestoreVanilla.TabIndex = 27;
            this.btnRestoreVanilla.Text = "Restore vanilla";
            this.toolTip1.SetToolTip(this.btnRestoreVanilla, "Undo previous randomization and restore files to a vanilla configuration.");
            this.btnRestoreVanilla.UseVisualStyleBackColor = true;
            this.btnRestoreVanilla.Click += new System.EventHandler(this.btnRestoreVanilla_Click);
            // 
            // flagReduceEncounterRate
            // 
            this.flagReduceEncounterRate.AutoSize = true;
            this.flagReduceEncounterRate.Location = new System.Drawing.Point(8, 224);
            this.flagReduceEncounterRate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagReduceEncounterRate.Name = "flagReduceEncounterRate";
            this.flagReduceEncounterRate.Padding = new System.Windows.Forms.Padding(5);
            this.flagReduceEncounterRate.Size = new System.Drawing.Size(298, 46);
            this.flagReduceEncounterRate.TabIndex = 24;
            this.flagReduceEncounterRate.Text = "Reduce encounter rate";
            this.toolTip1.SetToolTip(this.flagReduceEncounterRate, "Reduces rate of random encounters significantly on the ocean and slightly everywh" +
        "ere else.");
            this.flagReduceEncounterRate.UseVisualStyleBackColor = true;
            // 
            // flagReduceChaosHP
            // 
            this.flagReduceChaosHP.AutoSize = true;
            this.flagReduceChaosHP.Location = new System.Drawing.Point(9, 36);
            this.flagReduceChaosHP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flagReduceChaosHP.Name = "flagReduceChaosHP";
            this.flagReduceChaosHP.Padding = new System.Windows.Forms.Padding(5);
            this.flagReduceChaosHP.Size = new System.Drawing.Size(243, 46);
            this.flagReduceChaosHP.TabIndex = 7;
            this.flagReduceChaosHP.Text = "Reduce Chaos HP";
            this.toolTip1.SetToolTip(this.flagReduceChaosHP, "Decrease HP of Chaos to 9600.");
            this.flagReduceChaosHP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.modeTreasure);
            this.groupBox1.Controls.Add(this.flagTreasureTrad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.modeShops);
            this.groupBox1.Controls.Add(this.flagShopsTrad);
            this.groupBox1.Location = new System.Drawing.Point(11, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 187);
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
            this.groupBox2.Location = new System.Drawing.Point(788, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 322);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.randoMagic);
            this.groupBox3.Controls.Add(this.flagMagicKeepPermissions);
            this.groupBox3.Location = new System.Drawing.Point(11, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 122);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abilities";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flagReduceChaosHP);
            this.groupBox4.Controls.Add(this.flagRebalanceBosses);
            this.groupBox4.Controls.Add(this.flagFiendsDropRibbons);
            this.groupBox4.Controls.Add(this.flagBossShuffle);
            this.groupBox4.Location = new System.Drawing.Point(11, 590);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(756, 213);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monsters && Bosses";
            // 
            // FF1PRR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 933);
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
            this.Margin = new System.Windows.Forms.Padding(5);
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
		private System.Windows.Forms.CheckBox randoMagic;
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
    }
}

