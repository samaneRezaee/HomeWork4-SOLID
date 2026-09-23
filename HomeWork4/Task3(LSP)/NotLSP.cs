using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task3_LSP_
{
    /// <summary>
    /// کلاس فرزند باید بتواند دقیقا همان قراردادی را که کلاس والد وعده داده است را ایفا کند
    /// فرزند نباید ورودی سختگیرانهتری از والد بخواهد. اگر والد هر عددی راقبول میکند، فرزند هم باید همان را قبول کند، نه کمتر
    ///  فرزند نباید نتیجه ی ضعیفتری بدهد. والد قول داده مقدار معتبربرگرداند؛ فرزند موظف است همان را رعایت کند
    ///  ویژگیهایی که در والد همیشه درست بودند، باید در فرزند هم درست بمانند
    /// </summary>
    public class NotLSP
    {
        public class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public int Area() => Width * Height;
        }

        public class Square : Rectangle
        {
            public override int Width
            {
                set { base.Width = base.Height = value; }
            }

            public override int Height
            {
                set { base.Width = base.Height = value; }
            }
        }

        public static void Test(Rectangle r)
        {
            r.Width = 5;
            r.Height = 4;

            // طبق قرارداد مستطیل، باید ۲۰ شود
            Console.WriteLine(r.Area()); // اگر Square پاس بدهی، ۱۶ چاپ میشود
        }

        //public static void Main()
        //{
        //    Test(new Rectangle()); // خروجی: 20 ✔
        //    Test(new Square());    // خروجی: 16 ← نقض LSP
        //}
    }  
}
