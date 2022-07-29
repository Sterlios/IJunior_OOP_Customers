using System;
using System.Collections.Generic;

namespace Customers
{
    class Seller
    {
        private Customer _currentCustomer;
        private List<Product> _clientProducts;
        private Shop _shop;

        public Seller(Shop shop)
        {
            _shop = shop;
        }

        public void Work()
        {
            Console.WriteLine("Продавец начал работать");

            CustomersQueue customers = new CustomersQueue(_shop);
            Console.WriteLine();

            while (customers.GetCustomer(out _currentCustomer))
            {
                Console.WriteLine("Текущий клиент: " + _currentCustomer);

                MakeDeal();

                Console.WriteLine("Клиент совершил покупку: " + _currentCustomer);
                Console.ReadLine();
            }

            Console.WriteLine("Продавец закончил работать");
        }

        private void GetCustomerProducts()
        {
            _clientProducts = _currentCustomer.GetProductsList();

            Console.WriteLine("Корзина клинета: ");
            foreach (Product product in _clientProducts)
            {
                Console.WriteLine(product);
            }
        }

        private void MakeDeal()
        {
            GetCustomerProducts();

            int totalCost = GetTotalCost();

            if (_currentCustomer.TryBuy(totalCost) == false)
            {
                MakeDeal();
            }
        }

        private int GetTotalCost()
        {
            int totalCost = 0;

            foreach (Product product in _clientProducts)
            {
                totalCost += product.Price;
            }

            Console.WriteLine("Итоговая стоимость товаров: " + totalCost);
            Console.ReadLine();

            return totalCost;
        }
    }
}
