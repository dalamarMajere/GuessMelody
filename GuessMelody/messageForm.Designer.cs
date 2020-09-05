namespace GuessMelody
{
    partial class messageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messageForm));
            this.playerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.showAnswerLabel = new System.Windows.Forms.Label();
            this.rightAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("AR BERKLEY", 36.75F);
            this.playerLabel.Location = new System.Drawing.Point(242, 21);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(139, 63);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Is it right answer?";
            // 
            // yesButton
            // 
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesButton.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(12, 343);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(202, 68);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noButton.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(382, 343);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(202, 68);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 18.75F);
            this.label2.Location = new System.Drawing.Point(140, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time to answer:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 18.75F);
            this.timerLabel.Location = new System.Drawing.Point(314, 106);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(32, 33);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "0";
            // 
            // showAnswerLabel
            // 
            this.showAnswerLabel.AutoSize = true;
            this.showAnswerLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAnswerLabel.Location = new System.Drawing.Point(42, 199);
            this.showAnswerLabel.Name = "showAnswerLabel";
            this.showAnswerLabel.Size = new System.Drawing.Size(45, 20);
            this.showAnswerLabel.TabIndex = 6;
            this.showAnswerLabel.Text = "Show";
            this.showAnswerLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showAnswerLabel_MouseClick);
            // 
            // rightAnswerLabel
            // 
            this.rightAnswerLabel.AutoSize = true;
            this.rightAnswerLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.rightAnswerLabel.Location = new System.Drawing.Point(108, 199);
            this.rightAnswerLabel.Name = "rightAnswerLabel";
            this.rightAnswerLabel.Size = new System.Drawing.Size(0, 20);
            this.rightAnswerLabel.TabIndex = 7;
            // 
            // messageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.rightAnswerLabel);
            this.Controls.Add(this.showAnswerLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "messageForm";
            this.Text = "Answer!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.messageForm_FormClosed);
            this.Load += new System.EventHandler(this.messageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label showAnswerLabel;
        private System.Windows.Forms.Label rightAnswerLabel;
    }
}