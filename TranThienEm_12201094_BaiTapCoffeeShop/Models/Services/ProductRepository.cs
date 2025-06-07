using TranThienEm_12201094_BaiTapCoffeeShop.Data;
using TranThienEm_12201094_BaiTapCoffeeShop.Models;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private CoffeeshopDbContext dbContext;
        public ProductRepository(CoffeeshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Products? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Products> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}