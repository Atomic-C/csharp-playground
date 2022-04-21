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
            // Member method calls

            int staticResult = StaticCalculator.Multiply(4, 4);
            Console.WriteLine(staticResult); // We're calling the stored result from the class method

            Console.WriteLine(StaticCalculator.Multiply(5, 5)); // We're printing to the console directly from the class method

            // Instance method calls

            StaticCalculator staticCalculator = new StaticCalculator();
            int instanceResult = staticCalculator.Sum(4, 10);

            Console.WriteLine(instanceResult); // We're calling the stored result from the instance method

            Console.WriteLine(staticCalculator.Sum(4, 4)); // We're printing directly to the console from instance method
        }
    }
}
