namespace Customers
{
    class Program
    {
        static void Main()
        {
            Seller seller = new Seller(new Shop());

            seller.Work();
        }
    }
}
