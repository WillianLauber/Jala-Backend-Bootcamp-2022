using Microsoft.EntityFrameworkCore;
using Shop.API.Models;

namespace Shop.API.Repository
{

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Wear - Men" },
                new Category { Id = 2, Name = "Active Wear - Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" });


            modelBuilder.Entity<Stock>().HasData(
                new Stock { Id = 1, productId = 1, amount = 10 },
                new Stock { Id = 2, productId = 2, amount = 10 },
                new Stock { Id = 3, productId = 3, amount = 10 },
                new Stock { Id = 4, productId = 4, amount = 10 },
                new Stock { Id = 5, productId = 5, amount = 10 },
                new Stock { Id = 6, productId = 6, amount = 10 },
                new Stock { Id = 7, productId = 7, amount = 10 },
                new Stock { Id = 8, productId = 8, amount = 10 },
                new Stock { Id = 9, productId = 9, amount = 10 },
                new Stock { Id = 10, productId = 10, amount = 10 },
                new Stock { Id = 11, productId = 11, amount = 10 },
                new Stock { Id = 12, productId = 12, amount = 10 },
                new Stock { Id = 13, productId = 13, amount = 10 },
                new Stock { Id = 14, productId = 14, amount = 10 },
                new Stock { Id = 15, productId = 15, amount = 10 },
                new Stock { Id = 16, productId = 16, amount = 10 },
                new Stock { Id = 17, productId = 17, amount = 10 },
                new Stock { Id = 18, productId = 18, amount = 10 },
                new Stock { Id = 19, productId = 19, amount = 10 },
                new Stock { Id = 20, productId = 20, amount = 10 },
                new Stock { Id = 21, productId = 21, amount = 10 },
                new Stock { Id = 22, productId = 22, amount = 10 },
                new Stock { Id = 23, productId = 23, amount = 10 },
                new Stock { Id = 24, productId = 24, amount = 10 },
                new Stock { Id = 25, productId = 25, amount = 10 },
                new Stock { Id = 26, productId = 26, amount = 10 },
                new Stock { Id = 27, productId = 27, amount = 10 },
                new Stock { Id = 28, productId = 28, amount = 10 },
                new Stock { Id = 29, productId = 29, amount = 10 },
                new Stock { Id = 30, productId = 30, amount = 10 },
                new Stock { Id = 31, productId = 31, amount = 10 },
                new Stock { Id = 32, productId = 32, amount = 10 },
                new Stock { Id = 33, productId = 33, amount = 10 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Grunge Skater Jeans", Sku = "AWMGSJ", Price = 68 },
                new Product { Id = 2, CategoryId = 1, Name = "Polo Shirt", Sku = "AWMPS", Price = 35 },
                new Product { Id = 3, CategoryId = 1, Name = "Skater Graphic T-Shirt", Sku = "AWMSGT", Price = 33 },
                new Product { Id = 4, CategoryId = 1, Name = "Slicker Jacket", Sku = "AWMSJ", Price = 125 },
                new Product { Id = 5, CategoryId = 1, Name = "Thermal Fleece Jacket", Sku = "AWMTFJ", Price = 60 },
                new Product { Id = 6, CategoryId = 1, Name = "Unisex Thermal Vest", Sku = "AWMUTV", Price = 95 },
                new Product { Id = 7, CategoryId = 1, Name = "V-Neck Pullover", Sku = "AWMVNP", Price = 65 },
                new Product { Id = 8, CategoryId = 1, Name = "V-Neck Sweater", Sku = "AWMVNS", Price = 65 },
                new Product { Id = 9, CategoryId = 1, Name = "V-Neck T-Shirt", Sku = "AWMVNT", Price = 17 },
                new Product { Id = 10, CategoryId = 2, Name = "Bamboo Thermal Ski Coat", Sku = "AWWBTSC", Price = 99 },
                new Product { Id = 11, CategoryId = 2, Name = "Cross-Back Training Tank", Sku = "AWWCTT", Price = 0 },
                new Product { Id = 12, CategoryId = 2, Name = "Grunge Skater Jeans", Sku = "AWWGSJ", Price = 68 },
                new Product { Id = 13, CategoryId = 2, Name = "Slicker Jacket", Sku = "AWWSJ", Price = 125 },
                new Product { Id = 14, CategoryId = 2, Name = "Stretchy Dance Pants", Sku = "AWWSDP", Price = 55 },
                new Product { Id = 15, CategoryId = 2, Name = "Ultra-Soft Tank Top", Sku = "AWWUTT", Price = 22 },
                new Product { Id = 16, CategoryId = 2, Name = "Unisex Thermal Vest", Sku = "AWWUTV", Price = 95 },
                new Product { Id = 17, CategoryId = 2, Name = "V-Next T-Shirt", Sku = "AWWVNT", Price = 17 },
                new Product { Id = 18, CategoryId = 3, Name = "Blueberry Mineral Water", Sku = "MWB", Price = 2.8M },
                new Product { Id = 19, CategoryId = 3, Name = "Lemon-Lime Mineral Water", Sku = "MWLL", Price = 2.8M },
                new Product { Id = 20, CategoryId = 3, Name = "Orange Mineral Water", Sku = "MWO", Price = 2.8M },
                new Product { Id = 21, CategoryId = 3, Name = "Peach Mineral Water", Sku = "MWP", Price = 2.8M },
                new Product { Id = 22, CategoryId = 3, Name = "Raspberry Mineral Water", Sku = "MWR", Price = 2.8M },
                new Product { Id = 23, CategoryId = 3, Name = "Strawberry Mineral Water", Sku = "MWS", Price = 2.8M },
                new Product { Id = 24, CategoryId = 4, Name = "In the Kitchen with H+ Sport", Sku = "PITK", Price = 24.99M },
                new Product { Id = 25, CategoryId = 5, Name = "Calcium 400 IU (150 tablets)", Sku = "SC400", Price = 9.99M },
                new Product { Id = 26, CategoryId = 5, Name = "Flaxseed Oil 100 mg (90 capsules)", Sku = "SFO100", Price = 12.49M },
                new Product { Id = 27, CategoryId = 5, Name = "Iron 65 mg (150 caplets)", Sku = "SI65", Price = 13.99M },
                new Product { Id = 28, CategoryId = 5, Name = "Magnesium 250 mg (100 tablets)", Sku = "SM250", Price = 12.49M },
                new Product { Id = 29, CategoryId = 5, Name = "Multi-Vitamin (90 capsules)", Sku = "SMV", Price = 9.99M },
                new Product { Id = 30, CategoryId = 5, Name = "Vitamin A 10,000 IU (125 caplets)", Sku = "SVA", Price = 11.99M },
                new Product { Id = 31, CategoryId = 5, Name = "Vitamin B-Complex (100 caplets)", Sku = "SVB", Price = 12.99M },
                new Product { Id = 32, CategoryId = 5, Name = "Vitamin C 1000 mg (100 tablets)", Sku = "SVC", Price = 9.99M },
                new Product { Id = 33, CategoryId = 5, Name = "Vitamin D3 1000 IU (100 tablets)", Sku = "SVD3", Price = 12.49M });
        }
    }


}