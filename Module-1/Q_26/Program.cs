using System;
using System.Linq;
namespace Q_26
{
    class student
    {
        int rollno;

        internal void getRollno()
        {
            Console.Write("Enter Roll no: ");
            rollno = Convert.ToInt32(Console.ReadLine());
        }
    }
    class test : student
    {
        const int iterationCount = 2;
        public int[] marks = new int[iterationCount];


        public void getMarks()
        {
            getRollno();
            for (int a = 0; a < iterationCount; a++)
            {
                Console.Write("Enter marks subject  " + (a + 1) + " : ");
                marks[a] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class result : test
    {

        internal void myResult()
        {
            getMarks();
           
            Console.WriteLine("Total marks: " +marks.Sum());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            result r1 = new result();

            r1.myResult();
            Console.Read();
        }
    }
}