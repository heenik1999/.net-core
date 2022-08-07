using System;
using System.Collections.Generic;
namespace Q38
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> stud = new Dictionary<string, object>();

            stud.Add("Name", "Nikhilesh");
            stud.Add("Age", 22);
            stud.Add("Location", "Ahmedabad");

            foreach (var item in stud)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
    }
}
