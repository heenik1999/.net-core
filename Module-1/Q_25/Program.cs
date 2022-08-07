using System;
using System.Linq;

namespace Q_25
{
    class person
    {
        string name;
        int age;

        internal void getData()
        {
            Console.Write("Enter name:");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
    class student : person
    {
        const int iterationCount = 3;
        internal int[] marks = new int[iterationCount];

        internal void calculate()
        {
            getData();
            for (int a = 0; a < iterationCount; a++)
            {
                Console.Write("Enter Marks Of Sub" + (a + 1) + " :");
                marks[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total marks are: " + marks.Sum());
        }
    }
    class teacher : person
    {
        const int iterationCount = 2;
        public int[] salary = new int[iterationCount];

        internal void total_salary()
        {
            for (int b = 0; b < iterationCount; b++)
            {
                Console.Write("Enter salary " + (b + 1) + " :");
                salary[b] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Total salary is: " + salary.Sum());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            teacher t = new teacher();
            s.calculate();
            t.total_salary();
            Console.Read();
        }
    }
}
