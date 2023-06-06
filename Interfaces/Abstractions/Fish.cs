using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Abstractions
{
    internal class Fish : Animal,ISwim
    {
        public Fish(string name) : base(name)
        {
        }

        public override string Sound()
        {
            return "";
        }

        public void Swim()
        {
            Console.WriteLine("Fish can swim");
        }
    }
}
