using System;
using System.Collections.Generic;

namespace Customers
{
    class Seller
    {
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

            while (customers.TryGetCustomer(out Customer currentCustomer))
            {
                Console.WriteLine("Текущий клиент: " + currentCustomer);

                MakeDeal(currentCustomer);

                Console.WriteLine("Клиент совершил покупку: " + currentCustomer);
                Console.ReadLine();
            }

            Console.WriteLine("Продавец закончил работать");
        }

        private void MakeDeal(Customer currentCustomer)
        {
            currentCustomer.ShowProducts();

            int totalCost = currentCustomer.GetTotalCost();
            Console.WriteLine("Итоговая стоимость товаров: " + totalCost);
            Console.ReadLine();

            if (currentCustomer.TryBuy(totalCost) == false)
            {
                MakeDeal(currentCustomer);
            }
        }
    }
}
