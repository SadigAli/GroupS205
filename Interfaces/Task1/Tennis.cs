using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task1
{
    internal class Tennis : Sport
    {
        public Tennis(string name,string playingTool) : base(name)
        {
            PlayingTool = playingTool;
        }

        public string PlayingTool { get; set; }

        public override string WinningType()
        {
            return "Daha cox round qazanan umumi gorusu qazanir";
        }

    }
}
