using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task1
{
    internal class Judo : Sport
    {
        public string[] Fints;
        public Judo(string name) : base(name)
        {
        }

        public override string WinningType()
        {
            return "Cox xal qazanan ve ya ipponla qazanilir";
        }
    }
}
