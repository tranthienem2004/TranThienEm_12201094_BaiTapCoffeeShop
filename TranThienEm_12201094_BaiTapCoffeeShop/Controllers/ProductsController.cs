using Microsoft.AspNetCore.Mvc;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository ProductRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.ProductRepository = productRepository;
        }
        public IActionResult Shop()
        {
            return View(ProductRepository.GetAllProducts());
        }
        public IActionResult Detail(int id)
        {
            var product = ProductRepository.GetProductDetail(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
