using System;
using System.Drawing;

namespace Lab2
{
    public class LineShape : Shape
    {
        public LineShape(PointF s, PointF e)
        {
            Start = s;
            End = e;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, Start, End);
        }
    }
}
