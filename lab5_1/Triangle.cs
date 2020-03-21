using System;

namespace lab5_1
{
    class Triangle : Circle //похідний клас Трикутник 
    {
        protected double z; //змінна для 3 сторони трикутника
        public Triangle(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public override void Show() //перевизначення абстрактного методу
        {
            Console.WriteLine("Трикутник зі сторонами: а - {0}, b - {1}, c - {2}", x, y, z);
        }

        public override double P() //перевизначення абстрактного методу
        {           
            return  x + y + z; //P = a + b + c
        }

        public override double S() //перевизначення абстрактного методу
        {
            return Math.Sqrt(((x + y + z)/2)*((x + y + z)/2 - x)*((x + y + z) / 2 - y)*((x + y + z) / 2 - z));
                            //p = (a + b + c)/2, де р - півпериметр
                            //S = √p * (p - a) * (p - b) * (p - c)
        }
    }
}