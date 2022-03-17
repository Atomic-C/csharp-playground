using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class UsingContinue
    {
        public static void Execute() 
        {
            int interval = 30;

            Console.WriteLine($"Números pares entre 0 e {interval} inclusive");

            for (int i = 0; i <= interval; i++)
            {
                if (i % 2 == 1) // If remainder is 1, it's odd.
                {
                    continue; // Jump this number
                }
                Console.WriteLine($"{i} "); // Print anything else that isn't odd :)
            }
        }
    }
}
