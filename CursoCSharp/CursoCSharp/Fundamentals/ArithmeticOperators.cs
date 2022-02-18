using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class ArithmeticOperators
    {
        public static void Execute()
        {
            // Discount price
            var price = 1000.0;
            var tax = 355;
            var discount = 0.1;

            double total = price + tax;
            var totalWithDiscount = total - (total * discount);
            Console.WriteLine($"O preço final é: {totalWithDiscount}");

            // IMC
            double weight = 70.4;
            double height = 1.70;
            double imc = weight / Math.Pow(height, 2); // Pow is same as (height * height)
            Console.WriteLine($"O IMC É: {imc}");

            // Odd or Even
            int even = 24;
            int odd = 55;
            Console.WriteLine($"{even} / 2 has remainder of {even % 2}"); // 0 for even
            Console.WriteLine($"{odd} / 2 has a remainder of {odd % 2}"); // anything other than 0 is odd
        }
    }
}
