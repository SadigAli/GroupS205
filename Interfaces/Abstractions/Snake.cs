using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Abstractions
{
    internal class Snake : Animal,IReptile,ISwim
    {
        public Snake(string name) : base(name)
        {
        }

        public void Reptile()
        {
            Console.WriteLine("Snake can reptile");
        }

        public override string Sound()
        {
            return "Fisss";
        }

        public void Swim()
        {
            Console.WriteLine("Snake can swim");
        }
    }
}
