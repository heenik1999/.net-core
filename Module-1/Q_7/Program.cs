using System;

namespace Q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 1;
            Console.WriteLine("--------------------");
            Console.WriteLine("*Patterns*\n---------------------");
            Console.WriteLine("Pattern (a)↓\n--------------------");
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Pattern (b)↓\n--------------------");
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Pattern (c)↓\n--------------------");
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Pattern (d)↓\n--------------------");
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }

                }
                Console.Write("\n");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Pattern (e)↓\n--------------------");
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", i);
                Console.Write("\n");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Pattern (f)↓\n--------------------");
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", j);
                Console.Write("\n");
            }
        }
    }
}
