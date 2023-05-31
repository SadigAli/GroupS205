using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopings.Data.Entities
{
    public class Categories :BaseEntity
    {
        public string Name { get; set; }
        public decimal Slug { get; set; }
        public int MyProperty { get; set; }
        public List<Product> Products { get; set; }
        public string  CategorySlug { get; set; }
    }
}
