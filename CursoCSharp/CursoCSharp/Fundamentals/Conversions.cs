using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class Conversions
    {
        public static void Execute()
        {
            int wholeNumber = 10;
            double fractionedNumber = wholeNumber;
            Console.WriteLine($"Exemplo de conversão implícita de int para double {fractionedNumber}");

            double bill = 9.5;
            int truncatedBill = (int)bill;
            Console.WriteLine($"Exemplo de nota truncada(conversão explícita): {truncatedBill}");

            Console.WriteLine("Digite a sua idade:");
            string age = Console.ReadLine();
            int wholeAge = int.Parse(age);
            Console.WriteLine($"Idade inserida é: {wholeAge}");

            wholeAge = Convert.ToInt32(age);
            Console.WriteLine($"Idade inserida(Converted) é: {wholeAge}");


            Console.WriteLine("Digite um número:");
            string word = Console.ReadLine();
            int number;
            int.TryParse(word, out number); // With TryParse we can insert a string and output is zero, no error
            Console.WriteLine($"O número digitado é: {number}");           
            
            
            Console.WriteLine("Digite um segundo número:");
            int.TryParse(Console.ReadLine(), out int number2); // With TryParse we can insert a string and output is zero, no error
            Console.WriteLine($"O número digitado é: {number2}");
        }
    }
}
