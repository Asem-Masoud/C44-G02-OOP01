using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo_OOP01
{
    internal struct Point
    {
        public int X;
        public int Y;

        //Constructor: Special Methods
        //             1. Named Like Struct
        //             2. Has No Return Type


        //CLR :will Generate Paremeterless Constructor
        // This Constructor Will Initialized The Attributes With The Default

        //Constructor
        public Point()
        {

        }

        //public Point()
        //{
        //    X = 8;
        //    Y = 16;
        //}
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        public void PrintPoint()
        {
            Console.WriteLine($"({X}, {Y})");
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
