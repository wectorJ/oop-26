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

        internal static Shape? Create(ShapeType type, PointF start, PointF end) => type switch
        {
            ShapeType.Dot => new DotShape(start.X, start.Y),
            ShapeType.Line => new LineShape(start, end),
            ShapeType.Rectangle => new RectangleShape(start, end),
            ShapeType.Ellipse => new EllipseShape(start, end),
            ShapeType.oLineo => new oLineoShape(start, end),
            ShapeType.Cube => new CubeShape(start, end),
            _ => null
        };
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
