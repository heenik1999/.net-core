using System;

namespace Q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            char[] arr = name.ToCharArray();
            
            Console.WriteLine("Array Before Sorting : \n ");
            foreach (char value in arr)
            {
                Console.Write(value + ",");
            }
            Console.WriteLine("\n");
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Array After Sorting : \n ");
            foreach (char value in arr)
            {
                Console.Write(value + ",");
            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
