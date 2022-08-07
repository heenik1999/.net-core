using System;

namespace Q_13
{
    public class My_Family
    {
        public void mem()
        {
            Console.WriteLine("\nTotal Number Of Family Member : 4");
        }
    }
    public class My_Fmember : My_Family
    {
        public new void mem()
        {
            base.mem();
            Console.WriteLine("\nName : Narsinh , Age : 54\n" +
                              "\nName : Sunita  , Age : 46\n" +
                              "\nName : Sweta   , Age : 24\n" +
                              "\nName : Nikhil  , Age : 22");
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
