using System;

namespace Q_13
{
    public class My_Family
    {
        public void mem()
        {
            Console.WriteLine("Total Number Of Family Member : 4");
        }
    }
    public class My_Fmember : My_Family
    {
        public new void mem()
        {
            base.mem();
            Console.WriteLine("Name : Narsinh , Age : 54\n" +
                              "Name : Sunita  , Age : 46\n" +
                              "Name : Sweta   , Age : 24\n" +
                              "Name : Nikhil  , Age : 22");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            My_Fmember m = new My_Fmember();
            m.mem();
        }
    }
}
