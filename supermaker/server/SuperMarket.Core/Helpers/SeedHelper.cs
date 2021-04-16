

using System.Threading.Tasks;
using Supermarket.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Supermarket.Core.Helpers
{
    public static class SeedHelper
    {
        public static async Task SeedCategories(DataContext context)
        {
            if (await context.Categories.AnyAsync())
            {
                return;
            }


            await context.Categories.AddAsync(new Category { Name = "Phone" });
            await context.Categories.AddAsync(new Category { Name = "Tivi" });
            await context.SaveChangesAsync();
        }

        public static async Task SeedProducts(DataContext context)
        {
            if (await context.Products.AnyAsync())
            {
                return;
            }
            await context.Products.AddAsync(new Product 
            { 
                Name = "Tomato",
                CategoryId = 1,
                Description = "A very good fruit",
                Price = 5,
                ImageUrl = "This a image"
            });

            await context.Products.AddAsync(new Product 
            { 
                Name = "Onion",
                CategoryId = 2,
                Description = "A very good fruit",
                Price = 5,
                ImageUrl = "This a image"
            });
            await context.SaveChangesAsync();
        }

    }
}