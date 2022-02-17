using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class ReadingData
    {
        public static void Execute()
        {
            Console.WriteLine("Como se chama?");
            string name = Console.ReadLine();

            Console.WriteLine("Que idade tem?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto recebe de salário?");
            double wage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"{name}{age}{wage}");
        }
    }
}
