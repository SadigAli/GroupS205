using System.Net.Mail;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Console.WriteLine(person.Lastname);

            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(number1/number2);

            //DateTime date = new DateTime(2012,13,21);
            //Console.WriteLine(date.ToString("dd.MM.yyyy"));

            //MailAddress mail = new MailAddress("sadig.aliev99gmail.com");
            //Console.WriteLine(mail.User);

            //var test = "";
            //if(test == "")
            //{
            //    test = ;
            //}
            //var test2 = new Person();
            //Console.WriteLine(test+test2);

            //try
            //{
            //    MailAddress mail = new MailAddress("sadig.aliev99@gmail.com");
            //    try
            //    {
            //        Person person = new Person();
            //        person.Email = mail.Address;
            //        Console.WriteLine(person.Email);
            //    }
            //    catch (NullReferenceException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Email is detected");
            //}

            try
            {
                Group group = new Group("Group 1", 4);
                Person person = new Person("Ruslan", "Tagizade", "ruslan@gmail.com");
                Person person2 = new Person("Ramin", "Emrahli", "ramin@gmail.com");
                Person person3 = new Person("Emin", "Nagiyev", "emin@gmail.com");
                Person person4 = new Person("Rehim", "Rehimov", "rehim@gmail.com");
                Person person5 = new Person("Sadig", "Aliyev", "sadig@gmail.com");

                group.AddPerson(person);
                group.AddPerson(person2);
                group.AddPerson(person3);
                group.AddPerson(person4);
                group.AddPerson(person5);

                group.GetPersons();
            }
            catch (LimitException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}