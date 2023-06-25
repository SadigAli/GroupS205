using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask
{
    internal class Student
    {
        public int Id { get; set; }
        public string Firstame { get; set; }
        public string Lastname { get; set; }
        public string StudentNumber { get; set; }
        public double GPA { get; set; }
        public int GroupId { get; set; }
        public Student(string firstname,string lastname,string studentNumber,double gpa)
        {
            Firstame = firstname;
            Lastname = lastname;
            StudentNumber = studentNumber;
            GPA = gpa;
        }

        public override string ToString() => $"{Firstame} {Lastname}";

    }
}
