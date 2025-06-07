namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetOrdersByEmail(string email);
        void PlaceOrder(Order order);
    }
}
