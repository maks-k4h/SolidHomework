using System;

namespace Solid_3S
{
    // LSP — змінили ієрархію фігур. Нащадки Shape поводядь себе коректно
    // в контексті використання Shape.
    
    abstract class Shape
    {
        public abstract double GetArea();
    }
    
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double a, double b)
        {
            Width = a;
            Height = b;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
    
    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double a)
        {
            Side = a;
        }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle   = new Rectangle(5, 4);
            var square      = new Square(5);

            // використовуємо нащадків Shape
            Console.WriteLine("Rectangle");
            ShowArea(rectangle);
            Console.WriteLine("Square");
            ShowArea(square);

            rectangle.Height    = 8;
            rectangle.Width     = 10;
            square.Side         = 11;
            
            Console.WriteLine("Rectangle");
            ShowArea(rectangle);
            Console.WriteLine("Square");
            ShowArea(square);
        }

        private static void ShowArea(Shape shape)
        {
            Console.WriteLine("The shape's area: " + shape.GetArea());
        }
    }
}