using TranThienEm_12201094_BaiTapCoffeeShop.Data;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        private CoffeeshopDbContext dbContext;
        private IShoppingCartRepository shoppingCartRepository;
        public OrderRepository(CoffeeshopDbContext dbContext, IShoppingCartRepository shoppingCartRepository)
        {
            this.dbContext = dbContext;
            this.shoppingCartRepository = shoppingCartRepository;

        }
        public void PlaceOrder(Order order)
        {
            var shoppingCartItems = shoppingCartRepository.GetAllShoppingCartItems();
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Quantity = item.Qty,
                    ProductId = item.Products.Id,
                    Price = item.Products.Price
                };
                order.OrderDetails.Add(orderDetail);

            }
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = shoppingCartRepository.GetShoppingCartTotal();
            dbContext.Order.Add(order);
            dbContext.SaveChanges();
        }
    }
}
