using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class UsingBreak
    {
        public static void Execute() 
        {
            Random random = new Random();
            int number = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {number}");

            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"{i} é o número que queremos?");

                if (i == number)
                {
                    Console.WriteLine("Sim.");
                    break; // We use break because we want to stop iterating after we've found our match.
                }
                else
                {
                    Console.WriteLine("Não.");
                }
            }
            Console.WriteLine("Parece que encontrou o seu número.");
        }
    }
}
