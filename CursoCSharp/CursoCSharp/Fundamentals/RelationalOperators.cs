using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class RelationalOperators
    {
        public static void Execute ()
        {
            //double bill = 6.0; // We replace this with a Console.ReadLine() since it's cooler.
            Console.WriteLine("Digite a sua nota aqui: ");
            double.TryParse(Console.ReadLine(), out double bill);
            double billCut = 7.0;

            Console.WriteLine($"Nota inválida? {bill > 10.0}");
            Console.WriteLine($"Nota inválida? {bill < 0.0}");
            Console.WriteLine($"Perfeito? {bill == 0}");
            Console.WriteLine($"Tem como melhorar? {bill != 10.0 }");
            Console.WriteLine($"Passou por média? {bill >= billCut}");
            Console.WriteLine($"Recuperação? {bill < billCut}");
            Console.WriteLine($"Reprovado? {bill <= 3.0}");
        }
    }
}
