using System;

namespace Q_12
{
    class calculate
    {
        public void area(double r)
        {
            Console.WriteLine("Area Of Circel : {0}", 3.14 * r * r);
        }
        public void area(int l, int b)
        {
            Console.WriteLine("\nArea Of Rectangel : {0}", l * b);
        }
        public void area(double b, double h)
        {
            Console.WriteLine("\nArea Of Triangel : {0}", b * h / 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculate c = new calculate();
            c.area(2.5);
            c.area(15, 15);
            c.area(20, 20);
        }
    }
}
