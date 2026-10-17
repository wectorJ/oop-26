using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Dot
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dot(int x, int y){
            X = x;
            Y = y;
        }

        public Point ToPoint() => new Point(X, Y);
    }
}