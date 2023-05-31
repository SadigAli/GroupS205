using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndAbstraction
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public int Score { get; set; }

        //public Student()
        //{
        //    Console.WriteLine("Student has been added");
        //}

        //public Student(string firstname,string lastname,stu) : base()
        //{
            
        //}
        public Student(string firstname,string lastname,string studentNumber,int score) : base(firstname,lastname)
        {
            StudentNumber = studentNumber;
            Score = score;
        }

        public override string GetFullInfo()
        {
            return $"{FirstName} {LastName} {StudentNumber} {Score}";
        }
    }
}
