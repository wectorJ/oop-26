using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class oLineoShape : Shape
    {
        public DotShape DotS { get; }
        public LineShape LineS { get; }

        public oLineoShape(PointF s, PointF e)
        {
            Start = s;
            End = e;

            DotS = new DotShape(s.X, s.Y);
            LineS = new LineShape(s, e);
        }

        public override void Draw(Graphics g, Pen pen)
        {
            DotS.X = Start.X;
            DotS.Y = Start.Y;
            DotS.Draw(g, pen);

            LineS.Start = Start;
            LineS.End = End;
            LineS.Draw(g, pen);

            DotS.X = End.X;
            DotS.Y = End.Y;
            DotS.Draw(g, pen);
        }
    }
}