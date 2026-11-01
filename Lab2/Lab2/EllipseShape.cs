using System;
using System.Drawing;

namespace Lab2
{
    public class EllipseShape : Shape
    {
        public EllipseShape(PointF s, PointF e)
        {
            Start = s;
            End = e;
        }

        public float Left
        {
            get { return Math.Min(Start.X, End.X); }
        }

        public float Top
        {
            get { return Math.Min(Start.Y, End.Y); }
        }

        public float Width
        {
            get { return Math.Abs(End.X - Start.X); }
        }

        public float Height
        {
            get { return Math.Abs(End.Y - Start.Y); }
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, Left, Top, Width, Height);
        }
    }
}
