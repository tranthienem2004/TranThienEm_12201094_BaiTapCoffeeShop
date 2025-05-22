using TranThienEm_12201094_BaiTapCoffeeShop.Models;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
        IEnumerable<Products> GetTrendingProducts();
        Products? GetProductDetail(int id);
    }
}