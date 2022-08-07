using System;

namespace Q_39
{
    class Student<Type1, Type2>
    {
        Type1 Rollnumber;
        Type2 name;

        public Student(Type1 i, Type2 n)
        {

            Rollnumber = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine("Student Roll Number is: " + Rollnumber);
            Console.WriteLine("Student Name is: " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student<int, string> obj = new Student<int, string>(4, "Nikhilesh");
            obj.display();
        }
    }
}
