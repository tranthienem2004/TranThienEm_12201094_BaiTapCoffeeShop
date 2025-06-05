namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        void AddToCart(Products product);
        void RemoveFromCart(Products product);
        List<ShoppingCartItem> GetAllShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
