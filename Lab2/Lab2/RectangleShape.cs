using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2
{
    public class RectangleShape : Shape
    {
        // Inherit Start/End from Shape (Point)

        public int Left => Math.Min(Start.X, End.X);
        public int Top => Math.Min(Start.Y, End.Y);
        public int Width => Math.Abs(End.X - Start.X);
        public int Height => Math.Abs(End.Y - Start.Y);

        public RectangleShape(Point s, Point e)
        {
            Start = s;
            End = e;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, Left, Top, Width, Height);
        }

        //AI
        public override bool Contains(Point p)
        {
            return p.X >= Left && p.X <= Left + Width &&
                   p.Y >= Top && p.Y <= Top + Height;
        }
    }
}
