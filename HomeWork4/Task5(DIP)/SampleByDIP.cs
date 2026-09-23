

namespace HomeWork4.Task5_DIP_
{
    public class SampleByDIP
    {
        // ۱. ایجاد انتزاع (قرارداد)
        public interface IMessageSender
        {
            void SendMessage(string message);
        }

        // ۲. پیاده‌سازی جزئیات اول (ایمیل)
        public class EmailSender : IMessageSender
        {
            public void SendMessage(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }

        // ۳. پیاده‌سازی جزئیات دوم (پیامک - برای انعطاف‌پذیری بیشتر)
        public class SmsSender : IMessageSender
        {
            public void SendMessage(string message)
            {
                Console.WriteLine($"SMS sent: {message}");
            }
        }

        // ۴. ماژول سطح بالا که اکنون به جای جزئیات، به "انتزاع" وابسته است
        public class OrderManager
        {
            private readonly IMessageSender _messageSender;

            // وابستگی از بیرون تزریق می‌شود (Dependency Injection)
            public OrderManager(IMessageSender messageSender)
            {
                _messageSender = messageSender; // وابسته به Interface است نه کلاس خاص
            }

            public void Checkout()
            {
                Console.WriteLine("Order processed.");

                // ارسال پیام بدون اینکه بداند ایمیل است یا پیامک
                _messageSender.SendMessage("Your order has been placed successfully!");
            }
        }


        //static void Main(string[] args)
        //{
        //    // هر پیاده‌سازی دلخواهی که خواستیم را به سیستم تزریق می‌کنیم
        //    IMessageSender sender = new EmailSender(); // یا new SmsSender();

        //    OrderManager orderManager = new OrderManager(sender);
        //    orderManager.Checkout();
        //}



    }
}
