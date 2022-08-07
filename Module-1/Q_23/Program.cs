using System;

namespace Q_23
{
    interface cal1
    {
        int add(int a, int b);
    }
    interface cal2
    {
        int sub(int a, int b);
    }
    interface cal3
    {
        int mul(int a, int b);
    }
    interface cal4
    {
        int div(int a, int b);
    }
    class calculation : cal1,cal2,cal3,cal4
    {
        public int result1;
        public int add(int a,int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int a,int b)
        {
            return result2 = a - b;
        }
        public int result3;
        public int mul(int a, int b)
        {
            return result3 = a * b;
        }
        public int result4;
        public int div(int a, int b)
        {
            return result4 = a / b;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculation c = new calculation();
            c.add(8, 8);
            c.sub(8, 8);
            c.mul(8, 8);
            c.div(8, 8);
            Console.WriteLine("implement multiple inheritance concept ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Addition : " + c.result1);
            Console.WriteLine("\nSubtraction : " + c.result2);
            Console.WriteLine("\nMultiplication : " + c.result3);
            Console.WriteLine("\nDivision : " + c.result4);
        }
    }
}
