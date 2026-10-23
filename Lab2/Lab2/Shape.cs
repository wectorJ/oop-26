using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab2
{
    public abstract class Shape
    {
        public Point Start;
        public Point End;

        public Color Color = Color.Black;
        public DashStyle BorderStyle = DashStyle.Solid;

        public abstract void Draw(Graphics g, Pen pen);
    }

    public enum ShapeType
    {
        Dot,
        Line,
        Rectangle,
        Ellipse
    }
}
