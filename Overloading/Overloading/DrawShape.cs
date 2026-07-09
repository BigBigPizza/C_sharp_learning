using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class DrawShape
    {
        public class Shape
        {
            public virtual void draw(Graphics g)
            {
                //nothing
            }
        }

        public class Square : Shape
        {
            public override void draw(Graphics g)
            {
                g.DrawRectangle(Pens.Black, 50, 50, 100, 100);
            }
        }


    }
}
