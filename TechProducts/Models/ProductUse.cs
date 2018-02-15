using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechProducts.Models
{
    public class ProductUse
    {
        public int ProductUseId { get; set; }
        public string ProductUseName { get; set; }

        public List<Product> Products { get; set; }
    }
}