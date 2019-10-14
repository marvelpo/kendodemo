using System;
using System.Collections.Generic;
using Blumind.Models;

namespace Blumind.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlumindContext>
    {
        protected override void Seed(BlumindContext context)
        {
            var categories = new List<Category>
            {
            new Category{Name="Kategorija 1", ValidFrom=DateTime.Parse("2005-09-01")},
            new Category{Name="Kategorija 2", ValidFrom=DateTime.Parse("2005-10-01")},
            new Category{Name="Kategorija 3", ValidFrom=DateTime.Parse("2005-11-01")},
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            
            var products = new List<Product>
            {
            new Product{CategoryID=1, Name="Product 1", ValidFrom = DateTime.Parse("2005-01-01"), Price = 12.01 },
            new Product{CategoryID=1, Name="Product 2", ValidFrom = DateTime.Parse("2005-02-01"), Price = 13.01 },
            new Product{CategoryID=2, Name="Product 3", ValidFrom = DateTime.Parse("2005-03-01"), Price = 14.01 },
            new Product{CategoryID=2, Name="Product 4", ValidFrom = DateTime.Parse("2005-04-01"), Price = 15.01 },
            new Product{CategoryID=3, Name="Product 5", ValidFrom = DateTime.Parse("2005-05-01"), Price = 16.01 },
            new Product{CategoryID=3, Name="Product 6", ValidFrom = DateTime.Parse("2005-06-01"), Price = 17.01 },

            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}