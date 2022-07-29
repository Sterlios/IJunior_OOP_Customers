using System;
using System.Collections.Generic;

namespace Customers
{
    enum Names
    {
        Mark,
        John,
        Daniel,
        Richard,
        Yang,
        Will,
        Alex,
        Bill,
        Sally
    }

    class Customer
    {
        private int _money;
        private Names _name;
        private ShopBasket _basket;

        public Customer(Shop shop)
        {
            int maxMoney = 1500;
            Random random = new Random();
            
            _name = (Names)random.Next(Enum.GetNames(typeof(Names)).Length);
            _money = random.Next(maxMoney);
            _basket = new ShopBasket(shop);

            Console.WriteLine(this);
        }

        public List<Product> GetProductsList()
        {
            return _basket.GetProductsList();
        }

        public bool TryBuy(int totalCost)
        {
            if(totalCost <= _money)
            {
                _money -= totalCost;
                return true;
            }
            else
            {
                _basket.DeleteRandomProduct();
                return false;
            }
        }

        public override string ToString()
        {
            return _name + " денег: " + _money;
        }
    }
}
