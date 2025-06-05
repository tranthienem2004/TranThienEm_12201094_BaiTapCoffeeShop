﻿namespace TranThienEm_12201094_BaiTapCoffeeShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public Products? Products { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
