namespace CursoCSharp.MethodsAndClasses
{
    public class StaticAttributes
    {
        class Product
        {
            public string Name; // Since none of the attributes are static, each one belongs to an object's instance
            public double Price;
            public static double Discount = 0.1;

            public Product(string name, double price, double discount)
            {
                Name = name;
                Price = price;
                Discount = discount;
            }

            public Product()
            {

            }
            public double CalculateDiscount()
            {
                return Price - (Price * Discount);
            }
        }
        public static void Execute()
        {
            var firstProduct = new Product("Tuna", 3.2, 0.5);
            Product secondProduct = new Product("Spiced Tuna", 0.65, 0.5);

            Product thirdProduct = new Product();
            thirdProduct.Name = "Canned Albacore";
            thirdProduct.Price = 5.0;
            //thirdProduct.Discount = 0.5;

            Product fourthProduct = new Product()
            {
                Name = "Bluefin Tuna",
                Price = 2.40,
                //Discount = 0.05
            };
            Product.Discount = 0.5;

            System.Console.WriteLine($"Price of {firstProduct.Name} is {firstProduct.Price}");
            System.Console.WriteLine($"Price of {secondProduct.Name} is {secondProduct.Price}");
            System.Console.WriteLine($"Price of {thirdProduct.Name} is {thirdProduct.Price}");
            System.Console.WriteLine($"Price of {fourthProduct.Name} is {fourthProduct.Price}");

            System.Console.WriteLine($"Price of {firstProduct.Name} with discount is {firstProduct.CalculateDiscount()}"); 
            System.Console.WriteLine($"Price of {secondProduct.Name} with discount is {secondProduct.CalculateDiscount()}");
            System.Console.WriteLine($"Price of {thirdProduct.Name} with discount is {thirdProduct.CalculateDiscount()}");
            System.Console.WriteLine($"Price of {fourthProduct.Name} with discount is {fourthProduct.CalculateDiscount()}");

            Product.Discount = 0.05;
            System.Console.WriteLine($"Price of {firstProduct.Name} is {firstProduct.Price}");
            System.Console.WriteLine($"Price of {secondProduct.Name} is {secondProduct.Price}");
            System.Console.WriteLine($"Price of {thirdProduct.Name} is {thirdProduct.Price}");
            System.Console.WriteLine($"Price of {fourthProduct.Name} is {fourthProduct.Price}");

            System.Console.WriteLine($"Price of {firstProduct.Name} with discount is {firstProduct.CalculateDiscount()}");
            System.Console.WriteLine($"Price of {secondProduct.Name} with discount is {secondProduct.CalculateDiscount()}");
            System.Console.WriteLine($"Price of {thirdProduct.Name} with discount is {thirdProduct.CalculateDiscount()}");
            System.Console.WriteLine($"Price of {fourthProduct.Name} with discount is {fourthProduct.CalculateDiscount()}");
        }
    }
}
