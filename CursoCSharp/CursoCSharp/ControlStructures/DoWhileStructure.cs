using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class DoWhileStructure
    {
        public static void Execute()
        {
            string entry;

            do
            {
                Console.WriteLine("Qual é o seu nome?");
                entry = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo {entry}");
                Console.WriteLine("Deseja continuar?");
                entry = Console.ReadLine();

            } while (entry.ToLower() == "s");
        }
    }
}
