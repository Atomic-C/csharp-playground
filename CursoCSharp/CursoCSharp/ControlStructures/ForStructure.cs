using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class ForStructure
    {
        public static void Execute()
        {
            // We can mimick same for behavior with a while loop
            //int counter = 0;

            //while (counter <= 10)
            //{
            //    Console.WriteLine($"O valor de counter é {counter}.");
            //    counter++;
            //}

            // we can mimick the sabe behavior with a for loop
            //for (int counter = 0; counter <= 10; counter++)
            //{
            //    Console.WriteLine($"O valor de counter é {counter}.");
            //}

            double sum = 0;
            string entry;

            Console.WriteLine("Informe o tamanho da turma: ");
            entry = Console.ReadLine();
            int.TryParse(entry, out int classSize);

            for (int i = 1; i <= classSize; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {i}: ");
                entry = Console.ReadLine();
                double.TryParse(entry, out double actualGrade);

                sum = +actualGrade;
            }
                double average = classSize > 0 ? sum / classSize : 0;
                Console.WriteLine($"A média da turma é: {average}");
        }
    }
}
