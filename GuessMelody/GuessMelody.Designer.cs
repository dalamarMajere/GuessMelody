namespace GuessMelody
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.gameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameButton
            // 
            this.gameButton.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.Location = new System.Drawing.Point(222, 61);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(164, 71);
            this.gameButton.TabIndex = 0;
            this.gameButton.Text = "Game";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(222, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(164, 71);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.Location = new System.Drawing.Point(222, 147);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(164, 71);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "Setting";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.pngtree_minimalist_music_master_background_image_1336161;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Guess Melody";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingButton;
    }
}

