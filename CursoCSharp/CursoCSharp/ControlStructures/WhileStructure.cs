using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStructures
{
    public class WhileStructure
    {
        public static void Execute()
        {
            int guess = 0;
            Random random = new Random();

            int randomNumber = random.Next(1,11);
            bool guessedNumber = false;
            int attemptsLeft = 5;
            int attempts = 0;

            while (attemptsLeft > 0 && !guessedNumber)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entry = Console.ReadLine();
                int.TryParse(entry, out guess);
                attempts++;
                attemptsLeft--;

                if (guess == randomNumber)
                {
                    guessedNumber = true;
                    var previousColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em {attempts}tentativas! ");
                    Console.BackgroundColor = previousColor;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Mais abaixo...");
                    Console.WriteLine($"Restam {attemptsLeft}tentativas.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Mais acima...");
                    Console.WriteLine($"Restam {attemptsLeft}tentativas.");
                }
            }
        }
    }
}
