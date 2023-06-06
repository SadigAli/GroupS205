using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifier
{
    internal class Student
    {
        private static int _id;
        public readonly string studentNumber;
        public int Id { get; set; }
        public const int Count = 5;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstname,string lastname)
        {
            studentNumber = Random.Shared.Next(0, 100).ToString();
            Id = ++_id;
            //Count = 12;
            FirstName = firstname;
            LastName = lastname;
        }

        public override string ToString()
        {
            return $"{studentNumber} {FirstName} {LastName}";
        }
    }
}
