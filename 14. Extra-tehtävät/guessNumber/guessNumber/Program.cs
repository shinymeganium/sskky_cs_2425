using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool guessed = false;
            int guesses = 0;
            Random random = new Random();
            int number = random.Next(10000);

            Console.WriteLine("Guess the number between 1 and 10 000.");

            while (guessed != true)
            {

                string guess = Console.ReadLine();

                if (int.TryParse(guess, out int result))
                {
                    if (result > number)
                    {
                        Console.WriteLine($"The number {guess} is too big. Guess a lower number.\n");
                        guesses++;
                    }
                    else if (result < number)
                    {
                        Console.WriteLine($"Your guess {guess} is too small. Guess a higher number.\n");
                        guesses++;
                    }
                    else
                    {
                        Console.WriteLine($"Your answer {guess} was correct! The right number is {number}.");
                        guesses++;
                        Console.WriteLine($"It took {guesses} tries to get the number right.");
                        guessed = true;
                    }
                }
                else
                    Console.WriteLine("Invalid input. The guess didn't count.");
            }
        }
    }
}
