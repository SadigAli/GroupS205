using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndAbstraction
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public virtual string GetFullInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
