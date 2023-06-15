using TaskForUserManagement.Exceptions;

namespace TaskForUserManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            #region Register
            //try
            //{
            //    Console.Write("Adinizi daxil edin : ");
            //    string firstname = Console.ReadLine();
            //    Console.Write("Soyadinizi daxil edin : ");
            //    string lastname = Console.ReadLine();
            //    Console.Write("Emailinizi daxil edin : ");
            //    string email = Console.ReadLine();
            //    Console.Write("Parolunuzu daxil edin : ");
            //    string password = Console.ReadLine();
            //    User user = new User(firstname,lastname,email,password);
            //    app.AddUser(user);
            //    Console.WriteLine("You are registered successfully");
            //    app.GetUsers();
            //}
            //catch (EmailUniqueException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (PasswordValidException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Login
            try
            {
                Console.Write("Emaili daxil edin : ");
                string email = Console.ReadLine();
                Console.Write("Parolu daxil edin : ");
                string password = Console.ReadLine();
                app.Login(email,password);
                Console.WriteLine("You are successfully logged in");
            }
            catch(CredentialException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

        }
    }
}