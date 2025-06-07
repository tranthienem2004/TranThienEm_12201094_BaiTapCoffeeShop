using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Controllers
{
    [Authorize]
    public class ListOrdersController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public ListOrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult ListOrder()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);

            if (email == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var orders = _orderRepository.GetOrdersByEmail(email);

            return View(orders);
        }
    }
}
