using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    class DotNotation
    {
        public static void Execute()
        {
            var salute = "Hey".ToUpper().Insert(3, " World").Replace("HEY", "Hello"); //Hello World. toy with this!

            int age = 29;
            int comparison = age.CompareTo(29); // Compare to tells us if age is bigger, same or less than param with 1, 0 -2 respectively

            Console.WriteLine(salute);
            Console.WriteLine($"Age is: {age}");
            Console.WriteLine(comparison);

            Console.WriteLine("Test".Length);

            string importantValue = null; //
            Console.WriteLine(importantValue?.Length); //comparison? doesn't access comparison while it's null!
        }
    }
}
