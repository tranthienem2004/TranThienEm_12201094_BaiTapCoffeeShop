using TranThienEm_12201094_BaiTapCoffeeShop.Models;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Products> ProductsList = new List<Products>()
        {
            new Products{ Id = 1, Name = "America", Price= 25, Detail="Name product", ImageUrl="https://index.com" },
            new Products{ Id = 2, Name = "Vietnam", Price= 20, Detail="Vietnamese product", ImageUrl="https://index.com" },
            new Products{ Id = 3, Name = "United Kingdom", Price= 15, Detail="Name product", ImageUrl="https://index.com" }
        };

        public IEnumerable<Products> GetAllProducts()
        {
            return ProductsList;
        }

        public Products? GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Products> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }
    }
}
