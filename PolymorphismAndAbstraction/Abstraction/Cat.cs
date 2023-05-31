using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndAbstraction.Abstraction
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Miau Miau");
        }

        public override void Eat()
        {
            Console.WriteLine("Milk");
        }
    }
}
