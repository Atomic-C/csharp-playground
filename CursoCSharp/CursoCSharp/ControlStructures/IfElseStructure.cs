using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class IfElseStructure
    {
        public static void Execute()
        {
            double grade = 7.0;
            if (grade >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que a sua obrigação!");
            }
            else
            {
                Console.WriteLine("Recuperação!");
            }
        }
    }
}
