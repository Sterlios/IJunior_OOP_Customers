using System;
using System.Collections.Generic;

namespace Customers
{
    class ShopBasket
    {
        private List<Product> _products;
        private Random _random;
        public int MaxProductscount { get; }

        public ShopBasket()
        {
            _random = new Random();
            _products = new List<Product>();
            MaxProductscount = 20;
        }

        public bool TryGetProductsInfo(out string productsInfo)
        {
            productsInfo = "";

            if(_products.Count > 0)
            {
                foreach (Product product in _products)
                {
                    productsInfo += product + "\n";
                }

                return true;
            }
            else
            {
                productsInfo = "Корзина пуста!";
                return false;
            }
        }

        public int GetTotalCost()
        {
            int totalCost = 0;

            foreach (Product product in _products)
            {
                totalCost += product.Price;
            }

            return totalCost;
        }

        public void DeleteRandomProduct()
        {
            int productIndex = _random.Next(_products.Count - 1);

            Console.WriteLine("Из корзины удален: " + _products[productIndex]);

            _products.RemoveAt(productIndex);
        }

        public bool TryAddProduct(Product product)
        {
            if(_products.Count < MaxProductscount)
            {
                _products.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
