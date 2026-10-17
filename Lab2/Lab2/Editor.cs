using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Editor
    {
        public List<Shape> Shapes { get; } = new();
        private RectangleShape _current;

        public void MouseDown(Point p){
            _current = new RectangleShape { Start = new Dot(p.X, p.Y), End = new Dot(p.X, p.Y) };
        }
        public void MouseMove(Point p){
            if (_current != null) _current.End = new Dot(p.X, p.Y);
        }
        public void MouseUp(Point p)
        {
            if (_current == null) return;
            _current.End = new Dot(p.X, p.Y);
            Shapes.Add(_current);
            _current = null;
        }

        public void Draw(Graphics g)
        {
            foreach (var s in Shapes) s.Draw(g);
            _current?.Draw(g);
        }
    }
}