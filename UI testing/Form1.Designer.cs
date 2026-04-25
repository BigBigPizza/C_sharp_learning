namespace UI_testing
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
            this.tooHighButton = new System.Windows.Forms.Button();
            this.tooLowButton = new System.Windows.Forms.Button();
            this.correctButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.correctGuessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tooHighButton
            // 
            this.tooHighButton.Location = new System.Drawing.Point(390, 224);
            this.tooHighButton.Name = "tooHighButton";
            this.tooHighButton.Size = new System.Drawing.Size(75, 23);
            this.tooHighButton.TabIndex = 0;
            this.tooHighButton.Text = "Too high";
            this.tooHighButton.UseVisualStyleBackColor = true;
            this.tooHighButton.Click += new System.EventHandler(this.tooHighButton_Click);
            // 
            // tooLowButton
            // 
            this.tooLowButton.Location = new System.Drawing.Point(309, 224);
            this.tooLowButton.Name = "tooLowButton";
            this.tooLowButton.Size = new System.Drawing.Size(75, 23);
            this.tooLowButton.TabIndex = 1;
            this.tooLowButton.Text = "Too low";
            this.tooLowButton.UseVisualStyleBackColor = true;
            this.tooLowButton.Click += new System.EventHandler(this.tooLowButton_Click);
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(309, 253);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(156, 23);
            this.correctButton.TabIndex = 2;
            this.correctButton.Text = "Correct!";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Was your number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please think of a number, I will try and guess it";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(420, 192);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 5;
            // 
            // correctGuessLabel
            // 
            this.correctGuessLabel.AutoSize = true;
            this.correctGuessLabel.Location = new System.Drawing.Point(349, 297);
            this.correctGuessLabel.Name = "correctGuessLabel";
            this.correctGuessLabel.Size = new System.Drawing.Size(0, 13);
            this.correctGuessLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.correctGuessLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.tooLowButton);
            this.Controls.Add(this.tooHighButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tooHighButton;
        private System.Windows.Forms.Button tooLowButton;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label correctGuessLabel;
    }
}

