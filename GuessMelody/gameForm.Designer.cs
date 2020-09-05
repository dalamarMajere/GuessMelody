namespace GuessMelody
{
    partial class gameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.contButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreOneLabel = new System.Windows.Forms.Label();
            this.scoreTwoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.counterMusicLabel = new System.Windows.Forms.Label();
            this.ansTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.melodyDurationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addScoreOneButton = new System.Windows.Forms.Button();
            this.takeScoreOneButton = new System.Windows.Forms.Button();
            this.takeScoreTwoButton = new System.Windows.Forms.Button();
            this.addScoreTwoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(-7, 426);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(12, 338);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(270, 82);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY NEXT";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Tempus Sans ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(288, 338);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(138, 82);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // contButton
            // 
            this.contButton.Font = new System.Drawing.Font("Tempus Sans ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contButton.Location = new System.Drawing.Point(432, 338);
            this.contButton.Name = "contButton";
            this.contButton.Size = new System.Drawing.Size(140, 82);
            this.contButton.TabIndex = 3;
            this.contButton.Text = "CONTINUE";
            this.contButton.UseVisualStyleBackColor = true;
            this.contButton.Click += new System.EventHandler(this.contButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player One";
            // 
            // scoreOneLabel
            // 
            this.scoreOneLabel.AutoSize = true;
            this.scoreOneLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOneLabel.Location = new System.Drawing.Point(107, 92);
            this.scoreOneLabel.Name = "scoreOneLabel";
            this.scoreOneLabel.Size = new System.Drawing.Size(36, 38);
            this.scoreOneLabel.TabIndex = 5;
            this.scoreOneLabel.Text = "0";
            // 
            // scoreTwoLabel
            // 
            this.scoreTwoLabel.AutoSize = true;
            this.scoreTwoLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTwoLabel.Location = new System.Drawing.Point(439, 92);
            this.scoreTwoLabel.Name = "scoreTwoLabel";
            this.scoreTwoLabel.Size = new System.Drawing.Size(36, 38);
            this.scoreTwoLabel.TabIndex = 7;
            this.scoreTwoLabel.Tag = "";
            this.scoreTwoLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player Two";
            // 
            // counterMusicLabel
            // 
            this.counterMusicLabel.AutoSize = true;
            this.counterMusicLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterMusicLabel.Location = new System.Drawing.Point(270, 169);
            this.counterMusicLabel.Name = "counterMusicLabel";
            this.counterMusicLabel.Size = new System.Drawing.Size(36, 38);
            this.counterMusicLabel.TabIndex = 8;
            this.counterMusicLabel.Tag = "";
            this.counterMusicLabel.Text = "0";
            // 
            // ansTimeProgressBar
            // 
            this.ansTimeProgressBar.Location = new System.Drawing.Point(12, 255);
            this.ansTimeProgressBar.Name = "ansTimeProgressBar";
            this.ansTimeProgressBar.Size = new System.Drawing.Size(568, 58);
            this.ansTimeProgressBar.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time remain:";
            // 
            // melodyDurationLabel
            // 
            this.melodyDurationLabel.AutoSize = true;
            this.melodyDurationLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melodyDurationLabel.Location = new System.Drawing.Point(469, 213);
            this.melodyDurationLabel.Name = "melodyDurationLabel";
            this.melodyDurationLabel.Size = new System.Drawing.Size(32, 33);
            this.melodyDurationLabel.TabIndex = 11;
            this.melodyDurationLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Music remain:";
            // 
            // addScoreOneButton
            // 
            this.addScoreOneButton.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScoreOneButton.Location = new System.Drawing.Point(75, 107);
            this.addScoreOneButton.Name = "addScoreOneButton";
            this.addScoreOneButton.Size = new System.Drawing.Size(26, 23);
            this.addScoreOneButton.TabIndex = 13;
            this.addScoreOneButton.Text = "+";
            this.addScoreOneButton.UseVisualStyleBackColor = true;
            this.addScoreOneButton.Click += new System.EventHandler(this.addScoreOneButton_Click);
            // 
            // takeScoreOneButton
            // 
            this.takeScoreOneButton.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeScoreOneButton.Location = new System.Drawing.Point(149, 104);
            this.takeScoreOneButton.Name = "takeScoreOneButton";
            this.takeScoreOneButton.Size = new System.Drawing.Size(26, 23);
            this.takeScoreOneButton.TabIndex = 14;
            this.takeScoreOneButton.Text = "–";
            this.takeScoreOneButton.UseVisualStyleBackColor = true;
            this.takeScoreOneButton.Click += new System.EventHandler(this.addScoreOneButton_Click);
            // 
            // takeScoreTwoButton
            // 
            this.takeScoreTwoButton.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeScoreTwoButton.Location = new System.Drawing.Point(481, 101);
            this.takeScoreTwoButton.Name = "takeScoreTwoButton";
            this.takeScoreTwoButton.Size = new System.Drawing.Size(26, 23);
            this.takeScoreTwoButton.TabIndex = 16;
            this.takeScoreTwoButton.Text = "–";
            this.takeScoreTwoButton.UseVisualStyleBackColor = true;
            this.takeScoreTwoButton.Click += new System.EventHandler(this.addScoreOneButton_Click);
            // 
            // addScoreTwoButton
            // 
            this.addScoreTwoButton.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScoreTwoButton.Location = new System.Drawing.Point(407, 104);
            this.addScoreTwoButton.Name = "addScoreTwoButton";
            this.addScoreTwoButton.Size = new System.Drawing.Size(26, 23);
            this.addScoreTwoButton.TabIndex = 15;
            this.addScoreTwoButton.Text = "+";
            this.addScoreTwoButton.UseVisualStyleBackColor = true;
            this.addScoreTwoButton.Click += new System.EventHandler(this.addScoreOneButton_Click);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.pngtree_minimalist_music_master_background_image_1336161;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.takeScoreTwoButton);
            this.Controls.Add(this.addScoreTwoButton);
            this.Controls.Add(this.takeScoreOneButton);
            this.Controls.Add(this.addScoreOneButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.melodyDurationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ansTimeProgressBar);
            this.Controls.Add(this.counterMusicLabel);
            this.Controls.Add(this.scoreTwoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scoreOneLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "gameForm";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gameForm_FormClosed);
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button contButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreOneLabel;
        private System.Windows.Forms.Label scoreTwoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label counterMusicLabel;
        private System.Windows.Forms.ProgressBar ansTimeProgressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label melodyDurationLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addScoreOneButton;
        private System.Windows.Forms.Button takeScoreOneButton;
        private System.Windows.Forms.Button takeScoreTwoButton;
        private System.Windows.Forms.Button addScoreTwoButton;
    }
}