using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    class Inference
    {
       public static void Execute()
        {
            var name = "Pedro"; // We infere the variable type with var on assignment
            // nome = 123; cannot do this since it's already infered

            Console.WriteLine(name);

            // var age; 
            // age = 29; implicit variables must be initialized first 
            int age;
            var age2 = 29;
            Console.WriteLine(age2);

            int a; // declaration
            a = 12; // initialization
            int b = 1; // declare and initialize

            Console.WriteLine(a + b);
        }
    }
}
