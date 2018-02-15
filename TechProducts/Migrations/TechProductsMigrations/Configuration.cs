namespace TechProducts.Migrations.TechProductsMigrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TechProducts.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\TechProductsMigrations";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Brand.AddOrUpdate(c => c.BrandName, getBrand());
            context.SaveChanges();
            context.Category.AddOrUpdate(c => c.CategoryName, getCategory());
            context.SaveChanges();
            context.Product.AddOrUpdate(p => p.ProductName, getProduct(context));
            context.SaveChanges();
        }

        private Brand[] getBrand()
        {
            var brands = new List<Brand>
            {
                new Brand { BrandName = "LG"},
                new Brand { BrandName = "Samsung" },
                new Brand { BrandName = "Apple" },
                new Brand { BrandName = "Leef"}
            };

            return brands.ToArray();
        }

        private Category[] getCategory()
        {
            var categories = new List<Category>
            {
                new Category { CategoryName = "Tablet" },
                new Category { CategoryName = "Phone" },
                new Category { CategoryName = "Memory" }
            };

            return categories.ToArray();
        }

        private SubCategory[] getSubCategory()
        {
            var subCategories = new List<SubCategory>
            {
                new SubCategory { SubCategoryName = "Tablet" }
            };

            return subCategories.ToArray();
        }

        private ProductUse[] getProductUse()
        {
            var productUses = new List<ProductUse>
            {
                new ProductUse { ProductUseName = "Tablet" }
            };

            return productUses.ToArray();
        }

        private Product[] getProduct(ApplicationDbContext db)
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductName = "G6",
                    Price = 700,
                    CategoryId = db.Category.FirstOrDefault(c => c.CategoryName == "Phone").CategoryId,
                    //SubCategoryId = db.SubCategory.FirstOrDefault(c => c.CategoryName == "Phone").CategoryId,
                    //ProductUseId = db.ProductUse.FirstOrDefault(c => c.BrandName == "LG").BrandId,
                    BrandId = db.Brand.FirstOrDefault(c => c.BrandName == "LG").BrandId
                },
                new Product
                {
                    ProductName = "Galaxy S8",
                    Price = 850,
                    CategoryId = db.Category.FirstOrDefault(c => c.CategoryName == "Phone").CategoryId,
                    BrandId = db.Brand.FirstOrDefault(c => c.BrandName == "Samsung").BrandId
                },
                new Product
                {
                    ProductName = "iPhone X",
                    Price = 1100,
                    CategoryId = db.Category.FirstOrDefault(c => c.CategoryName == "Phone").CategoryId,
                    BrandId = db.Brand.FirstOrDefault(c => c.BrandName == "Apple").BrandId
                },
                new Product
                {
                    ProductName = "iPad",
                    Price = 800,
                    CategoryId = db.Category.FirstOrDefault(c => c.CategoryName == "Tablet").CategoryId,
                    BrandId = db.Brand.FirstOrDefault(c => c.BrandName == "Apple").BrandId
                },
                new Product
                {
                    ProductName = "iPad Mini",
                    Price = 550,
                    CategoryId = db.Category.FirstOrDefault(c => c.CategoryName == "Tablet").CategoryId,
                    BrandId = db.Brand.FirstOrDefault(c => c.BrandName == "Apple").BrandId
                },
                new Product
                {
                    ProductName = "Galaxy Tab",
                    Price = 800,
                    CategoryId = db.Category.FirstOrDefault(c => c.CategoryName == "Tablet").CategoryId,
                    BrandId = db.Brand.FirstOrDefault(c => c.BrandName == "Samsung").BrandId
                },
                new Product
                {
                    ProductName = "Bridge 128GB",
                    Price = 100,
                    CategoryId = db.Category.FirstOrDefault(c => c.CategoryName == "Memory").CategoryId,
                    BrandId = db.Brand.FirstOrDefault(c => c.BrandName == "Leef").BrandId
                }

            };

            return products.ToArray();
        }
    }
}
