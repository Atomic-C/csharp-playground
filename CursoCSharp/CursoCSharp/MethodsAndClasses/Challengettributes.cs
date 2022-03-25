using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MethodsAndClasses
{
    public class Challengettributes
    {
        int a = 10;
        public static void Execute() // A method that belongs to the class cannot access an instance attribute
        {
            // How to access an instance attribute from a static method?

            // Access variable a inside the Execute() method!
            Challengettributes challengettributes = new Challengettributes();
            Console.WriteLine(challengettributes.a);
        }
    }
}
