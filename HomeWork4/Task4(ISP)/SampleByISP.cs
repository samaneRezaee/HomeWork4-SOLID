using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task4_ISP_
{
    /// <summary>
    /// چطور اصلاح شده؟
    /// هر کلاس فقط رابط‌هایی را پیاده‌سازی می‌کند که واقعاً به وظایف آن مربوط است. 
    /// </summary>
    internal class SampleByISP
    {
        // رابط تخصصی برای کارهای عملیاتی
        public interface IWorkable
        {
            void Work();
        }

        // رابط تخصصی برای مدیریت
        public interface IManageable
        {
            void Manage();
        }

        // رابط تخصصی برای آموزش دادن
        public interface ITrainable
        {
            void Train();
        }

        // رابط تخصصی برای دریافت حقوق
        public interface IPayable
        {
            void GetPaid();
        }

        // کلاس کارگر فقط رابط‌های مورد نیازش را پیاده‌سازی می‌کند
        public class Employee : IWorkable, IPayable // فقط کارهای مربوط به خودش را پیاده‌سازی می‌کند
        {
            public void Work()
            {
                Console.WriteLine("Employee is working...");
            }

            public void GetPaid()
            {
                Console.WriteLine("Employee is getting paid.");
            }
        }

        // کلاس مدیر تمام رابط‌های مربوطه را پیاده‌سازی می‌کند
        public class Manager : IWorkable, IManageable, ITrainable, IPayable
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

        // کارآموز فقط نیاز به کار کردن و حقوق گرفتن دارد
        public class Intern : IWorkable, IPayable
        {
            public void Work()
            {
                Console.WriteLine("Intern is working...");
            }

            public void GetPaid()
            {
                Console.WriteLine("Intern is getting paid.");
            }
        }

    }
}
