namespace Overloading
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
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Items.AddRange(new object[] {
            "Square"});
            this.shapeComboBox.Location = new System.Drawing.Point(12, 12);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(121, 21);
            this.shapeComboBox.TabIndex = 0;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(154, 9);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.shapeComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.Button drawButton;
    }
}

