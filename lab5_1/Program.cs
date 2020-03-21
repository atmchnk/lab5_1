using System;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Figure[] Fig = new Figure[3];
            //масив посилань заповнення масиву посиланнями на об'єкти похідних класів
            Fig[0] = new Circle(4, 3.1416);
            Fig[1] = new Triangle(5, 6, 7);
            Fig[2] = new Rectangle(2, 5);
            foreach (Figure a in Fig) //перегляд масиву
            {
                a.Show();
                Console.Write("Периметр фігури: {0:f2}\n", a.P());
                Console.WriteLine("Площа фігури: {0:f2}\n", a.S());
            }
        }
    }
}