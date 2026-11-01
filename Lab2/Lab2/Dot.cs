using System.Drawing;

namespace Lab2
{
    public class DotShape: Shape
    {
        public float X { get => Start.X; set => Start = new PointF(value, Start.Y); }
        public float Y { get => Start.Y; set => Start = new PointF(Start.X, value); }

        public DotShape(float x, float y){
            X = x;
            Y = y;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            using var brush = new SolidBrush(pen.Color);
            g.FillEllipse(brush, X - 4, Y - 4, 8, 8);
        }
    }
}
