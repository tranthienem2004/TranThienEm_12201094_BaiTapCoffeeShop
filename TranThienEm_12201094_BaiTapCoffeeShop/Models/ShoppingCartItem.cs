﻿namespace TranThienEm_12201094_BaiTapCoffeeShop.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public Products? Products { get; set; }

        public int Qty { get; set; }

        public String? ShoppingCartId { get; set; }

    }
}
