

namespace HomeWork4.Task1_SRP_
{
    /// <summary>
    /// به جای یک کلاس، ۴ کلاس تعریف کردیم یعنی برای هر مسوولیت کلاس
    /// این تغییر، پیاده‌سازی، فهم و تست کد را ساده‌تر میکند
    /// </summary>
    public class ExampleClassBySRP
    {
        public class OrderService
        {
            public string CreateOrder(string OrderDetails)
            {
                string OrderId = "";
                //Code to Create Order
                return OrderId;
            }
        }

        public class PaymentService
        {
            public bool MakePayment(string PaymentDetails)
            {
                //Code to Make Payment
                return true;
            }
        }

        public class InvoiceService
        {
            public bool GenerateInvoice(string InvoiceDetails)
            {
                //Code to Generate Invoice
                return true;
            }
        }

        public class EmailService
        {
            public bool EmailInvoice(string EmailDetails)
            {
                //Code to Email Invoice
                return true;
            }
        }
    }
}
