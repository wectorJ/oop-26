using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2
{
    public class Editor
    {
        public List<Shape> Shapes = new();
        private Shape _current;
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

        public void Draw(Graphics g)
        {
            foreach (var s in Shapes) s.Draw(g); //BRAINFUCK always redraw all shapes, maybe better use Bitmap to cashing
            _current?.Draw(g);
        }
    }
}
