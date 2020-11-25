using System;

namespace Task3
{
    /*Порушений принцип підстановки Лісков. Для вирішення цієї проблеми створимо інтерфейс IFigure.*/

    interface IFigure
    {
        public int GetArea();
    }
    class Rectangle : IFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }
    //квадрат наслідується від прямокутника!!!
    class Square : IFigure
    {
        public virtual int Side { get; set; }

        public virtual int GetArea()
        {
            return Side * Side;
        }
    }
    class Task3
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 5;
            Console.WriteLine("Rectangle area: {0}", rect.GetArea());

            Square square = new Square();
            square.Side = 10;
            Console.WriteLine("Square area: {0}", square.GetArea());

            Console.ReadKey();
        }
    }
}
