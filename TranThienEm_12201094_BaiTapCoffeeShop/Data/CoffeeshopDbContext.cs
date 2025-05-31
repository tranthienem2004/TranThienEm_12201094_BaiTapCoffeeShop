﻿
using Microsoft.EntityFrameworkCore;
using TranThienEm_12201094_BaiTapCoffeeShop.Models;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    Id = 1,
                    Name = "America",
                    Price = 25,
                    Detail = "Name Products",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                },
                new Products
                {
                    Id = 2,
                    Name = "Vietnam",
                    Price = 20,
                    Detail = "Vietnamese Product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                },
                new Products
                {
                    Id = 3,
                    Name = "United Kingdom",
                    Price = 15,
                    Detail = "UK Product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                },
                new Products
                {
                    Id = 4,
                    Name = "India",
                    Price = 15,
                    Detail = "India Product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                },
                new Products
                {
                    Id = 5,
                    Name = "Russian",
                    Price = 25,
                    Detail = "Russian Product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                },
                new Products
                {
                    Id = 6,
                    Name = "France",
                    Price = 35,
                    Detail = "France Product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                }
            );
        }
    }
}