using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task4_ISP_
{
    /// <summary>
    /// این اصل بیان می‌کند که: «هیچ کلاینتی نباید مجبور شود متدهایی را پیاده‌سازی کند که از آن‌ها استفاده نمی‌کند.» به عبارت دیگر،
    /// رابط‌های (Interfaces) بزرگ و جامع نباید وجود داشته باشند؛ 
    /// بلکه باید رابط‌های کوچک‌تر و تخصصی‌تری ایجاد کرد که هر کدام فقط مجموعه‌ای از متدهای مرتبط را تعریف کنند.
    /// چرا نباید کلاس‌ها مجبور به پیاده‌سازی متدهایی شوند که از آن‌ها استفاده نمی‌کنند؟
    /// کاهش پیچیدگی: وقتی کلاسی فقط متدهایی را پیاده‌سازی می‌کند که واقعاً نیاز دارد، کد خواناتر و قابل فهم‌تر می‌شود
    /// افزایش انعطاف‌پذیری: تغییر در یک رابط بزرگ می‌تواند ناخواسته بر روی کلاس‌های زیادی تأثیر بگذارد، حتی اگر آن کلاس‌ها فقط
    /// از بخش کوچکی از رابط استفاده کنند. با داشتن رابط‌های کوچک، تغییرات محدودتر و کنترل‌شده‌تر خواهند بود.
    /// جلوگیری از خطاهای ناخواسته: کلاس مجبور می‌شود متدهای غیرضروری را با پیاده‌سازی‌های خالی (مثلاً پرتاب یک استثنا) یا بی‌معنی پر کند که این خود می‌تواند منجر به باگ‌های پنهان شود
    /// این اصل هم‌راستا با SRP است که می‌گوید هر کلاس باید فقط یک مسئولیت داشته باشد.
    /// وقتی کلاسی مجبور به پیاده‌سازی متدهای نامربوط است، مسئولیت‌های زیادی به آن تحمیل می‌شود.
    /// </summary>
    public class NoISP
    {
        // رابط بزرگ و جامع که اصل ISP را نقض می‌کند
        public interface IWorker
        {
            void Work(); // کار کردن (برای همه)
            void Manage(); // مدیریت کردن (فقط برای مدیر)
            void Train(); // آموزش دادن (فقط برای مدیر یا کارمند ارشد)
            void GetPaid(); // حقوق گرفتن (برای همه)
        }

        // کلاس کارگر که از متد Manage و Train استفاده نمی‌کند
        public class Employee : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Employee is working...");
            }

            public void Manage()
            {
                // کارگر نمی‌تواند مدیریت کند! چه باید کرد؟
                throw new NotImplementedException("Worker cannot manage.");
            }

            public void Train()
            {
                // کارگر خودش هم نیاز به آموزش دارد، نه آموزش دادن!
                throw new NotImplementedException("Worker cannot train others.");
            }

            public void GetPaid()
            {
                Console.WriteLine("Employee is getting paid.");
            }
        }

        // کلاس مدیر که همه متدها را استفاده می‌کند
        public class Manager : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Manager is working...");
            }

            public void Manage()
            {
                Console.WriteLine("Manager is managing the team.");
            }

            public void Train()
            {
                Console.WriteLine("Manager is training a new employee.");
            }

            public void GetPaid()
            {
                Console.WriteLine("Manager is getting paid.");
            }
        }

    }
}
