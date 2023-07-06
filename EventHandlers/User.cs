using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    internal class User
    {
        public event EventHandler<string> ProductAdded;
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = "12345678";
        public bool IsLogged { get; set; } = false;
        public bool IsSubscribed { get; set; }
        public User(string firstname,string lastname,string email,bool isSubscribed)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            IsSubscribed = isSubscribed;
        }

        public string GetFullname()
        {
            return $"{Firstname} {Lastname}";
        }

        public void OnProductAdded(string name)
        {
            Console.WriteLine("Product added by name " + name);
            ProductAdded?.Invoke(this, name); 
        }
    }
}
