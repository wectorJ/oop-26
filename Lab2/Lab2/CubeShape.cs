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

        public float Depth { get; set; } = 40f;

        public CubeShape(PointF s, PointF e)
        {
            Start = s;
            End = e;

            RectangleS = new RectangleShape(s, e);
            LineS = new LineShape(s, e);
        }

        public override void Draw(Graphics g, Pen pen)
        {
            // Depth angle is 45 degrees; Depth is controlled by the mouse wheel.
            float offset = Depth / MathF.Sqrt(2f);
            float dx = End.X - Start.X;
            float dy = End.Y - Start.Y;
            float w = dx - offset;
            float h = -dy - offset;

            PointF[] front =
            {
                Start,
                new PointF(Start.X, Start.Y - h),
                new PointF(Start.X + w, Start.Y - h),
                new PointF(Start.X + w, Start.Y)
            };

            RectangleS.Start = front[0];
            RectangleS.End = front[2];
            RectangleS.Draw(g, pen);

            RectangleS.Start = new PointF(Start.X + offset, Start.Y - offset);
            RectangleS.End = End;
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
