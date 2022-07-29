using System;

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
        private Random _random;
        private Shop _shop;

        public Customer(Shop shop)
        {
            int maxMoney = 1500;

            _random = new Random();
            _shop = shop;
            _name = (Names)_random.Next(Enum.GetNames(typeof(Names)).Length);
            _money = _random.Next(maxMoney);

            InitializeBasket();

            Console.WriteLine(this);
        }

        public void ShowProducts()
        {
            Console.WriteLine("Корзина покупателя: ");

            _basket.TryGetProductsInfo(out string productsInfo);

            Console.WriteLine(productsInfo);
        }

        public int GetTotalCost() => _basket.GetTotalCost();

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

        private void InitializeBasket()
        {
            _basket = new ShopBasket();

            int productsCount = _random.Next(1, _basket.MaxProductscount);
            int shopPoductsCount = Enum.GetNames(typeof(ProductName)).Length;

            for(int i = 0; i < productsCount; i++)
            {
                ProductName randomProductName = (ProductName)_random.Next(1, shopPoductsCount);
                _basket.TryAddProduct(_shop.GetProduct(randomProductName));
            }
        }
    }
}
