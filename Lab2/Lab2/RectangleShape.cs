using System;
using System.Drawing;

namespace Lab2
{
    public class RectangleShape : Shape
    {
        public int Left => Math.Min(Start.X, End.X);
        public int Top => Math.Min(Start.Y, End.Y);
        public int Width => Math.Abs(End.X - Start.X);
        public int Height => Math.Abs(End.Y - Start.Y);

        public RectangleShape(Point s, Point e)
        {
            Start = s;
            End = e;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, Left, Top, Width, Height);
        }
    }
}
