using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask
{
    internal class Filter
    {
        public string Search { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string OrderColumn { get; set; } = "id";
        public string Direction { get; set; } = "asc";
        public Filter(string search,int min,int max,string order_column,string direction)
        {
            Search = search;
            Min = min;
            Max = max;
            OrderColumn = order_column;
            Direction = direction;
        }
    }
}
