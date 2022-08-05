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
            double rn,math,sic,eng,total,avg;
            string name;
            Console.WriteLine("Calculate The Total Marks Of Three Subject \n----------------------------------------------");
            Console.WriteLine("Enter The Roll Number Of The Student :");
            rn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Name Of Student : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter The Marks Of Math : ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks Of Sic : ");
            sic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks Of Eng : ");
            eng = Convert.ToInt32(Console.ReadLine());

            total = math + sic + eng;

            avg = total / 3;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Roll No : {0}\nName Of Student : {1}", rn, name);
            Console.WriteLine("Marks In Math : {0}\nMarks In Sic : {1}\nMarks In Eng : {2}", math, sic, eng);
            Console.WriteLine("Total Marks : {0}\nAvg Marks :{1} ", total,avg); 
        }
    }
}