using System;
using System.Drawing;

namespace Lab2
{
    public class LineShape : Shape
    {
        public LineShape(Point s, Point e)
        {
            Start = s;
            End = e;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, Start, End);
        }

        //AI
        public override bool Contains(Point p)
        {
            // Compute distance from p to segment Start-End
            var dx = End.X - Start.X;
            var dy = End.Y - Start.Y;
            var lengthSq = dx * dx + dy * dy;
            if (lengthSq == 0) return (p.X == Start.X && p.Y == Start.Y);

            var t = ((p.X - Start.X) * dx + (p.Y - Start.Y) * dy) / (double)lengthSq;
            t = Math.Max(0, Math.Min(1, t));
            var projX = Start.X + t * dx;
            var projY = Start.Y + t * dy;
            var distSq = (p.X - projX) * (p.X - projX) + (p.Y - projY) * (p.Y - projY);
            return distSq <= 4.0; // within 2 pixels
        }
    }
}