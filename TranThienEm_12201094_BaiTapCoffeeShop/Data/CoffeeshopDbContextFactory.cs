using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TranThienEm_12201094_BaiTapCoffeeShop.Data;

namespace CoffeeShop.Data
{
    public class CoffeeshopDbContextFactory : IDesignTimeDbContextFactory<CoffeeshopDbContext>
    {
        public CoffeeshopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoffeeshopDbContext>();

            optionsBuilder.UseSqlServer("Server=TRANTHIENEM;Database=CoffeeShopDb;Trusted_Connection=true;TrustServerCertificate=true;");

            return new CoffeeshopDbContext(optionsBuilder.Options);
        }
    }
}
