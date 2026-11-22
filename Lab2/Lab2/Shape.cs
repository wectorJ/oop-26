using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab2
{
    public abstract class Shape
    {
        public PointF Start;
        public virtual PointF End { get; set; }

        public Color Color = Color.Black;
        public DashStyle BorderStyle = DashStyle.Solid;

        public abstract void Draw(Graphics g, Pen pen);
    }

    public enum ShapeType
    {
        Dot,
        Line,
        Rectangle,
        Ellipse,
        oLineo,
        Cube
    }
}
