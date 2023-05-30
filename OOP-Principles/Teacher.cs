using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    internal class Teacher : Person
    {
        public string TeachingArea { get; set; }
        public Teacher(string firstname,string lastname,int age,string teachingArea) 
                                : base(firstname,lastname,age)
        {
            TeachingArea = teachingArea;
        }
    }
}
