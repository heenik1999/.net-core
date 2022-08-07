using System;

namespace Q_11
{
    class cal
    {
        int a, b, c;
        public void input()

        {
            Console.Write("Enter First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");

        }
        public void asmd()
        {
            c = a + b;
            Console.WriteLine("Addition Is : {0}", c);
            c = a - b;
            Console.WriteLine("\nSubtraction Is :{0}", c);
            c = a * b;
            Console.WriteLine("\nMultiplication Is :{0}", c);
            c = a / b;
            Console.WriteLine("\nDivision Is :{0}", c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cal c = new cal();
            c.input();
            c.asmd();
        }
    }
}
