using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class RectangleShape : Shape
    {
        public Point Start, End;

        public Rectangle Bounds => new Rectangle(
            Math.Min(Start.X, End.X), Math.Min(Start.Y, End.Y),
            Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));

        public override void Draw(Graphics g) => g.DrawRectangle(Pens.Black, Bounds);
    }
}