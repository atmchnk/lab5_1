using System;

namespace lab5_1
{
    class Circle : Figure //похідний клас Коло від абстрактного 
    {
        protected double x; //змінна r - радіус
        protected double y; //змінна рі - число
        
        public Circle(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public override void Show() //перевизначення абстрактного методу
        {
            Console.WriteLine("Коло з: радіусом - {0}. Число рі - {1}", x, y);
        }

        public override double P() //перевизначення абстрактного методу
        {
            return 2 * y * x; //P = 2 * pi * r
        }

        public override double S() //перевизначення абстрактного методу
        {
            return y * Math.Pow(x, 2); //S = pi * r^2
        }
    }
}