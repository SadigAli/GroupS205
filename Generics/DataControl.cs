using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class DataControl<T> where T : Person
    {
        public T[] Elements = new T[] { };
        public void Add(T element)
        {
            Array.Resize(ref Elements, Elements.Length+1);
            Elements[Elements.Length-1] = element;
        }

        public void Get()
        {
            foreach(T element in Elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
