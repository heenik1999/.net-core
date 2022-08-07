using System;

namespace Q_28
{
    public partial class A
    {
        private int a;
        private string str;
        internal void getData()
        {
            Console.Write("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the string: ");
            str = Console.ReadLine();

        }
    }
    public partial class A
    {
        internal void display()
        {
            Console.WriteLine("The value of a is: " + a);
            Console.WriteLine("The string is: " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.getData();
            a.display();
            Console.Read();
        }
    }
}
