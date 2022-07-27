using System;
using System.Collections.Generic;
using System.Text;

namespace Customers
{
    class Inventory
    {
        private List<Product> _products;

        public Inventory()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Product GetProduct(string productName)
        {
            foreach(Product product in _products)
            {
                if (product.Name == productName)
                {
                    _products.Remove(product);
                    return product;
                }
            }

            return null;
        }
    }
}
