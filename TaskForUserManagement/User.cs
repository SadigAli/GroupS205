using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForUserManagement
{
    internal class User
    {
        private static int _id;
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsLogged { get; set; } = false;
        public User(string firstname,string lastname,string email,string password)
        {
            Id = ++_id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
