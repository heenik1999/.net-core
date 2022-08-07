using System;
using System.Linq;

namespace Q_24
{
    class cricketer
    {
        const int iterationCount = 4;
        public int[] run = new int[iterationCount];
        public void getdata()
        {
            for (int a = 0; a < iterationCount; a++)
            {
                Console.WriteLine("Enter Run Of Match "+(a+1)+":");
                run[a] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class batsmen : cricketer
    {
        public void calculate()
        {
            getdata();


            Console.WriteLine("Total Run Are : " + run.Sum()); 


            Console.WriteLine("Average Run Are : " + run.Average());

            Console.WriteLine("Best Perfomance Is : " + run.Max());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            batsmen b = new batsmen();
            b.calculate();
        }
    }
}
