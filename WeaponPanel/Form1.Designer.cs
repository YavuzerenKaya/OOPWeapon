
namespace WeaponPanel
{
    partial class Form1
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
            this.stopAimButton = new System.Windows.Forms.Button();
            this.aimButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.fireButton = new System.Windows.Forms.Button();
            this.sharpeningButton = new System.Windows.Forms.Button();
            this.bulletCount = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.bulletsInMagazineProgress = new System.Windows.Forms.ProgressBar();
            this.cutOrStabButton = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stopAimButton
            // 
            this.stopAimButton.Location = new System.Drawing.Point(294, 399);
            this.stopAimButton.Name = "stopAimButton";
            this.stopAimButton.Size = new System.Drawing.Size(100, 25);
            this.stopAimButton.TabIndex = 22;
            this.stopAimButton.Text = "Stop Aiming";
            this.stopAimButton.UseVisualStyleBackColor = true;
            this.stopAimButton.Click += new System.EventHandler(this.stopAimButton_Click);
            // 
            // aimButton
            // 
            this.aimButton.Location = new System.Drawing.Point(294, 368);
            this.aimButton.Name = "aimButton";
            this.aimButton.Size = new System.Drawing.Size(100, 25);
            this.aimButton.TabIndex = 21;
            this.aimButton.Text = "Aim";
            this.aimButton.UseVisualStyleBackColor = true;
            this.aimButton.Click += new System.EventHandler(this.aimButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(188, 399);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(100, 25);
            this.reloadButton.TabIndex = 20;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(188, 368);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(100, 25);
            this.fireButton.TabIndex = 19;
            this.fireButton.Text = "Fire";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // sharpeningButton
            // 
            this.sharpeningButton.Location = new System.Drawing.Point(47, 399);
            this.sharpeningButton.Name = "sharpeningButton";
            this.sharpeningButton.Size = new System.Drawing.Size(100, 25);
            this.sharpeningButton.TabIndex = 18;
            this.sharpeningButton.Text = "Sharpenning S";
            this.sharpeningButton.UseVisualStyleBackColor = true;
            this.sharpeningButton.Click += new System.EventHandler(this.sharpeningButton_Click);
            // 
            // bulletCount
            // 
            this.bulletCount.AutoSize = true;
            this.bulletCount.Location = new System.Drawing.Point(450, 368);
            this.bulletCount.Name = "bulletCount";
            this.bulletCount.Size = new System.Drawing.Size(64, 13);
            this.bulletCount.TabIndex = 17;
            this.bulletCount.Text = "Bullet Count";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(47, 349);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(0, 13);
            this.adLabel.TabIndex = 16;
            // 
            // bulletsInMagazineProgress
            // 
            this.bulletsInMagazineProgress.Location = new System.Drawing.Point(520, 368);
            this.bulletsInMagazineProgress.Name = "bulletsInMagazineProgress";
            this.bulletsInMagazineProgress.Size = new System.Drawing.Size(173, 23);
            this.bulletsInMagazineProgress.TabIndex = 15;
            // 
            // cutOrStabButton
            // 
            this.cutOrStabButton.Location = new System.Drawing.Point(47, 368);
            this.cutOrStabButton.Name = "cutOrStabButton";
            this.cutOrStabButton.Size = new System.Drawing.Size(100, 25);
            this.cutOrStabButton.TabIndex = 14;
            this.cutOrStabButton.Text = "Cut or Stab";
            this.cutOrStabButton.UseVisualStyleBackColor = true;
            this.cutOrStabButton.Click += new System.EventHandler(this.cutOrStabButton_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(959, 317);
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 492);
            this.Controls.Add(this.stopAimButton);
            this.Controls.Add(this.aimButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.sharpeningButton);
            this.Controls.Add(this.bulletCount);
            this.Controls.Add(this.adLabel);
            this.Controls.Add(this.bulletsInMagazineProgress);
            this.Controls.Add(this.cutOrStabButton);
            this.Controls.Add(this.picBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopAimButton;
        private System.Windows.Forms.Button aimButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Button sharpeningButton;
        private System.Windows.Forms.Label bulletCount;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.ProgressBar bulletsInMagazineProgress;
        private System.Windows.Forms.Button cutOrStabButton;
        private System.Windows.Forms.PictureBox picBox;
    }
}

