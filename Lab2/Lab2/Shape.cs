using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2
{
    public abstract class Shape
    {
        //TODO maybe without get and set?
        public Point Start { get; set; }
        public Point End { get; set; }

        // concrete shape override how its drawn
        public abstract void Draw(Graphics g);

        //FUTURE //AI for selection, check if point is inside shape
        public virtual bool Contains(Point p) => false;

        //FUTURE //AI for moving shapes, move shape by dx, dy
        public virtual void Move(int dx, int dy)
        {
            Start = new Point(Start.X + dx, Start.Y + dy);
            End = new Point(End.X + dx, End.Y + dy);
        }
    }

    public enum ShapeType
    {
        Dot,
        Line,
        Rectangle,
        Ellipse
    }
}
