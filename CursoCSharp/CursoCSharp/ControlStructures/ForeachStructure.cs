using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class ForeachStructure
    {
        public static void Execute()
        {
            string word = "Hello!";
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }

            string[] students = new string[] { "Pedro", "Ana", "Harry" };
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

        }
    }
}
