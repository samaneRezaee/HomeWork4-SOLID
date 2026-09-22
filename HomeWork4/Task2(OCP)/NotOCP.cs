using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task2_OPC_
{
    /// <summary>
    /// OCP:
    /// این اصل میگوید هر موجودیت نرم‌افزاری مثل کلاس،ماژول یا تابع
    /// باید برای گسترش باز و برای تغییر بسته باشد. یعنی وقتی میخواهیم قابلیت
    /// جدیدی اضافه کنیم نباید کد موجود را دست بزنیم، بلکه باید بتوانیم رفتار
    /// جدید را با افزودن کد، به برنامه اضافه کنیم
    /// در مثال زیر این اصل رعایت نشده
    /// اگر بخواهیم محیط شکلی دیگر مثلا مثلث را هم حساب کنیم 
    /// باید کد موجود را تغییر دهیم
    /// </summary>
    public class NotOCP
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }
            return area;
        }
        public class AreaCalculator
        {
            public double Area(Rectangle[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    area += shape.Width * shape.Height;
                }
                return area;
            }
        }
    }
}
