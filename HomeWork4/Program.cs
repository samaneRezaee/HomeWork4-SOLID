using HomeWork4.Task7_Store_.Implementations;
using HomeWork4.Task7_Store_.Module;

namespace HomeWork4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var discount = new PercentageDiscount(10); // 10% تخفیف
            var fixedDiscount = new FixedAmountDiscount(200);//200$ تخفیف
            var notifier = new EmailNotification();

            var order = new Order(discount, notifier);
            var orderFixed= new Order(fixedDiscount, notifier);

            order.AddProduct(new Product("Television", 1000));
            order.AddProduct(new Product("Computer", 2000));
            orderFixed.AddProduct(new Product("Ruge", 950));

            order.Checkout();
            orderFixed.Checkout();
        }
    }
}
