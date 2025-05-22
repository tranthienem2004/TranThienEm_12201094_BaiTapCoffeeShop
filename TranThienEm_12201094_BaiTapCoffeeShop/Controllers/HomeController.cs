using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TranThienEm_12201094_BaiTapCoffeeShop.Models;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Controllers
{
    public class HomeController : Controller
    {

        private IProductRepository ProductRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.ProductRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(ProductRepository.GetTrendingProducts());
        }
        public IActionResult Shop()
        {
            return View(ProductRepository.GetAllProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
