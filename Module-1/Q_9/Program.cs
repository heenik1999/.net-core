using System;

namespace Q_9
{
    class student
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            double rn, math, sic, eng, total, per;
            string name;
            Console.WriteLine("Calculate The Total Marks Of Three Subject \n----------------------------------------------");
            Console.Write("Enter The Roll Number Of The Student : ");
            rn = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter The Name Of Student : ");
            name = Console.ReadLine();
            Console.Write("\nEnter The Marks Of Math : ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter The Marks Of Sic : ");
            sic = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter The Marks Of Eng : ");
            eng = Convert.ToInt32(Console.ReadLine());

            total = math + sic + eng;

            per = total / 3;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Roll No : {0}\n\nName Of Student : {1}\n", rn, name);
            Console.WriteLine("Marks In Math : {0}\n\nMarks In Sic : {1}\n\nMarks In Eng : {2}\n", math, sic, eng);
            Console.WriteLine("Total Marks : {0}\n\nAvg Per :{1}\n", total, per);
        }
    }
}