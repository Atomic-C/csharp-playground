using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class AttributionOperators
    {
        public static void Execute()
        {
            var num1 = 3;
            num1 = 7; 
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 - 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;  
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}");

            // Extra:
            dynamic c = new System.Dynamic.ExpandoObject(); // by value or reference??
            c.name = "Josh";
            dynamic d = c;

            d.name = "Maria";

            Console.WriteLine(c.name);
        }
    }
}
