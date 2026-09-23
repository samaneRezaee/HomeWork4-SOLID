

namespace HomeWork4.Task3_LSP_
{
    /// <summary>
    /// هر کلاسی میتواند آنچه را که مدعی آن است را انحام دهد
    /// </summary>
    public class SampleByLSP
    {
        public interface IShape
        {
            int Area();
        }

        public class Rectangle : IShape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int Area() => Width * Height;
        }

        public class Square : IShape
        {
            public int Side { get; set; }
            public int Area() => Side * Side;
        }
        public static void PrintArea(IShape shape)
        {
            Console.WriteLine(shape.Area());
        }
        //public static void Main(string[] args) 
        //{
        //    PrintArea(new Rectangle { Width = 5, Height = 4 }); // 20
        //    PrintArea(new Square { Side = 4 });                // 16
        //}
    }
}
