using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechProducts.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public virtual Brand Brand { get; set; }
        public int BrandId { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }

        public virtual ProductUse ProductUse { get; set; }
        public int ProductUseId { get; set; }
    }
}
