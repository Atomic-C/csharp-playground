using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    class Interpolation
    {
        public static void Execute()
        {
            string name = "PC";
            var brand = "AMD"; // Infered string on assignment
            double computerPrice = 1499.99;

            Console.WriteLine("O {0} da marca {1} custa {2}.", name, brand, computerPrice);
            Console.WriteLine($"A marca {brand} é fixe!");
            Console.WriteLine($" 1 + 1 é: {1 + 1}");
        }
    }
}
