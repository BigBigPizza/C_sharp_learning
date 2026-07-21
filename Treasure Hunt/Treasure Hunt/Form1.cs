using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasure_Hunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numberOfRows = 8;
        int numberOfColumns = 8;

        int rowSize = 80;
        int colSize = 50;

        int initialXPos = 40;
        int initialYPos = 40;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawMap.Draw(numberOfRows, numberOfColumns, colSize, rowSize, initialXPos, initialYPos, e);
        }
    }
}
