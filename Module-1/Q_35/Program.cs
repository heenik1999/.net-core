using System;

namespace Q_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Printing 10 random numbers");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} -> {1}", i, rand.Next());
        }
    }
}
