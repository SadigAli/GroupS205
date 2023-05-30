using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct
{
    internal class Student
    {
        public string FirstName;
        public string LastName;
        public string Profession;

        public Student(string FirstName,string lastname,string profession)
        {
            //Console.WriteLine("New student has been created");
            //FirstName = "Ramin";
            //LastName = "Emrahli";
            //Profession = "Automation of Processing";
            this.FirstName = FirstName;
            LastName = lastname;
            //Profession = profession;
        }

        public Student()
        {
            Console.WriteLine("New student has been created");
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetFullInfo()
        {
            return $"{GetFullName()} {Profession}";
        }


    }


}
