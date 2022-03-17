using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MethodsAndClasses
{
    class Person
    {
        public string Name;
        public int Age;

        public void IntroductionOnConsole()
        {
             Console.WriteLine($"{Name} is {Age} years old.");
        }

        public string Introduction()
        {
            return string.Format($"{Name} is {Age} years old.");
        }
    }
}
