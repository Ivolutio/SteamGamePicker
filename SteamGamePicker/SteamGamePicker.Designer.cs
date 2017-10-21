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
            this.gamesList = new System.Windows.Forms.ListBox();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(9, 109);
            this.outputText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(48, 13);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "Output...";
            // 
            // gamesList
            // 
            this.gamesList.FormattingEnabled = true;
            this.gamesList.Location = new System.Drawing.Point(9, 126);
            this.gamesList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(224, 290);
            this.gamesList.TabIndex = 1;
            // 
            // steamidInput
            // 
            this.steamidInput.Location = new System.Drawing.Point(11, 22);
            this.steamidInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.steamidInput.MaxLength = 17;
            this.steamidInput.Name = "steamidInput";
            this.steamidInput.Size = new System.Drawing.Size(116, 20);
            this.steamidInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Steam ID64";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PlayTime Filter";
            // 
            // hourInput
            // 
            this.hourInput.Location = new System.Drawing.Point(11, 59);
            this.hourInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hourInput.Name = "hourInput";
            this.hourInput.Size = new System.Drawing.Size(18, 20);
            this.hourInput.TabIndex = 5;
            this.hourInput.Text = "0";
            this.hourInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuteInput
            // 
            this.minuteInput.Location = new System.Drawing.Point(46, 59);
            this.minuteInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minuteInput.Name = "minuteInput";
            this.minuteInput.Size = new System.Drawing.Size(18, 20);
            this.minuteInput.TabIndex = 6;
            this.minuteInput.Text = "0";
            this.minuteInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(81, 59);
            this.secondInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(18, 20);
            this.secondInput.TabIndex = 7;
            this.secondInput.Text = "0";
            this.secondInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(9, 83);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(118, 24);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Get Games";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(11, 420);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(220, 39);
            this.chooseButton.TabIndex = 11;
            this.chooseButton.Text = "Choose!";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // randomGameBox
            // 
            this.randomGameBox.BackColor = System.Drawing.SystemColors.Window;
            this.randomGameBox.Location = new System.Drawing.Point(11, 464);
            this.randomGameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomGameBox.Name = "randomGameBox";
            this.randomGameBox.ReadOnly = true;
            this.randomGameBox.Size = new System.Drawing.Size(222, 20);
            this.randomGameBox.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(128, 58);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Use Filter";
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(76, 6);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SteamGamePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 493);
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
            this.Controls.Add(this.gamesList);
            this.Controls.Add(this.outputText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SteamGamePicker";
            this.Text = "SteamGamePicker";
            this.Load += new System.EventHandler(this.SteamGamePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.ListBox gamesList;
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

