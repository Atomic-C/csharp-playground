using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class FormattingNumbers
    {
        public static void Execute()
        {
            double value = 16.555;
            Console.WriteLine(value.ToString("F1")); // One decimal
            Console.WriteLine(value.ToString("C")); // Currency
            Console.WriteLine(value.ToString("P")); // Percentage
            Console.WriteLine(value.ToString("#.##")); // A number with two decimal, we format it as we want here

            CultureInfo culture = new CultureInfo("en-US"); // We can use thos to define a culture  
            Console.WriteLine(value.ToString("C2", culture)); // C0 means no decimal, C1 means 1, C2 means 2 and so on.

            int wholeNumber = 256;
            Console.WriteLine(wholeNumber.ToString("D6"));
        }
    }
}
