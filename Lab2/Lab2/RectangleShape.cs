using System;
using System.Drawing;

namespace Lab2
{
    public class RectangleShape : Shape
    {
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

        public RectangleShape(PointF s, PointF e)
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
