using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    internal class OrderEventArgs : EventArgs
    {
        public bool Status { get; set; }
        public DateTime ChangeTime { get; set; } = DateTime.Now;
    }
}
