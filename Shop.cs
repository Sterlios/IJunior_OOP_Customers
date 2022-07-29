using System.Collections.Generic;

namespace Customers
{
    class Shop
    {
        private List<Product> _products;

        public Shop()
        {
            InitializeProducts();
        }

        public Product GetProduct(ProductName productName)
        {
            foreach(Product product in _products)
            {
                if(product.Name == productName)
                {
                    return new Product(product);
                }
            }

            return null;
        }

        private void InitializeProducts()
        {
            _products = new List<Product>();

            _products.Add(new Product(ProductName.Bread, 60));
            _products.Add(new Product(ProductName.Sugar, 120));
            _products.Add(new Product(ProductName.Oil, 160));
            _products.Add(new Product(ProductName.Beer, 135));
            _products.Add(new Product(ProductName.Limon, 25));
            _products.Add(new Product(ProductName.Coffie, 700));
            _products.Add(new Product(ProductName.Tea, 350));
            _products.Add(new Product(ProductName.Potato, 40));
            _products.Add(new Product(ProductName.Tomato, 80));
            _products.Add(new Product(ProductName.Onion, 65));
            _products.Add(new Product(ProductName.Apple, 85));
            _products.Add(new Product(ProductName.Banana, 125));
            _products.Add(new Product(ProductName.Milk, 115));
            _products.Add(new Product(ProductName.Eggs, 75));
            _products.Add(new Product(ProductName.Water, 50));
        }
    }
}