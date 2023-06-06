using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task2
{
    internal class Round : Figure
    {
        public int Radius { get; set; }
        public Round(int radius)
        {
            Radius = radius;
        }
        public override int Area()
        {
            return 3 * (int)Math.Pow(Radius,2);
        }

        public override int Perimeter()
        {
            return 2 * 3 * Radius;
        }
    }
}
