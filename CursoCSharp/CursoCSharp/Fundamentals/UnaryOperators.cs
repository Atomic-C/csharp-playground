using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class UnaryOperators
    {
        public static void Execute()
        {
            var negativeValue = -5;
            var number1 = 2;
            var number2 = 3;
            var boolean = true;

            Console.WriteLine(-negativeValue);
            Console.WriteLine(!boolean);

            number1++;
            Console.WriteLine(number1);

            --number1;
            Console.WriteLine(number1);

            Console.WriteLine(number1++ == --number2);
            Console.WriteLine($"{ number1 }{ number2 }"); // This happens and is equal because postfix++ happens after comparison
        }
    }
}
