using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP01
{
    #region Q1P01
    internal struct Point
    {
        public double X; //{ get; set; }
        public double Y;//{ get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double DistanceTo(Point other)
        {
            double deltaX = other.X - X;
            double deltaY = other.Y - Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    #endregion

}
