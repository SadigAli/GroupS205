using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Abstractions
{
    internal class Eagle : Animal,IWalk,IFly
    {
        public Eagle(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Eagle can fly");
        }

        public override string Sound()
        {
            return "";
        }

        public void Walk()
        {
            Console.WriteLine("Eagle can walk");
        }
    }
}
