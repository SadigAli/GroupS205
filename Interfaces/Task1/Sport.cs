using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task1
{
    internal class Sport
    {
        public string Name { get; set; }
        public Sport(string name)
        {
            Name = name;
        }
        public virtual string WinningType()
        {
            return "";
        }
    }
}
