using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentals
{
    public class TernaryOperator
    {
        public static void Execute()
        {
            var bill = 7.0;
            bool goodBehavior = true;
            string result = bill >= 7.0 && goodBehavior ? "Approvado" : "Reprovado";
            Console.WriteLine(result);
        }
    }
}
