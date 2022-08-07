using System;

namespace Q_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, nu, fac = 1;
            Console.WriteLine("Enter Any Number : ");
            nu = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= nu; i++)
                fac *= i;
            {
                Console.WriteLine("factorial Of " + nu + " Is : {0}", fac);
            }

        }
    }
}
