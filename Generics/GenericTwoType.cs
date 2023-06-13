using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericTwoType<T,U> where T :struct
    {
        public T Key { get; set; }
        public U Value { get; set; }
        public GenericTwoType(T key,U value)
        {
            Key = key;
            Value = value;
        }
    }
}
