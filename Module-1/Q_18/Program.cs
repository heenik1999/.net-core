using System;

namespace Q_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Nikhil For Nikhil";
            Console.WriteLine("Oldstring : " + str);
            Console.WriteLine("Newstring : " + str.Replace('l', 's'));
            Console.WriteLine("\nOLdstring :" + str);
            Console.WriteLine("Newstring :" + str.Replace('i',' '));
        }
    }
}
