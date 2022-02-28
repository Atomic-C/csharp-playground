using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class IfElseIfStructure
    {
        public static void Execute()
        {
            Console.WriteLine("Digite a nota do aluno:");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double grade); // out is explained in later stages.

            if (grade >= 9.0)
            {
                Console.WriteLine("Quadro de honra!");
            }
            else if(grade >= 7.0/* && grade < 9.0*/)
            {
                Console.WriteLine("Aprovado!");
            }
            else if( grade >= 5.0/* && grade < 7.0*/)
            {
                Console.WriteLine("Recuperação!");
            }
            else
            {
                Console.WriteLine("Vejo-te na próxima...");
            }
            Console.WriteLine("Fim");
        }
    }
}
