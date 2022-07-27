using System;
using System.Collections.Generic;
using System.Text;

namespace Customers
{
    class Product
    {
        public string Name { get; }
        public uint Price { get; }

        public Product(string name, uint price)
        {
            Name = name;
            Price = price;
        }
    }
}
