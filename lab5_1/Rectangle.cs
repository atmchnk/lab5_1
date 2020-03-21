using System;

namespace lab5_1
{
    class Rectangle : Circle //похідний клас Трикутник
    {
        protected double x2;
        protected double y2;

        public Rectangle(double x2, double y2) : base(x2, y2)
        {
            this.x2 = x2; this.y2 = y2;
        }

        public override void Show() //перевизначення абстрактного методу
        {
            Console.WriteLine("Прямокутник зі сторонами: а - {0}, b - {1}", x2, y2);
        }

        public override double P() //перевизначення абстрактного методу
        {
            return (x2 + y2) * 2; //P = (a + b)/2
        }

        public override double S() //перевизначення абстрактного методу
        {
            return x2 * y2; //S = a * b
        }
    }
}