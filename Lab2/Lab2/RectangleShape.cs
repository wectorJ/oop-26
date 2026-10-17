using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class RectangleShape : Shape
    {
        public Dot Start { get; set; }
        public Dot End { get; set; }

        public int Left => Math.Min(Start.X, End.X);
        public int Top => Math.Min(Start.Y, End.Y);
        public int Width => Math.Abs(End.X - Start.X);
        public int Height => Math.Abs(End.Y - Start.Y);

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, Left, Top, Width, Height);
        }

        public bool Contains(Dot p)
        {
            return p.X >= Left && p.X <= Left + Width &&
                   p.Y >= Top && p.Y <= Top + Height;
        }
    }
}