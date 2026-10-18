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

        public int Left => Math.Min(Start.X, End.X);
        public int Top => Math.Min(Start.Y, End.Y);
        public int Width => Math.Abs(End.X - Start.X);
        public int Height => Math.Abs(End.Y - Start.Y);

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, Left, Top, Width, Height);
        }

        //AI
        public override bool Contains(Point p)
        {
            if (Width == 0 || Height == 0) return false;
            // Normalize to center-based coordinates
            double cx = Left + Width / 2.0;
            double cy = Top + Height / 2.0;
            double a = Width / 2.0;
            double b = Height / 2.0;
            double nx = (p.X - cx) / a;
            double ny = (p.Y - cy) / b;
            return nx * nx + ny * ny <= 1.0;
        }
    }
}