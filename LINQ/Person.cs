using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public override string ToString() => $"{Firstname} {Lastname}";
    }
}
