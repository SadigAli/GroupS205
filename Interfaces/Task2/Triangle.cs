using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task2
{
    internal class Triangle : Figure
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        public Triangle(int first,int second,int third)
        {
            First = first;
            Second = second;
            Third = third;
        }
        public override int Area()
        {
            return First * Second * Third;
        }

        public override int Perimeter()
        {
            return First + Second + Third;
        }
    }
}
