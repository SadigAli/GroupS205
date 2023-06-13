using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Student:Person
    {
        
        public string StudentNumber { get; set; }

        public Student(string firstname,string lastname, string studentNumber):base(firstname,lastname)
        {
            StudentNumber = studentNumber;
        }

        public override string ToString() 
        {
            return $"{Id} - {Firstname} {Lastname} - {StudentNumber}";
        }
    }
}
