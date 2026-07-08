namespace Treasure_Hunt
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
            this.GameScreenPanel = new System.Windows.Forms.Panel();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.TreasurePictureBox = new System.Windows.Forms.PictureBox();
            this.GameScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreasurePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameScreenPanel
            // 
            this.GameScreenPanel.Controls.Add(this.TreasurePictureBox);
            this.GameScreenPanel.Controls.Add(this.PlayerPictureBox);
            this.GameScreenPanel.Location = new System.Drawing.Point(12, 12);
            this.GameScreenPanel.Name = "GameScreenPanel";
            this.GameScreenPanel.Size = new System.Drawing.Size(570, 426);
            this.GameScreenPanel.TabIndex = 0;
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.Location = new System.Drawing.Point(138, 57);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(69, 43);
            this.PlayerPictureBox.TabIndex = 1;
            this.PlayerPictureBox.TabStop = false;
            // 
            // TreasurePictureBox
            // 
            this.TreasurePictureBox.Location = new System.Drawing.Point(401, 264);
            this.TreasurePictureBox.Name = "TreasurePictureBox";
            this.TreasurePictureBox.Size = new System.Drawing.Size(100, 50);
            this.TreasurePictureBox.TabIndex = 2;
            this.TreasurePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameScreenPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GameScreenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreasurePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameScreenPanel;
        private System.Windows.Forms.PictureBox TreasurePictureBox;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
    }
}

