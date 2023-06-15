using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForUserManagement.Exceptions
{
    internal class EmailUniqueException : Exception
    {
        public EmailUniqueException(string message) : base(message)
        {
        }
    }
}
