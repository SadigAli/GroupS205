using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace PolymorphismAndAbstraction
{
    internal class Teacher : Person
    {
        public string Profession { get; set; }
        public Teacher(string firstname,string lastname,string profession) : base(firstname, lastname)
        {
            Profession = profession;
        }

        public override string GetFullInfo()
        {
            return $"{FirstName} {LastName} {Profession}";
        }
    }
}
