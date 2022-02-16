using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    class VariablesAndConstants
    {
        public static void Execute()
        {
            // Circumference área
            double radius = 12;
            const double PI = 3.14;

            radius = 6;
            // PI = 3.1415;


            double area = PI * radius * radius;

            Console.WriteLine("A área é " + area );

                
            // Internal types
            bool isRaining = true;
            Console.WriteLine("Está chovendo " + isRaining);

            byte age = 29; // 8 bits
            Console.WriteLine("Idade é " + age);

            sbyte saldo = sbyte.MinValue;
            Console.WriteLine("Saldo é " + saldo);

            short salary = short.MaxValue;
            Console.WriteLine("Salário é " + salary);

            int minIntValue = int.MinValue;
            Console.WriteLine("Minímo valor de int é " + minIntValue); // This is the most used for numbers.

            uint portuguesePopulation = 12_000_000;
            Console.WriteLine("População portuguesa é: " + portuguesePopulation);

            long smallestLong = long.MinValue;
            Console.WriteLine("Menor valor long é " + smallestLong);

            ulong worldPopulation = 7_000_000_000;
            Console.WriteLine("População mundial é " + worldPopulation);

            float computerPrice = 1499.99f; // literal values of type float must be explicitely sufixxed with f\F
            // type double holds double float value.
            Console.WriteLine("Preço do computador é " + computerPrice);

            double appleMarketValue = 10000000000000000000;
            Console.WriteLine("Valor da apple é " + appleMarketValue);

            decimal starDistance = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas é " + starDistance);

            char letter = 'c';
            Console.WriteLine("Letra é " + letter);

            string text = "C# é fantástico!";
            Console.WriteLine(text);
        } 

    }
}
