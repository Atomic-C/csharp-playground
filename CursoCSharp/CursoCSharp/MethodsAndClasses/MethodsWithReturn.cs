namespace CursoCSharp.MethodsAndClasses
{
    public class MethodsWithReturn
    {
        public class CommonCalculator
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }
            public int Subtract(int c, int d)
            {
                return c - d;
            }
            public int Multiply(int c, int d)
            {
                return c * d;
            }
        }

        class ChainCalculator
        {
            int memory;

            public ChainCalculator Sum(int a)
            {
                memory += a;
                return this; // This means the method returns the object itself, and it's methods!
            }
            public ChainCalculator Sub(int a)
            {
                memory -= a;
                return this; // Instance and it's methods
            }
            public ChainCalculator Multiply(int a)
            {
                memory *= a;
                return this; // Instance and it's methods
            }
            public ChainCalculator Print() 
            {
                System.Console.WriteLine(memory);
                return this; // Instance and it's methods
            }
            public ChainCalculator Clear()
            {
                memory = 0;
                return this; // Instance and it's methods
            }
            public int Result()
            {
                return memory; // Actual "memory" of type int variable and it's methods
            }
        }
        public static void Execute()
        {
            var calculator = new CommonCalculator();
            var resultSum = calculator.Sum(2,2);
            var resultSub = calculator.Subtract(2,2);
            System.Console.WriteLine(resultSum);
            System.Console.WriteLine(resultSub);
            System.Console.WriteLine(calculator.Multiply(2,2));

            ChainCalculator chainedCalculator = new ChainCalculator();

            System.Console.WriteLine("Testing ChainedCalculator's Sum method:");
            chainedCalculator.Sum(100).Sum(50).Print().Clear().Print().Sum(5).Sum(5).Print();
            System.Console.WriteLine("Testing ChainedCalculator's Sub method:");
            chainedCalculator.Clear().Sum(10).Sub(5).Print();
            System.Console.WriteLine("Testing ChainedCalculator's Multiply method:");
            chainedCalculator.Clear().Sum(50).Multiply(25).Print();
            System.Console.WriteLine("Testing ChainedCalculator's Result method:");
            System.Console.WriteLine(chainedCalculator.Result());
        }
    }
}
