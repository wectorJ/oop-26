using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class CubeShape : Shape
    {
        public RectangleShape RectangleS { get; }

        public LineShape LineS { get; }

        public CubeShape(PointF s, PointF e)
        {
            Start = s;
            End = e;

            RectangleS = new RectangleShape(s, e);
            LineS = new LineShape(s, e);
        }

        public override void Draw(Graphics g, Pen pen)
        {
            //AI, maybe need optimized
            float left = Math.Min(Start.X, End.X);
            float right = Math.Max(Start.X, End.X);
            float top = Math.Min(Start.Y, End.Y);
            float bottom = Math.Max(Start.Y, End.Y);
            float offset = 0.25f * Math.Min(right - left, bottom - top);

            PointF[] front =
            {
                new PointF(left, bottom),
                new PointF(left, top + offset),
                new PointF(right - offset, top + offset),
                new PointF(right - offset, bottom)
            };

            RectangleS.Start = front[0];
            RectangleS.End = front[2];
            RectangleS.Draw(g, pen);

            RectangleS.Start = new PointF(left + offset, bottom - offset);
            RectangleS.End = new PointF(right, top);
            RectangleS.Draw(g, pen);

            foreach (PointF vertex in front)
            {
                LineS.Start = vertex;
                LineS.End = new PointF(vertex.X + offset, vertex.Y - offset);
                LineS.Draw(g, pen);
            }
        }
    }
}
