using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Group
    {
        public string Name { get; set; }
        public int Limit { get; set; }
        public Person[] Persons = {};
        public Group(string name,int limit)
        {
            Name = name;
            Limit = limit;
        }

        public void AddPerson(Person person)
        {
            if(Persons.Length == Limit)
            {
                Array.Resize(ref Persons, Persons.Length + 1);
                Persons[Persons.Length - 1] = person;
            }
            else
            {
                throw new LimitException("Your limit is exceed");
            }
        }

        public void GetPersons()
        {
            foreach (Person person in Persons)
            {
                Console.WriteLine(person.FullName());
            }
        }
    }
}
