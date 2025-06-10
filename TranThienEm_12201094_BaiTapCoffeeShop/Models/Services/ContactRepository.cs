﻿using TranThienEm_12201094_BaiTapCoffeeShop.Data;
using TranThienEm_12201094_BaiTapCoffeeShop.Models.Interfaces;

namespace TranThienEm_12201094_BaiTapCoffeeShop.Models.Services
{


    public class ContactRepository : IContactRepository
    {
        private readonly CoffeeshopDbContext _context;
        private IContactRepository _contactRepository;
        public ContactRepository(CoffeeshopDbContext context)
        {
            this._context = context;
            _contactRepository = this;
        }

        public void AddMessage(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message), "Contact cannot be null");
            }
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
    }
}
