using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MethodsAndClasses
{
    class Members
    {
        public static void Execute() 
        {
            Person person = new Person();
            person.Name = "Pedro";
            person.Age = 29;

            //Console.WriteLine($"{person.Name} is {person.age} years old.");

            person.IntroductionOnConsole();

            Console.WriteLine(person.Introduction());
        }
    }
}
