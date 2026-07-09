using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DrawShape.Shape shape;

        private void drawButton_Click(object sender, EventArgs e)
        {
            switch (shapeComboBox.Text)
            {
                case "Square":
                    shape = new DrawShape.Square();
                    break;
                default:
                    shape = null;
                    break;
            }
            this.Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                shape.draw(e.Graphics);
            }
        }
    }
}
