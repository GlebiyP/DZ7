using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //Порушено принцип розділення інтерфейсу.
    
    /*interface IItem
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
        void SetColor(byte color);
        void SetSize(byte size);
        void SetPrice(double price);
    }*/

    interface IBook
    {
        void ApplyDiscount(double discount);
        void ApplyPromocode(String promocode);
        void SetPrice(double price);
    }

    interface IOuterwear
    {
        void ApplyDiscount(double discount);
        void SetColor(byte color);
        void SetSize(string size);
        void SetPrice(double price);
    }

    class Book : IBook
    {
        private double _price;

        public void ApplyPromocode(String promocode)
        {
            //Використання промокоду
        }

        public void ApplyDiscount(double discount)
        {
            _price -= (_price * discount / 100);
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public double GetPrice()
        {
            return _price;
        }
    }

    class Outerwear : IOuterwear
    {
        private byte _color;
        private string _size;
        private double _price;

        public void ApplyDiscount(double discount)
        {
            _price -= (_price * discount / 100);
        }

        public void SetColor(byte color)
        {
            _color = color;
        }

        public void SetSize(string size)
        {
            _size = size;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public double GetPrice()
        {
            return _price;
        }

        public string GetSize()
        {
            return _size;
        }

        public byte GetColor()
        {
            return _color;
        }
    }

    class Task4
    {
        public static void OutwearPrintInfo(Outerwear ow)
        {
            Console.WriteLine("Price: {0}. Size: {1}. Color: {2}", ow.GetPrice(), ow.GetSize(), ow.GetColor());
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            book.SetPrice(150);
            Console.WriteLine("Price: {0}", book.GetPrice());
            book.ApplyDiscount(50);
            Console.WriteLine("Price: {0}", book.GetPrice());

            Outerwear outerwear = new Outerwear();
            outerwear.SetPrice(1200);
            outerwear.SetSize("M");
            outerwear.SetColor(133);
            OutwearPrintInfo(outerwear);
            outerwear.ApplyDiscount(30);
            OutwearPrintInfo(outerwear);

            Console.ReadKey();
        }
    }
}
