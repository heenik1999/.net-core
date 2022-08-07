using System;

namespace Q_36
{
    class Student
    {
        int Rollnumber;
        string Name;

        public Student()
        {
            Console.Write("Enter Student Roll Number : ");
            Rollnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student name: ");
            Name = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Student Roll Number is: " + Rollnumber);
            Console.WriteLine("Student name is: " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Read();
        }
    }
}
