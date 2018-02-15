using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechProducts.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public List<ProductUse> ProductUses { get; set; }
    }
}