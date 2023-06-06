using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Abstractions
{
    internal class Duck : Animal,ISwim,IWalk,IFly
    {
        public Duck(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Duck can fly");
        }

        public override string Sound()
        {
            return "ga ga ga";
        }

        public void Swim()
        {
            Console.WriteLine("Duck can swim");
        }

        public void Walk()
        {
            Console.WriteLine("Duck can walk");
        }
    }
}
