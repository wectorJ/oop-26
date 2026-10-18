using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2
{
    public class DotShape: Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public DotShape(int x, int y){
            X = x;
            Y = y;
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Black, X - 4, Y - 4, 8, 8); // circle to represent the dot
        }
    }
}
