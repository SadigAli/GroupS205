using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class App
    {
        public List<Book> Books { get; set; } = new List<Book>();
        
        public void GetBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.GetFullInfo());
            }
        }
    }
}
