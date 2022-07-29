using System;
using System.Collections.Generic;

namespace Customers
{
    class CustomersQueue
    {
        private Queue<Customer> _customers;
        private Random _random;
        private Shop _shop;

        public CustomersQueue(Shop shop)
        {
            _random = new Random();
            _shop = shop;

            Console.WriteLine("Очередь:");
            InitializeQueue();
        }

        public Queue<Customer> GetQueue()
        {
            Queue<Customer> customers = new Queue<Customer>();

            foreach(Customer customer in _customers)
            {
                customers.Enqueue(customer);
            }

            return customers;
        }

        public bool TryGetCustomer(out Customer customer)
        {
            return _customers.TryDequeue(out customer);
        }

        private void InitializeQueue()
        {
            int maxCustomersCount = 10;
            int CustomersCount = _random.Next(1, maxCustomersCount);
            _customers = new Queue<Customer>();

            for (int i = 0; i < CustomersCount; i++)
            {
                _customers.Enqueue(new Customer(_shop));
            }
        }
    }
}
