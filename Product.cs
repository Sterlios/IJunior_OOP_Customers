namespace Customers
{
    enum ProductName
    {
        Bread,
        Sugar,
        Oil,
        Limon,
        Beer,
        Coffie,
        Tea,
        Water,
        Potato,
        Tomato,
        Onion,
        Apple,
        Banana,
        Milk,
        Eggs
    }

    class Product
    {
        public ProductName Name { get; }
        public int Price { get; }

        public Product(ProductName name, int price)
        {
            Name = name;
            Price = price;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
        }

        public override string ToString()
        {
            return Name + " Цена: " + Price;
        }
    }
}
