namespace Solid_4S
{
    using System;

    /*Даний інтерфейс поганий тим, що він включає занадто багато методів.
     А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
     якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
    розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
    Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
    Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
    які реалізують притаманні їм інтерфейси.*/

    interface IItem
    {
        void SetPrice(double price);
    }

    interface IDiscountable : IItem
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
    }

    interface IClothes : IItem
    {
        void SetColor(byte color);
        void SetSize(byte size);
    }

    class Book : IDiscountable
    {
        public void SetPrice(double price)
        {
            // ...
        }

        public void ApplyDiscount(string discount)
        {
            // ...
        }

        public void ApplyPromocode(string promocode)
        {
            // ...
        }
    }

    class Outerwear : IClothes, IDiscountable
    {
        public void SetPrice(double price)
        {
            // ...
        }

        public void SetColor(byte color)
        {
            // ...
        }

        public void SetSize(byte size)
        {
            // ...
        }

        public void ApplyDiscount(string discount)
        {
            // ...
        }

        public void ApplyPromocode(string promocode)
        {
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
       
            Console.ReadKey();
        }
    }
}