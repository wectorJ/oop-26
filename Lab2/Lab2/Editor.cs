using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab2
{
    public class Editor
    {
        private const float BorderWidth = 2f;

        public Color color = Color.Black;
        public DashStyle border_style = DashStyle.Solid;

        public List<Shape> Shapes = new(115);
        private Shape? _current;
        public ShapeType CurrentTool = ShapeType.Rectangle;

        public void MouseDown(Point p){
            switch (CurrentTool)
            {
                case ShapeType.Dot:
                    _current = new DotShape(p.X, p.Y);
                    break;
                case ShapeType.Rectangle:
                    _current = new RectangleShape(p, p);
                    break;
                case ShapeType.Line:
                    _current = new LineShape(p, p);
                    break;
                case ShapeType.Ellipse:
                    _current = new EllipseShape(p, p);
                    break;
                default:
                    _current = null;
                    break;
            }

            if (_current != null)
            {
                _current.Color = color;
                _current.BorderStyle = border_style;
            }
        }
        public void MouseMove(Point p){
            if (_current != null) _current.End = p;
        }
        public void MouseUp(Point p)
        {
            if (_current == null) return;
            _current.End = p;
            Shapes.Add(_current);
            _current = null;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void SetBorderStyle(DashStyle style)
        {
            border_style = style;
        }

        public void Clear()
        {
            Shapes.Clear();
            _current = null;
        }

        public void Draw(Graphics g)
        {
            foreach (var shape in Shapes)
                DrawShape(g, shape);

            if (_current != null)
                DrawShape(g, _current);
        }

        private static void DrawShape(Graphics g, Shape shape)
        {
            using var pen = new Pen(shape.Color, BorderWidth)
            {
                DashStyle = shape.BorderStyle
            };

            shape.Draw(g, pen);
        }
    }
}
