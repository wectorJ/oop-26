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
        private readonly Stack<Shape> _redo = new();
        public bool CanUndo => Shapes.Count > 0;
        public bool CanRedo => _redo.Count > 0;
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
            _redo.Clear();
            _current = null;
        }

        public void Undo()
        {
            if (!CanUndo) return;

            int last = Shapes.Count - 1;
            _redo.Push(Shapes[last]);
            Shapes.RemoveAt(last);
        }

        public void Redo()
        {
            if (!CanRedo) return;

            Shapes.Add(_redo.Pop());
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
            _redo.Clear();
            _current = null;
        }

        public void Draw(Graphics g)
        {
            using var pen = new Pen(Color.Black, BorderWidth);

            foreach (var shape in Shapes) //BRAINFUCK maybe better use Bitmap for caching
                DrawShape(g, shape, pen);

            if (_current != null)
                DrawShape(g, _current, pen);
        }

        private static void DrawShape(Graphics g, Shape shape, Pen pen)
        {
            pen.Color = shape.Color;
            pen.DashStyle = shape.BorderStyle;
            
            shape.Draw(g, pen);
        }
    }
}
