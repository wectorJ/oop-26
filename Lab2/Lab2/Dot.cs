using System.Drawing;

namespace Lab2
{
    public class DotShape: Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public DotShape(int x, int y){
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
