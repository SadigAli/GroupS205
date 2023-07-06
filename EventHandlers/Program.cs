namespace EventHandlers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User("Nigar","Qurbanova","nigar@gmail.com",true),
                new User("Ruslan","Tagizade","ruslan@gmail.com",false),
                new User("Ramin","Emrahli","ramin@gmail.com",true),
                new User("Emin","Nagizade","emin@gmail.com",false),
            };

            int result = Enter();

            while (result != 0)
            {
                switch (result)
                {
                    case 1:
                        Console.Write("Enter your email : ");
                        string email = Console.ReadLine();
                        Console.Write("Enter your password : ");
                        string password = Console.ReadLine();

                        User user = users.FirstOrDefault(x=>x.Email == email &&  x.Password == password);
                        if(user == null) 
                        {
                            Console.WriteLine("Incorrect credentials");
                        }
                        else
                        {
                            user.IsLogged = true;
                            Console.WriteLine("Successfully logged in");
                        }
                        break;

                    case 2:
                        Product product = EnterProductDetails();
                        foreach (User item in users.Where(x=>x.IsSubscribed))
                        {
                            item.OnProductAdded(product.Name);
                        }
                        break;
                }

                result = Enter();
            }


        }

        public static int Enter()
        {
            Console.WriteLine("1 for Login");
            Console.WriteLine("2 for Add Product");
            return int.Parse(Console.ReadLine());
        }

        public static Product EnterProductDetails()
        {
            Console.Write("Enter pr name : ");
            string name = Console.ReadLine();
            Console.Write("Enter pr price : ");
            double price = double.Parse(Console.ReadLine());
            return new Product(name, price);
        }
    }
}