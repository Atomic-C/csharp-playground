using System;

namespace CursoCSharp.MethodsAndClasses
{
    public class StaticMethods
    {
        public class StaticCalculator
        {
            // Class method below
            public static int Multiply(int a, int b)
            {
                return a * b;
            }
            // Instance method below
            public int Sum(int a, int b)
            {
                return a + b;
            }
        }
        public static void Execute()
        {
            Console.WriteLine(StaticCalculator.Multiply(2, 2));

            StaticCalculator staticCalculator = new StaticCalculator();
            Console.WriteLine(staticCalculator.Sum(4, 4));
        }
    }
}
