using System;
using System.Drawing;

namespace Lab2
{
    public class EllipseShape : Shape
    {
        public EllipseShape(Point s, Point e)
        {
            Start = s;
            End = e;
        }

        public int Left
        {
            get { return Math.Min(Start.X, End.X); }
        }

        public int Top
        {
            get { return Math.Min(Start.Y, End.Y); }
        }

        public int Width
        {
            get { return Math.Abs(End.X - Start.X); }
        }

        public int Height
        {
            get { return Math.Abs(End.Y - Start.Y); }
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, Left, Top, Width, Height);
        }
    }
}