using System;

namespace CursoCSharp.MethodsAndClasses
{
    public class Constructors
    {
        /// <summary>This class contains two different ways to declare a constructor, two different ways to build an object.
        /// <para>Standard constructor is given implicitly if we do not declare it.</para>
        /// <para>Customized constructor can be used and if we wish to use without any parameters we declare the standard constructor.</para>
        /// <para>We also have a third way to use the constructor with brackets. Looks cool.</para>
        /// </summary>
        class Car
        {

            public string Model;
            public string Manufactor;
            public int Year;

            public Car(string model, string manufactor, int year) // If we use this constructor, we lose the standard constructor
            {
                Model = model;
                Manufactor = manufactor;
                Year = year;
            }

            public Car()
            // We must explicitly declare the standard constructor to use it if we customized it before. This is like method overloading?
            {

            }
        }

        public static void Execute()
        {
            var car1 = new Car(); // This uses the standard constructor, we declare variables after object instantiation.
            car1.Manufactor = "Toyota";
            car1.Model = "Corolla";
            car1.Year = 2021;
            Console.WriteLine($"{car1.Manufactor} {car1.Model} {car1.Year}");

            Car car2 = new Car("Defender", "Land Rover", 1960); // Here we pass arguments since we customized the constructor.
            Console.WriteLine($"{car2.Manufactor} {car2.Model} {car2.Year}");

            Car car3 = new Car() // This is a new way pass variables without a customized constructor, it uses the standard constructor.
            {
                Manufactor = "Fiat",
                Model = "Uno",
                Year = 2019
            };
            Console.WriteLine($"{car3.Manufactor} {car3.Model} {car3.Year}");
        }
    }
}
