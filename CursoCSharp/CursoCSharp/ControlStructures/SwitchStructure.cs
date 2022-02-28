using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class SwitchStructure
    {
        public static void Execute()
        {
            Console.WriteLine("Avalie o meu atendimento com nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int grade);

            switch (grade)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Mau.");
                    break;
                case 3:
                    Console.WriteLine("Normal.");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    //{
                        Console.WriteLine("Ótimo!");
                        Console.WriteLine("É continuar!");
                        break;
                    //} 
                default:
                    Console.WriteLine("Nota inválida!");
                    break;
            }

            Console.WriteLine("Fim!");
        }
    }
}
