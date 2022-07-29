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
            _products = new List<Product>
            {
                new Product(ProductName.Bread, 60),
                new Product(ProductName.Sugar, 120),
                new Product(ProductName.Oil, 160),
                new Product(ProductName.Beer, 135),
                new Product(ProductName.Limon, 25),
                new Product(ProductName.Coffie, 700),
                new Product(ProductName.Tea, 350),
                new Product(ProductName.Potato, 40),
                new Product(ProductName.Tomato, 80),
                new Product(ProductName.Onion, 65),
                new Product(ProductName.Apple, 85),
                new Product(ProductName.Banana, 125),
                new Product(ProductName.Milk, 115),
                new Product(ProductName.Eggs, 75),
                new Product(ProductName.Water, 50)
            };
        }
    }
}