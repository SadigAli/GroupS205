using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForUserManagement
{
    internal static class PasswordControl
    {
        public static bool IsDigit(this string input)
        {
            foreach (char c in input)
            {
                if(char.IsDigit(c)) return true;
            }
            return false;
        }

        public static bool IsUpper(this string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }

        public static bool IsLower(this string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c)) return true;
            }
            return false;
        }

        public static bool IsSymbol(this string input)
        {
            foreach (char c in input)
            {
                if (c == '#' || c == '!' || c == '@' || c == '%') return true;
            }
            return false;
        }
    }
}
