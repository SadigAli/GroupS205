using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopings.Data.Entities
{
    public class Product : BaseEntity
    {
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string  Image { get; set; }
        public Categories Categories { get; set; }
        public string ProductSlug { get; set; }

    }
}
