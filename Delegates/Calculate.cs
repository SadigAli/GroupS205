using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal static class Calculate
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine( a + b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Difference(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public static int Divide(int a, int b) => a / b;
        public static int Power(int a) => a*a;
        public static int Cube(int a) => a * a*a;
    }
}
