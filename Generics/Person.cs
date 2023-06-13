using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Person
    {
        private static int _id;
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Person(string firstname,string lastname)
        {
            Id = ++_id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
