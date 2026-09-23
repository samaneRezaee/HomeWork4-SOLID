

using HomeWork4.Task7_Store_.Interfaces;

namespace HomeWork4.Task7_Store_.Implementations
{
    public class Product : IProduct
    {
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
