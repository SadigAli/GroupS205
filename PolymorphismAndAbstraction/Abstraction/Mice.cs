using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndAbstraction.Abstraction
{
    internal class Mice : Animal
    {
        public Mice(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("anything");   
        }

        public override void Sound()
        {
            Console.WriteLine("My My");
        }
    }
}
