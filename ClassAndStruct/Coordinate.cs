using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct
{
    internal struct Coordinate
    {
        public int X;
        public int Y;

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public Coordinate(int x)
        //{
        //    X = x;
        //} // compile-error
        public string GetCoordinate()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
