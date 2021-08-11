
namespace FF1_PRR
{
	partial class frmFF1PRR
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
			this.cmdRandomize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFF1PRFolder = new System.Windows.Forms.TextBox();
			this.chkCuteHats = new System.Windows.Forms.CheckBox();
			this.chkShuffleBossSpots = new System.Windows.Forms.CheckBox();
			this.chkKeyItems = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRandoFlags = new System.Windows.Forms.TextBox();
			this.lblNewChecksum = new System.Windows.Forms.Label();
			this.txtSeed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNew = new System.Windows.Forms.Button();
			this.txtVisualFlags = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cboShops = new System.Windows.Forms.ComboBox();
			this.chkTraditional = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// cmdRandomize
			// 
			this.cmdRandomize.Location = new System.Drawing.Point(668, 409);
			this.cmdRandomize.Name = "cmdRandomize";
			this.cmdRandomize.Size = new System.Drawing.Size(120, 29);
			this.cmdRandomize.TabIndex = 0;
			this.cmdRandomize.Text = "Randomize!";
			this.cmdRandomize.UseVisualStyleBackColor = true;
			this.cmdRandomize.Click += new System.EventHandler(this.cmdRandomize_Click);
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
			// txtFF1PRFolder
			// 
			this.txtFF1PRFolder.Location = new System.Drawing.Point(116, 6);
			this.txtFF1PRFolder.Name = "txtFF1PRFolder";
			this.txtFF1PRFolder.Size = new System.Drawing.Size(502, 27);
			this.txtFF1PRFolder.TabIndex = 2;
			// 
			// chkCuteHats
			// 
			this.chkCuteHats.AutoSize = true;
			this.chkCuteHats.Location = new System.Drawing.Point(12, 188);
			this.chkCuteHats.Name = "chkCuteHats";
			this.chkCuteHats.Size = new System.Drawing.Size(95, 24);
			this.chkCuteHats.TabIndex = 3;
			this.chkCuteHats.Text = "Cute Hats";
			this.chkCuteHats.UseVisualStyleBackColor = true;
			this.chkCuteHats.Click += new System.EventHandler(this.determineFlags);
			// 
			// chkShuffleBossSpots
			// 
			this.chkShuffleBossSpots.AutoSize = true;
			this.chkShuffleBossSpots.Location = new System.Drawing.Point(12, 128);
			this.chkShuffleBossSpots.Name = "chkShuffleBossSpots";
			this.chkShuffleBossSpots.Size = new System.Drawing.Size(152, 24);
			this.chkShuffleBossSpots.TabIndex = 4;
			this.chkShuffleBossSpots.Text = "Shuffle Boss Spots";
			this.chkShuffleBossSpots.UseVisualStyleBackColor = true;
			this.chkShuffleBossSpots.Click += new System.EventHandler(this.determineFlags);
			// 
			// chkKeyItems
			// 
			this.chkKeyItems.AutoSize = true;
			this.chkKeyItems.Location = new System.Drawing.Point(12, 158);
			this.chkKeyItems.Name = "chkKeyItems";
			this.chkKeyItems.Size = new System.Drawing.Size(174, 24);
			this.chkKeyItems.TabIndex = 5;
			this.chkKeyItems.Text = "Randomize Key Items";
			this.chkKeyItems.UseVisualStyleBackColor = true;
			this.chkKeyItems.Click += new System.EventHandler(this.determineFlags);
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
			// txtRandoFlags
			// 
			this.txtRandoFlags.Location = new System.Drawing.Point(116, 47);
			this.txtRandoFlags.Name = "txtRandoFlags";
			this.txtRandoFlags.Size = new System.Drawing.Size(346, 27);
			this.txtRandoFlags.TabIndex = 7;
			// 
			// lblNewChecksum
			// 
			this.lblNewChecksum.AutoSize = true;
			this.lblNewChecksum.Location = new System.Drawing.Point(12, 413);
			this.lblNewChecksum.Name = "lblNewChecksum";
			this.lblNewChecksum.Size = new System.Drawing.Size(267, 20);
			this.lblNewChecksum.TabIndex = 8;
			this.lblNewChecksum.Text = "New Checksum:  (Not Randomized Yet)";
			// 
			// txtSeed
			// 
			this.txtSeed.Location = new System.Drawing.Point(554, 44);
			this.txtSeed.Name = "txtSeed";
			this.txtSeed.Size = new System.Drawing.Size(160, 27);
			this.txtSeed.TabIndex = 10;
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
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(729, 43);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(59, 29);
			this.btnNew.TabIndex = 11;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// txtVisualFlags
			// 
			this.txtVisualFlags.Location = new System.Drawing.Point(116, 84);
			this.txtVisualFlags.Name = "txtVisualFlags";
			this.txtVisualFlags.Size = new System.Drawing.Size(346, 27);
			this.txtVisualFlags.TabIndex = 13;
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
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(693, 6);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(95, 28);
			this.btnBrowse.TabIndex = 14;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Shop Randomization";
			// 
			// cboShops
			// 
			this.cboShops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboShops.FormattingEnabled = true;
			this.cboShops.Items.AddRange(new object[] {
            "None",
            "Shuffle",
            "Standard",
            "Pro",
            "Wild"});
			this.cboShops.Location = new System.Drawing.Point(196, 222);
			this.cboShops.Name = "cboShops";
			this.cboShops.Size = new System.Drawing.Size(151, 28);
			this.cboShops.TabIndex = 16;
			this.cboShops.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
			// 
			// chkTraditional
			// 
			this.chkTraditional.AutoSize = true;
			this.chkTraditional.Location = new System.Drawing.Point(367, 224);
			this.chkTraditional.Name = "chkTraditional";
			this.chkTraditional.Size = new System.Drawing.Size(102, 24);
			this.chkTraditional.TabIndex = 17;
			this.chkTraditional.Text = "NES Shops";
			this.chkTraditional.UseVisualStyleBackColor = true;
			this.chkTraditional.Click += new System.EventHandler(this.determineFlags);
			// 
			// frmFF1PRR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.chkTraditional);
			this.Controls.Add(this.cboShops);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtVisualFlags);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.txtSeed);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblNewChecksum);
			this.Controls.Add(this.txtRandoFlags);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chkKeyItems);
			this.Controls.Add(this.chkShuffleBossSpots);
			this.Controls.Add(this.chkCuteHats);
			this.Controls.Add(this.txtFF1PRFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdRandomize);
			this.Name = "frmFF1PRR";
			this.Text = "Final Fantasy 1 Pixel Remaster Randomizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFF1PRR_FormClosing);
			this.Load += new System.EventHandler(this.frmFF1PRR_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdRandomize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFF1PRFolder;
		private System.Windows.Forms.CheckBox chkCuteHats;
		private System.Windows.Forms.CheckBox chkShuffleBossSpots;
		private System.Windows.Forms.CheckBox chkKeyItems;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRandoFlags;
		private System.Windows.Forms.Label lblNewChecksum;
		private System.Windows.Forms.TextBox txtSeed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.TextBox txtVisualFlags;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboShops;
		private System.Windows.Forms.CheckBox chkTraditional;
	}
}

