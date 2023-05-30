using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        protected int Age;
        public Person(string firstname,string lastname,int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public Person()
        {
            Console.WriteLine("New Person created");
        }

        public string GetFullInfo()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}
