using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasure_Hunt
{
    internal class DrawMap
    {
        public static void Draw(int numberOfRows, int numberOfColumns, int columnSize, int rowSize, int initialXPos, int initialYPos, PaintEventArgs g)
        {
            int columnLineLength = rowSize * (numberOfRows - 1);
            int rowLineLength = columnSize * (numberOfColumns - 1);

            for( int rows = 0; rows < numberOfRows; rows++)
            {
                int newXPosition = initialXPos + (rowSize * rows);

                g.Graphics.DrawLine(new Pen(Color.Black), newXPosition, initialYPos, newXPosition, initialYPos + rowLineLength);
            }
            for ( int cols = 0; cols < numberOfColumns; cols++)
            {
                int newYPosition = initialYPos + (columnSize * cols);

                g.Graphics.DrawLine(new Pen(Color.Black), initialXPos, newYPosition, initialXPos + columnLineLength, newYPosition);
            }
        }
    }
}
