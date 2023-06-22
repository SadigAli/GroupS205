namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            Console.WriteLine("Kitab elave etmek ucun 1 duymesine basin");
            Console.WriteLine("Sistemden cixis etmek ucun 0 duymesine basin");
            int result = Convert.ToInt32(Console.ReadLine());
            while (result != 0)
            {
                Console.Write("Kitabin adini daxil edin : ");
                string bookName = Console.ReadLine();
                Console.Write("Kitabin janrini daxil edin : ");
                string genreName = Console.ReadLine();
                Console.Write("Sehife sayini daxil edin : ");
                int page = Convert.ToInt32(Console.ReadLine());
                app.Books.Add(new Book(bookName, genreName, page));
                Console.WriteLine("Kitab elave olundu");
                Console.WriteLine("Kitab elave etmek ucun 1 duymesine basin");
                Console.WriteLine("Sistemden cixis etmek ucun 0 duymesine basin");
                result = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}