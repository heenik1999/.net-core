using System;

namespace NIk
{
    class Program
    {
        public static string Reverse(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string reversedstring = string.Empty;

            for(int i=charArray.Length -1;i>-1;i++)
            {
                reversedstring += charArray[i];
            }
            return reversedstring;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Nikhil"));
        }
    }
}
