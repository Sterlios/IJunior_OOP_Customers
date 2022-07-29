using System;
using System.Collections.Generic;

namespace Customers
{
    class ShopBasket
    {
        private List<Product> _products;
        private Random _random;
        private Shop _shop;

        public ShopBasket(Shop shop)
        {
            _random = new Random();
            _shop = shop;

            InitializeProducts();
        }

        public List<Product> GetProductsList()
        {
            List<Product> productsNames = new List<Product>();

            foreach (Product product in _products)
            {
                productsNames.Add(new Product(product));
            }

            return productsNames;
        }

        public void DeleteRandomProduct()
        {
            int productIndex = _random.Next(_products.Count - 1);

            Console.WriteLine("Из корзины удален: " + _products[productIndex]);

            _products.RemoveAt(productIndex);
        }

        private void InitializeProducts()
        {
            int maxProductCount = 20;
            int productCount = _random.Next(1, maxProductCount);
            int shopPoductCount = Enum.GetNames(typeof(ProductName)).Length;

            _products = new List<Product>();

            for(int i = 0; i < productCount; i++)
            {
                ProductName randomProductName = (ProductName)_random.Next(1, shopPoductCount);
                _products.Add(_shop.GetProduct(randomProductName));
            }
        }
    }
}
