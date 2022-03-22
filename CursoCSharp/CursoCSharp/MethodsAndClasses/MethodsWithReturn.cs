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
        public static void Execute()
        {
            var calculator = new CommonCalculator();
            var resultSum = calculator.Sum(2,2);
            var resultSub = calculator.Subtract(2,2);
            System.Console.WriteLine(resultSum);
            System.Console.WriteLine(resultSub);
            System.Console.WriteLine(calculator.Multiply(2,2));
        }
    }
}
