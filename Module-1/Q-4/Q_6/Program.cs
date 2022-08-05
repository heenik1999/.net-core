using System;

namespace Q_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.Write("Enter A Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            for (i = 1; i <= n; i++)
            {
                j = i * i;
                Console.WriteLine("{0}", j);

            }
        }
    }
}
