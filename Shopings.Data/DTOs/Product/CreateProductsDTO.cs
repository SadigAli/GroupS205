using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopings.Data.DTOs.Product
{
    public class CreateProductsDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
