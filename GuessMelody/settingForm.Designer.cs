namespace GuessMelody
{
    partial class settingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingForm));
            this.musicList = new System.Windows.Forms.ListBox();
            this.chooseMusicButton = new System.Windows.Forms.Button();
            this.clearMusicButton = new System.Windows.Forms.Button();
            this.subfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelSetButton = new System.Windows.Forms.Button();
            this.okSetButton = new System.Windows.Forms.Button();
            this.gameSettings = new System.Windows.Forms.GroupBox();
            this.timeToAnswerLabel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keyPlayerTwoComboBox = new System.Windows.Forms.ComboBox();
            this.keyPlayerOneComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.randomStartCheckBox = new System.Windows.Forms.CheckBox();
            this.melodyDurationComboBox = new System.Windows.Forms.ComboBox();
            this.gameDurationComboBox = new System.Windows.Forms.ComboBox();
            this.melodyDurationLabel = new System.Windows.Forms.Label();
            this.gameDurationLabel = new System.Windows.Forms.Label();
            this.gameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicList
            // 
            this.musicList.FormattingEnabled = true;
            this.musicList.Location = new System.Drawing.Point(13, 13);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(560, 225);
            this.musicList.TabIndex = 0;
            // 
            // chooseMusicButton
            // 
            this.chooseMusicButton.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseMusicButton.Location = new System.Drawing.Point(13, 263);
            this.chooseMusicButton.Name = "chooseMusicButton";
            this.chooseMusicButton.Size = new System.Drawing.Size(78, 35);
            this.chooseMusicButton.TabIndex = 1;
            this.chooseMusicButton.Text = "Choose";
            this.chooseMusicButton.UseVisualStyleBackColor = true;
            this.chooseMusicButton.Click += new System.EventHandler(this.chooseMusicButton_Click);
            // 
            // clearMusicButton
            // 
            this.clearMusicButton.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearMusicButton.Location = new System.Drawing.Point(94, 263);
            this.clearMusicButton.Name = "clearMusicButton";
            this.clearMusicButton.Size = new System.Drawing.Size(78, 35);
            this.clearMusicButton.TabIndex = 2;
            this.clearMusicButton.Text = "Clear";
            this.clearMusicButton.UseVisualStyleBackColor = true;
            this.clearMusicButton.Click += new System.EventHandler(this.clearMusicButton_Click);
            // 
            // subfoldersCheckBox
            // 
            this.subfoldersCheckBox.AutoSize = true;
            this.subfoldersCheckBox.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subfoldersCheckBox.Location = new System.Drawing.Point(431, 263);
            this.subfoldersCheckBox.Name = "subfoldersCheckBox";
            this.subfoldersCheckBox.Size = new System.Drawing.Size(135, 23);
            this.subfoldersCheckBox.TabIndex = 3;
            this.subfoldersCheckBox.Text = "Search subfolders";
            this.subfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelSetButton
            // 
            this.cancelSetButton.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSetButton.Location = new System.Drawing.Point(495, 394);
            this.cancelSetButton.Name = "cancelSetButton";
            this.cancelSetButton.Size = new System.Drawing.Size(78, 35);
            this.cancelSetButton.TabIndex = 5;
            this.cancelSetButton.Text = "Cancel";
            this.cancelSetButton.UseVisualStyleBackColor = true;
            this.cancelSetButton.Click += new System.EventHandler(this.cancelSetButton_Click);
            // 
            // okSetButton
            // 
            this.okSetButton.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okSetButton.Location = new System.Drawing.Point(495, 353);
            this.okSetButton.Name = "okSetButton";
            this.okSetButton.Size = new System.Drawing.Size(78, 35);
            this.okSetButton.TabIndex = 4;
            this.okSetButton.Text = "OK";
            this.okSetButton.UseVisualStyleBackColor = true;
            this.okSetButton.Click += new System.EventHandler(this.okSetButton_Click);
            // 
            // gameSettings
            // 
            this.gameSettings.Controls.Add(this.timeToAnswerLabel);
            this.gameSettings.Controls.Add(this.label3);
            this.gameSettings.Controls.Add(this.label4);
            this.gameSettings.Controls.Add(this.keyPlayerTwoComboBox);
            this.gameSettings.Controls.Add(this.keyPlayerOneComboBox);
            this.gameSettings.Controls.Add(this.label2);
            this.gameSettings.Controls.Add(this.label1);
            this.gameSettings.Controls.Add(this.randomStartCheckBox);
            this.gameSettings.Controls.Add(this.melodyDurationComboBox);
            this.gameSettings.Controls.Add(this.gameDurationComboBox);
            this.gameSettings.Controls.Add(this.melodyDurationLabel);
            this.gameSettings.Controls.Add(this.gameDurationLabel);
            this.gameSettings.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSettings.Location = new System.Drawing.Point(13, 304);
            this.gameSettings.Name = "gameSettings";
            this.gameSettings.Size = new System.Drawing.Size(441, 125);
            this.gameSettings.TabIndex = 6;
            this.gameSettings.TabStop = false;
            this.gameSettings.Text = "Game settings";
            // 
            // timeToAnswerLabel
            // 
            this.timeToAnswerLabel.FormattingEnabled = true;
            this.timeToAnswerLabel.Items.AddRange(new object[] {
            "5",
            "10"});
            this.timeToAnswerLabel.Location = new System.Drawing.Point(375, 42);
            this.timeToAnswerLabel.Name = "timeToAnswerLabel";
            this.timeToAnswerLabel.Size = new System.Drawing.Size(42, 23);
            this.timeToAnswerLabel.TabIndex = 12;
            this.timeToAnswerLabel.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time to answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Keys";
            // 
            // keyPlayerTwoComboBox
            // 
            this.keyPlayerTwoComboBox.FormattingEnabled = true;
            this.keyPlayerTwoComboBox.Items.AddRange(new object[] {
            "P",
            "L",
            "M"});
            this.keyPlayerTwoComboBox.Location = new System.Drawing.Point(224, 68);
            this.keyPlayerTwoComboBox.Name = "keyPlayerTwoComboBox";
            this.keyPlayerTwoComboBox.Size = new System.Drawing.Size(42, 23);
            this.keyPlayerTwoComboBox.TabIndex = 8;
            this.keyPlayerTwoComboBox.Text = "P";
            // 
            // keyPlayerOneComboBox
            // 
            this.keyPlayerOneComboBox.FormattingEnabled = true;
            this.keyPlayerOneComboBox.Items.AddRange(new object[] {
            "A",
            "Q",
            "Z"});
            this.keyPlayerOneComboBox.Location = new System.Drawing.Point(224, 39);
            this.keyPlayerOneComboBox.Name = "keyPlayerOneComboBox";
            this.keyPlayerOneComboBox.Size = new System.Drawing.Size(42, 23);
            this.keyPlayerOneComboBox.TabIndex = 7;
            this.keyPlayerOneComboBox.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player Two";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player One";
            // 
            // randomStartCheckBox
            // 
            this.randomStartCheckBox.AutoSize = true;
            this.randomStartCheckBox.Font = new System.Drawing.Font("Tempus Sans ITC", 10.25F, System.Drawing.FontStyle.Bold);
            this.randomStartCheckBox.Location = new System.Drawing.Point(10, 97);
            this.randomStartCheckBox.Name = "randomStartCheckBox";
            this.randomStartCheckBox.Size = new System.Drawing.Size(202, 22);
            this.randomStartCheckBox.TabIndex = 4;
            this.randomStartCheckBox.Text = "Start with random timing";
            this.randomStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // melodyDurationComboBox
            // 
            this.melodyDurationComboBox.FormattingEnabled = true;
            this.melodyDurationComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.melodyDurationComboBox.Location = new System.Drawing.Point(101, 63);
            this.melodyDurationComboBox.Name = "melodyDurationComboBox";
            this.melodyDurationComboBox.Size = new System.Drawing.Size(42, 23);
            this.melodyDurationComboBox.TabIndex = 3;
            this.melodyDurationComboBox.Text = "10";
            // 
            // gameDurationComboBox
            // 
            this.gameDurationComboBox.FormattingEnabled = true;
            this.gameDurationComboBox.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120",
            "180"});
            this.gameDurationComboBox.Location = new System.Drawing.Point(101, 34);
            this.gameDurationComboBox.Name = "gameDurationComboBox";
            this.gameDurationComboBox.Size = new System.Drawing.Size(42, 23);
            this.gameDurationComboBox.TabIndex = 2;
            this.gameDurationComboBox.Text = "60";
            // 
            // melodyDurationLabel
            // 
            this.melodyDurationLabel.AutoSize = true;
            this.melodyDurationLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melodyDurationLabel.Location = new System.Drawing.Point(7, 63);
            this.melodyDurationLabel.Name = "melodyDurationLabel";
            this.melodyDurationLabel.Size = new System.Drawing.Size(97, 15);
            this.melodyDurationLabel.TabIndex = 1;
            this.melodyDurationLabel.Text = "Time to melody";
            // 
            // gameDurationLabel
            // 
            this.gameDurationLabel.AutoSize = true;
            this.gameDurationLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDurationLabel.Location = new System.Drawing.Point(7, 34);
            this.gameDurationLabel.Name = "gameDurationLabel";
            this.gameDurationLabel.Size = new System.Drawing.Size(91, 15);
            this.gameDurationLabel.TabIndex = 0;
            this.gameDurationLabel.Text = "Game duration";
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.gameSettings);
            this.Controls.Add(this.cancelSetButton);
            this.Controls.Add(this.okSetButton);
            this.Controls.Add(this.subfoldersCheckBox);
            this.Controls.Add(this.clearMusicButton);
            this.Controls.Add(this.chooseMusicButton);
            this.Controls.Add(this.musicList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.settingForm_Load);
            this.gameSettings.ResumeLayout(false);
            this.gameSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox musicList;
        private System.Windows.Forms.Button chooseMusicButton;
        private System.Windows.Forms.Button clearMusicButton;
        private System.Windows.Forms.CheckBox subfoldersCheckBox;
        private System.Windows.Forms.Button cancelSetButton;
        private System.Windows.Forms.Button okSetButton;
        private System.Windows.Forms.GroupBox gameSettings;
        private System.Windows.Forms.ComboBox melodyDurationComboBox;
        private System.Windows.Forms.ComboBox gameDurationComboBox;
        private System.Windows.Forms.Label melodyDurationLabel;
        private System.Windows.Forms.Label gameDurationLabel;
        private System.Windows.Forms.CheckBox randomStartCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox keyPlayerOneComboBox;
        private System.Windows.Forms.ComboBox keyPlayerTwoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox timeToAnswerLabel;
        private System.Windows.Forms.Label label3;
    }
}