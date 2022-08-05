using System;

namespace Q_11
{
    class cal
    {
        int a, b, c;
        public void input()
            
        {
            Console.WriteLine("Enter First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            b = Convert.ToInt32(Console.ReadLine()); 
            
        }
        public void asmd()
        {
            c = a + b;
            Console.WriteLine("Addition Is : {0}", c);
            c = a - b;
            Console.WriteLine("Subtraction Is :{0}", c);
            c = a * b;
            Console.WriteLine("Multiplication Is :{0}", c);
            c = a / b;
            Console.WriteLine("Division Is :{0}", c);
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
