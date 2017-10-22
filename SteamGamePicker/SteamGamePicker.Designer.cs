namespace SteamGamePicker
{
    partial class SteamGamePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputText = new System.Windows.Forms.Label();
            this.steamidInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hourInput = new System.Windows.Forms.TextBox();
            this.minuteInput = new System.Windows.Forms.TextBox();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.chooseButton = new System.Windows.Forms.Button();
            this.randomGameBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioUnsorted = new System.Windows.Forms.RadioButton();
            this.radioAlphabetic = new System.Windows.Forms.RadioButton();
            this.radioPlaytimeHigh = new System.Windows.Forms.RadioButton();
            this.radioPlaytimeLow = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamIDFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gamesList = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioSortTimeD = new System.Windows.Forms.RadioButton();
            this.radioSortTimeA = new System.Windows.Forms.RadioButton();
            this.radioSortNameD = new System.Windows.Forms.RadioButton();
            this.radioSortNameA = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(16, 142);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(63, 17);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "Output...";
            // 
            // steamidInput
            // 
            this.steamidInput.Location = new System.Drawing.Point(117, 31);
            this.steamidInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.steamidInput.MaxLength = 17;
            this.steamidInput.Name = "steamidInput";
            this.steamidInput.Size = new System.Drawing.Size(168, 22);
            this.steamidInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Steam ID64";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "PlayTime Filter";
            // 
            // hourInput
            // 
            this.hourInput.Location = new System.Drawing.Point(117, 60);
            this.hourInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hourInput.Name = "hourInput";
            this.hourInput.Size = new System.Drawing.Size(23, 22);
            this.hourInput.TabIndex = 5;
            this.hourInput.Text = "0";
            this.hourInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuteInput
            // 
            this.minuteInput.Location = new System.Drawing.Point(165, 60);
            this.minuteInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minuteInput.Name = "minuteInput";
            this.minuteInput.Size = new System.Drawing.Size(23, 22);
            this.minuteInput.TabIndex = 6;
            this.minuteInput.Text = "30";
            this.minuteInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(213, 60);
            this.secondInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(23, 22);
            this.secondInput.TabIndex = 7;
            this.secondInput.Text = "0";
            this.secondInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 116);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(317, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Get Games";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(18, 490);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(314, 65);
            this.chooseButton.TabIndex = 11;
            this.chooseButton.Text = "Choose!";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // randomGameBox
            // 
            this.randomGameBox.BackColor = System.Drawing.SystemColors.Window;
            this.randomGameBox.Location = new System.Drawing.Point(19, 559);
            this.randomGameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomGameBox.Name = "randomGameBox";
            this.randomGameBox.ReadOnly = true;
            this.randomGameBox.Size = new System.Drawing.Size(313, 22);
            this.randomGameBox.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(19, 90);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Use Time Filter";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioUnsorted
            // 
            this.radioUnsorted.Location = new System.Drawing.Point(0, 0);
            this.radioUnsorted.Name = "radioUnsorted";
            this.radioUnsorted.Size = new System.Drawing.Size(104, 24);
            this.radioUnsorted.TabIndex = 0;
            // 
            // radioAlphabetic
            // 
            this.radioAlphabetic.Location = new System.Drawing.Point(0, 0);
            this.radioAlphabetic.Name = "radioAlphabetic";
            this.radioAlphabetic.Size = new System.Drawing.Size(104, 24);
            this.radioAlphabetic.TabIndex = 0;
            // 
            // radioPlaytimeHigh
            // 
            this.radioPlaytimeHigh.Location = new System.Drawing.Point(0, 0);
            this.radioPlaytimeHigh.Name = "radioPlaytimeHigh";
            this.radioPlaytimeHigh.Size = new System.Drawing.Size(104, 24);
            this.radioPlaytimeHigh.TabIndex = 0;
            // 
            // radioPlaytimeLow
            // 
            this.radioPlaytimeLow.Location = new System.Drawing.Point(0, 0);
            this.radioPlaytimeLow.Name = "radioPlaytimeLow";
            this.radioPlaytimeLow.Size = new System.Drawing.Size(104, 24);
            this.radioPlaytimeLow.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(469, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.editToolStripMenuItem.Text = "Config";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamIDFinderToolStripMenuItem,
            this.steamDeveloperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // steamIDFinderToolStripMenuItem
            // 
            this.steamIDFinderToolStripMenuItem.Name = "steamIDFinderToolStripMenuItem";
            this.steamIDFinderToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.steamIDFinderToolStripMenuItem.Text = "Steam ID Finder";
            this.steamIDFinderToolStripMenuItem.Click += new System.EventHandler(this.steamIDFinderToolStripMenuItem_Click);
            // 
            // steamDeveloperToolStripMenuItem
            // 
            this.steamDeveloperToolStripMenuItem.Name = "steamDeveloperToolStripMenuItem";
            this.steamDeveloperToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.steamDeveloperToolStripMenuItem.Text = "Get API Key";
            this.steamDeveloperToolStripMenuItem.Click += new System.EventHandler(this.steamDeveloperToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(155, 90);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 21);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Output to file";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 28);
            this.linkLabel1.TabIndex = 20;
            // 
            // gamesList
            // 
            this.gamesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Playtime});
            this.gamesList.Location = new System.Drawing.Point(19, 161);
            this.gamesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(313, 325);
            this.gamesList.TabIndex = 15;
            this.gamesList.UseCompatibleStateImageBehavior = false;
            this.gamesList.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 212;
            // 
            // Playtime
            // 
            this.Playtime.Text = "Playtime";
            this.Playtime.Width = 93;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioSortTimeD);
            this.panel1.Controls.Add(this.radioSortTimeA);
            this.panel1.Controls.Add(this.radioSortNameD);
            this.panel1.Controls.Add(this.radioSortNameA);
            this.panel1.Location = new System.Drawing.Point(338, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 95);
            this.panel1.TabIndex = 21;
            // 
            // radioSortTimeD
            // 
            this.radioSortTimeD.AutoSize = true;
            this.radioSortTimeD.Location = new System.Drawing.Point(3, 69);
            this.radioSortTimeD.Name = "radioSortTimeD";
            this.radioSortTimeD.Size = new System.Drawing.Size(106, 21);
            this.radioSortTimeD.TabIndex = 3;
            this.radioSortTimeD.Text = "Time (Desc)";
            this.radioSortTimeD.UseVisualStyleBackColor = true;
            this.radioSortTimeD.CheckedChanged += new System.EventHandler(this.radioSortTimeD_CheckedChanged);
            // 
            // radioSortTimeA
            // 
            this.radioSortTimeA.AutoSize = true;
            this.radioSortTimeA.Location = new System.Drawing.Point(3, 47);
            this.radioSortTimeA.Name = "radioSortTimeA";
            this.radioSortTimeA.Size = new System.Drawing.Size(97, 21);
            this.radioSortTimeA.TabIndex = 2;
            this.radioSortTimeA.Text = "Time (Asc)";
            this.radioSortTimeA.UseVisualStyleBackColor = true;
            this.radioSortTimeA.CheckedChanged += new System.EventHandler(this.radioSortTimeA_CheckedChanged);
            // 
            // radioSortNameD
            // 
            this.radioSortNameD.AutoSize = true;
            this.radioSortNameD.Location = new System.Drawing.Point(3, 24);
            this.radioSortNameD.Name = "radioSortNameD";
            this.radioSortNameD.Size = new System.Drawing.Size(112, 21);
            this.radioSortNameD.TabIndex = 1;
            this.radioSortNameD.Text = "Name (Desc)";
            this.radioSortNameD.UseVisualStyleBackColor = true;
            this.radioSortNameD.CheckedChanged += new System.EventHandler(this.radioSortNameD_CheckedChanged);
            // 
            // radioSortNameA
            // 
            this.radioSortNameA.AutoSize = true;
            this.radioSortNameA.Checked = true;
            this.radioSortNameA.Location = new System.Drawing.Point(3, 3);
            this.radioSortNameA.Name = "radioSortNameA";
            this.radioSortNameA.Size = new System.Drawing.Size(103, 21);
            this.radioSortNameA.TabIndex = 0;
            this.radioSortNameA.TabStop = true;
            this.radioSortNameA.Text = "Name (Asc)";
            this.radioSortNameA.UseVisualStyleBackColor = true;
            this.radioSortNameA.CheckedChanged += new System.EventHandler(this.radioSortNameA_CheckedChanged);
            // 
            // SteamGamePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gamesList);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.randomGameBox);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.minuteInput);
            this.Controls.Add(this.hourInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.steamidInput);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "SteamGamePicker";
            this.Load += new System.EventHandler(this.SteamGamePicker_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.TextBox steamidInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hourInput;
        private System.Windows.Forms.TextBox minuteInput;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.TextBox randomGameBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioPlaytimeLow;
        private System.Windows.Forms.RadioButton radioPlaytimeHigh;
        private System.Windows.Forms.RadioButton radioAlphabetic;
        private System.Windows.Forms.RadioButton radioUnsorted;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamIDFinderToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem steamDeveloperToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListView gamesList;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioSortTimeD;
        private System.Windows.Forms.RadioButton radioSortTimeA;
        private System.Windows.Forms.RadioButton radioSortNameD;
        private System.Windows.Forms.RadioButton radioSortNameA;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Playtime;
    }
}

