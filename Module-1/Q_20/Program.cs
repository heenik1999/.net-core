using System;

namespace Q_20
{
    class Student
    {
        public static string F_Name = "Nikhilesh";
        public static string L_Name = "Badgu";
        public static int R_N0 = 91;

        public static void details()
        {
            Console.WriteLine("The Details Of Student Is ↓");
            Console.WriteLine("-------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student.details();

            Console.WriteLine("Student First Name : {0}", Student.F_Name);
            Console.WriteLine("\nStudnet Last Name : {0}", Student.L_Name);
            Console.WriteLine("\nStudent Roll Number : {0}", Student.R_N0);
        }
    }
}
