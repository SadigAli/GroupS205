using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task3
{
    internal class Str
    {
        public string s { get; set; }
        public Str(string s)
        {
            this.s = s;
        }
        public int IndexOf(char ch)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch) return i;
            }
            return -1;
        }

        public int IndexOf(string str)
        {
            for(int i=0;i<s.Length;i++)
            {
                int j = 0;
                for (j = 0; j < str.Length; j++)
                {
                    if (s[i + j] != str[j]) break;
                }
                if (j == str.Length)
                    return i;
            }
            return -1;
        }

        public int IndexOf(char ch,int start)
        {
            for (int i = start; i < s.Length; i++)
            {
                if (s[i] == ch) return i;
            }
            return -1;
        }

        public int IndexOf(string str,int start)
        {
            for (int i = start; i < s.Length; i++)
            {
                int j = 0;
                for (j = 0; j < str.Length; j++)
                {
                    if (s[i + j] != str[j]) break;
                }
                if (j == str.Length)
                    return i;
            }
            return -1;
        }
    }
}
