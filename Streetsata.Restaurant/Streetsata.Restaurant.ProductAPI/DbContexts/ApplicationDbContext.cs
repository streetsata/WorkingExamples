using Microsoft.EntityFrameworkCore;
using Streetsata.Restaurant.ProductAPI.Models;

namespace Streetsata.Restaurant.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Goods1",
                Price = 15,
                Description = "Description Goods1",
                ImageUrl = "https://csb100320029377c138.blob.core.windows.net/streetsata1restaurant/photo_2022-09-14_15-37-57.jpg",
                CategoryName = "Category1",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Goods2",
                Price = 13.99,
                Description = "Description Goods2",
                ImageUrl = "https://csb100320029377c138.blob.core.windows.net/streetsata1restaurant/photo_2022-09-14_15-37-58.jpg",
                CategoryName = "Category1",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Goods3",
                Price = 10.99,
                Description = "Description Goods3",
                ImageUrl = "https://csb100320029377c138.blob.core.windows.net/streetsata1restaurant/photo_2022-09-14_15-37-59.jpg",
                CategoryName = "Category2",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Goods4",
                Price = 15,
                Description = "Description Goods4",
                ImageUrl = "https://csb100320029377c138.blob.core.windows.net/streetsata1restaurant/photo_2022-09-14_15-38-00.jpg",
                CategoryName = "Category3",
            });
        }
    }
}
