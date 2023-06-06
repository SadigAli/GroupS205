using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifier
{
    internal static class Calculator
    {
        //public static string Name { get; set; }
        //static Calculator()
        //{
        //    Console.WriteLine("gesfdb");
        //}
        public static int Calc(int x, int y)
        {
            return x + y;
        }

        public static int Sum(params int[] values)
        {
            int sum = 0;
            foreach (int i in values)
            {
                sum += i;
            }
            return sum;
        }

        public static int Cube(this int x,int y)
        {
            return (x+y) * (x+y) * (x+y);
        }

        public static int Square(this int x)
        {
            return x * x;
        }

        public static string RemoveLetter(this string s,char letter) 
        {
            string newStr = "";
            foreach (char c in s)
            {
                if (c != letter) newStr += c; 
            }
            return newStr;
        }
    }
}
