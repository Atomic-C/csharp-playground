using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class LogicalOperators
    {
        public static void Execute()
        {
            // OR

            var executedWork1 = true;
            var executedWork2 = false;

            var boughtTv50In = executedWork1 && executedWork2;
            Console.WriteLine($"Comprou TV 50 polegadas? {boughtTv50In}");

            var boughtIceCream = executedWork1 || executedWork2;
            Console.WriteLine($"Comprou gelado? {boughtIceCream}");

            var boughtTv32In = executedWork1 ^ executedWork2; // This is XOR! It is only true if one is true and another is false.
            Console.WriteLine($"Comprou TV 32 polegadas? {boughtTv32In}");

            Console.WriteLine($"Mais saudável? {!boughtIceCream}"); // Here we see an unary operator! As it only works in one operand.
            // Other operators that work in two operands are binary operators.
        }
    }
}
