using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public Person(string firstname,string lastname,string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
        }

        public string FullName()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
