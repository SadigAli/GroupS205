using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Worker
    {
        private int _id;
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Worker(string firstname,string lastname,string profession,int salary)
        {
            Id = ++_id;
            Firstname = firstname;
            Lastname = lastname;
            Profession = profession;
            Salary = salary;
        }

        public override string ToString() => $"{Firstname} {Lastname}";
    }
}
