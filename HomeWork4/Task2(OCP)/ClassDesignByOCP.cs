
namespace HomeWork4.Task2_OCP_
{
    /// <summary>
    /// اکنون هر زیرگروه از shape
    /// از طریق چندریختی محاسبه خود را انجام میدهد
    /// این کار کلاس والد را نسبت به توسعه باز میکند زیرا
    /// یک شکل جدید را به راحتی میتوان به برنامه اضافه کرد بدون اینکه
    /// کلاس والد تغییری بکند
    /// </summary>
    public class ClassDesignByOCP
    {
        public abstract class Shape
        {
            public abstract double Area();
        }
        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area()
            {
                return Width * Height;
            }
        }
        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double Area()
            {
                return Radius * Radius * Math.PI;
            }
        }
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
