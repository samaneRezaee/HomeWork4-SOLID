

namespace HomeWork4.Task1_SRP_
{
    /// <summary>
    /// SRP:
    /// هر ماژول نرم افزاری یا کلاس باید فقط و فقط یک دلیل برای تغییر داشته باشد
    /// اما در این کلاس چندین مسولیت که هر کدام میتواند سرویس جداگانه‌ای باشد همه یکجا دراین کلاس تعریف شده است
    /// </summary>
    public class ExampleClassWithoutSRP
    {
        public class OrderService
        {
            public string CreateOrder(string OrderDetails)
            {
                string OrderId = "";
                //Code to Create Order
                return OrderId;
            }

            public bool MakePayment(string OrderId)
            {
                //Code to Make Payment
                return true;
            }

            public bool GenerateInvoice(string OrderId)
            {
                //Code to Generate Invoice
                return true;
            }

            public bool EmailInvoice(string OrderId)
            {
                //Code to Email Invoice
                return true;
            }
        }
    }
}
