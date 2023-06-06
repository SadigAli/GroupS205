using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task1
{
    internal class Football : Sport
    {
        public string PlayingTool { get; set; }
        public int PlayingTime { get; set; }
        public Football(string name, string playingTool, int playingTime) : base(name)
        {
            PlayingTool = playingTool;
            PlayingTime = playingTime;

        }
        public override string WinningType()
        {
            return "Cox qol vuran qalib gelir";
        }
    }
}
