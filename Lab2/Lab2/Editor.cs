using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab2
{
    public sealed class Editor
    {
        private const float BorderWidth = 2f;
        public static Editor Instance { get; } = new();

        private Editor()
        {
        }

        public Color color = Color.Black;
        public DashStyle border_style = DashStyle.Solid;

        public List<Shape> Shapes = new(115);
        public event EventHandler? ShapesChanged;
        public event EventHandler? SelectionChanged;
        private readonly Stack<Shape> _redo = new();
        // Undo can only remove shapes added since the last history reset.
        private int _undoStartIndex;
        private Shape? _selectedShape;
        public bool CanUndo => Shapes.Count > _undoStartIndex;
        public bool CanRedo => _redo.Count > 0;
        private Shape? _current;
        public ShapeType CurrentTool = ShapeType.Rectangle;

        public Shape? SelectedShape
        {
            get => _selectedShape;
            set
            {
                if (ReferenceEquals(_selectedShape, value)) return;

                _selectedShape = value;
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void MouseDown(Point p){
            _current = Shape.Create(CurrentTool, p, p);

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
            ShapesChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Undo()
        {
            if (!CanUndo) return;

            int last = Shapes.Count - 1;
            Shape shape = Shapes[last];
            _redo.Push(shape);
            Shapes.RemoveAt(last);
            if (ReferenceEquals(SelectedShape, shape)) SelectedShape = null;
            ShapesChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Redo()
        {
            if (!CanRedo) return;

            Shapes.Add(_redo.Pop());
            ShapesChanged?.Invoke(this, EventArgs.Empty);
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void SetBorderStyle(DashStyle style)
        {
            border_style = style;
        }

        public void RemoveShape(Shape shape)
        {
            int index = Shapes.FindIndex(item => ReferenceEquals(item, shape));
            if (index < 0) return;

            Shapes.RemoveAt(index);
            _undoStartIndex = Shapes.Count;
            _redo.Clear();
            if (ReferenceEquals(SelectedShape, shape)) SelectedShape = null;
            ShapesChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Clear() => ReplaceShapes(Array.Empty<Shape>());

        public void ReplaceShapes(IEnumerable<Shape> shapes)
        {
            Shape[] replacement = shapes.ToArray();
            Shapes.Clear();
            Shapes.AddRange(replacement);
            _undoStartIndex = Shapes.Count;
            _redo.Clear();
            _current = null;
            SelectedShape = null;
            ShapesChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Draw(Graphics g)
        {
            using var pen = new Pen(Color.Black, BorderWidth);

            foreach (var shape in Shapes) //BRAINFUCK maybe better use Bitmap for caching
                DrawShape(g, shape, pen);

            if (_current != null)
                DrawShape(g, _current, pen);
        }

        private void DrawShape(Graphics g, Shape shape, Pen pen)
        {
            pen.Color = ReferenceEquals(shape, SelectedShape) ? Color.Orange : shape.Color;
            pen.DashStyle = shape.BorderStyle;
            
            shape.Draw(g, pen);
        }
    }
}
