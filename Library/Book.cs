using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Page { get; set; }

        public Book(string name,string genre,int page)
        {
            Id = ++_id;
            Name = name;
            Genre = genre;
            Page = page;
        }

        public string GetFullInfo()
        {
            return $"Id : {Id}, Name : {Name}, Genre : {Genre}, Page : {Page}";
        }
    }
}
