using TranThienEm_12201094_BaiTapCoffeeShop.Data;
using TranThienEm_12201094_BaiTapCoffeeShop.Models;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeeshopDbContext _dbContext;

        public ProductRepository(CoffeeshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _dbContext.Products;
        }

        public Products? GetProductDetail(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Products> GetTrendingProducts()
        {
            return _dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}