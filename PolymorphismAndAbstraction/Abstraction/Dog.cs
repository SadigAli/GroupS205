using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndAbstraction.Abstraction
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Meat");
        }

        public override void Sound()
        {
            Console.WriteLine("Hau Hau");
        }
    }
}
