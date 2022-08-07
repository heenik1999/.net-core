using System;

namespace Q_27
{
    class my
    {
        public int a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            my m = new my();
            Console.Write("Enter Value Of A : ");
            m.a = Convert.ToInt32(Console.ReadLine());
            int A = m.a;
            Console.WriteLine("The Value Of A is : " + A);
            Console.Read();
        }
    }
}
