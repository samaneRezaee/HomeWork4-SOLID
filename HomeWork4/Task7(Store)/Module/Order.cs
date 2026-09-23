

using HomeWork4.Task7_Store_.Interfaces;

namespace HomeWork4.Task7_Store_.Module
{
    public class Order
    {
        private readonly IDiscountStrategy _discount;
        private readonly INotificationService _notifier;
        private readonly List<IProduct> _items = new List<IProduct>();

   
        public Order(IDiscountStrategy discount, INotificationService notifier)
        {
            _discount = discount;
            _notifier = notifier;
        }

        public void AddProduct(IProduct product) => _items.Add(product);

        public void Checkout()
        {
            decimal total = 0;
            foreach (var item in _items) total += item.Price;

            decimal finalPrice = _discount.ApplyDiscount(total);

            Console.WriteLine($"Total: {total}, Final Price: {finalPrice}");
            _notifier.Send("Invoice sent to customer.");
        }
    }
}
