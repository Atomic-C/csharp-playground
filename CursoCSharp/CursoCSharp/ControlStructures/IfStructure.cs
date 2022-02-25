using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class IfStructure
    {
        public static void Execute()
        {
            bool goodBehavior = false;
            string entry;


                Console.WriteLine("Insira a nota do estudante: ");
                entry = Console.ReadLine();
                double.TryParse(entry, out double grade);

                Console.WriteLine("Tem bom comportamento (S/N): ");
                entry = Console.ReadLine();

                //if (entry == "S" || entry == "s")
                //{
                //    goodBehavior = true;    
                //}

                    goodBehavior = entry.ToLower() == "s";

                if (grade > 9.0 && goodBehavior)
                {
                    Console.WriteLine("Quadro de honra!");
                }            
        }
    }
}
