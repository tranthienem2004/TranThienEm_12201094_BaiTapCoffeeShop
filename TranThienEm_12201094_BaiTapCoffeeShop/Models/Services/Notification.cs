﻿namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Services
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
