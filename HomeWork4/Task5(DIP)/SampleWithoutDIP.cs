using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task5_DIP_
{
    /// <summary>
    /// DIP:
    /// ۱. ماژول‌های سطح بالا نباید به ماژول‌های سطح پایین وابسته باشند.هر دو باید به انتزاع‌ها وابسته باشند
    /// ۲.انتزاع‌ها نباید به جزيیات وابسته باشند بلکه جزییات باید به انتزاعات وابسته باشند
    /// چگونه وابستگی کلاس‌ها به جزئیات را کاهش می‌دهد؟
    /// کلاس سطح بالا دیگر نیازی ندارد بداند جزئیات سطح پایین چطور کار می‌کنند یا چه کلاسی قرار است کار را انجام دهد؛ او فقط با واسط  کار دارد.
    /// این کار باعث کاهش اتصال، افزایش قابلیت تست زنی و انعطاف‌پذیری شدید سیستم می‌شود.
    /// اگر روزی لازم باشد حزییات تغییر کند هیچ تغییری در کدهای سطح بالای برنامه ایجاد نمی‌شود.
    /// </summary>
    internal class SampleWithoutDIP
    {
        // ماژول سطح پایین (جزئیات)
        public class EmailSender
        {
            public void SendEmail(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }

        // ماژول سطح بالا که مستقیماً به جزئیات وابسته است (نقض DIP)
        public class OrderManager
        {
            private EmailSender _emailSender;

            public OrderManager()
            {
                // وابستگی سخت‌افزاری و مستقیم با کلیدواژه new (تعهدی به جزئیات)
                _emailSender = new EmailSender();
            }

            public void Checkout()
            {
                // انجام کارهای ثبت سفارش...
                Console.WriteLine("Order processed.");

                // ارسال ایمیل
                _emailSender.SendEmail("Your order has been placed successfully!");
            }
        }

    }
}
