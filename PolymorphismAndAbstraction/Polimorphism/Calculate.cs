using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndAbstraction
{
    internal class Calculate
    {
        public int Calc()
        {
            return 0;
        }

        public int Calc(int x)
        {
            return x * x;
        }

        public int Calc(string x) 
        {
            return x.Length;
        }

        public int Calc(int x, int y)
        {
            return x * x + y * y;
        }
    }
}
