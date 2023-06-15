using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TaskForUserManagement.Exceptions;

namespace TaskForUserManagement
{
    internal class App
    {
        public User[] Users = new User[]
        {
            new User("Sadig","Aliyev","sadig.aliev99@gmail.com","Sadig###123")
        };

        public void AddUser(User user)
        {
            try
            {
                MailAddress mail = new MailAddress(user.Email);
                if(!IsExistUser(user.Email))
                {
                    if (IsValidPassword(user.Password))
                    {
                        Array.Resize(ref Users, Users.Length + 1);
                        Users[Users.Length - 1] = user;
                    }
                    else
                    {
                        throw new PasswordValidException("Your password is not required form");
                    }
                    
                }
                else
                {
                    throw new EmailUniqueException("This user is already exists");
                }

                


            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetUsers()
        {
            foreach (User user in Users)
            {
                Console.WriteLine(user);
            }
        }

        public bool IsExistUser(string email)
        {
            foreach(User user in Users)
            {
                if(user.Email == email) return true;
            }
            return false;
        }

        public User GetUserByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email) return user;
            }
            return null;
        }

        public bool IsValidPassword(string password)
        {
            if (!password.IsDigit()) return false;
            if (!password.IsUpper()) return false;
            if (!password.IsLower()) return false;
            if (!password.IsSymbol()) return false;
            return true;
        }

        public void Login(string email,string password)
        {
            if(IsExistUser(email))
            {
                User user = GetUserByEmail(email);
                if (user.Password == password)
                {
                    user.IsLogged = true;
                }
                else
                {
                    throw new CredentialException("Incorrect Credentials");
                }
            }
            else
            {
                throw new CredentialException("Incorrect Credentials");
            }
        }
    }
}
