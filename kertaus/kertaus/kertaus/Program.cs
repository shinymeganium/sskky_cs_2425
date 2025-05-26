using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kertaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Random random1 = new Random();
            //Random random2 = new Random();
            //int dice1 = random1.Next(1, 7);
            //int dice2 = random2.Next(1, 7);

            //if (dice1 == dice2)
            //{
            //    Console.WriteLine($"Dice 1 rolled {dice1} and dice 2 rolled {dice2}");
            //    Console.WriteLine("They are the same number");

            //    if (dice1 == 1)
            //        Console.WriteLine("Snake eyes!");
            //}
            //else
            //{
            //    Console.WriteLine($"Dice 1 rolled {dice1} and dice 2 rolled {dice2}");
            //    Console.WriteLine("They are not the same number");
            //}

            //// 2
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}! Let's do some counting.");
            //Random random3 = new Random();
            //Random random4 = new Random();
            //int num1, num2;
            //bool guessRight = true;
            //int rounds = 0;
            //int guess;
            //do
            //{
            //    num1 = random3.Next(1, 16);
            //    num2 = random4.Next(1, 16);
            //    Console.WriteLine($"What is {num1} times {num2}?");
            //    guess = int.Parse(Console.ReadLine());

            //    if (guess == num1 * num2)
            //    {
            //        Console.WriteLine($"You answered {guess}. It is correct!");
            //        rounds++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Your answer is {guess}. It is wrong!");
            //        guessRight = false;
            //    }

            //}
            //while (guessRight && rounds <= 10);

            //DateTime date = DateTime.Now;
            //string filePath = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\16. Omat\kertaus\highscores.txt";
            //string score = $"Name: {name}\nScore: {rounds} right\nDate: {date}\n";
            //File.AppendAllText(filePath, score);

            //Console.WriteLine($"Your score of {rounds} right was saved.");

            // 3
            Random random = new Random();
            bool keepPlaying = true;

            Console.WriteLine("Let's play rock, paper, scissors!");

            do
            {
                Console.WriteLine("What is your move? (r/p/s)");
                string guess = Console.ReadLine();
                int compRoll = random.Next(1, 4);

                if (guess == "r" || guess == "p" || guess == "s")
                {
                    switch (compRoll)
                    {
                        case 1:
                            Rock(guess);
                            break;
                        case 2:
                            Paper(guess);
                            break;
                        case 3:
                            Scissors(guess);
                            break;
                        default:
                            Console.WriteLine("Invalid value.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
                //keep playing
                Console.WriteLine("Do you want to keep playing? (y/n)");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "n")
                {
                    if (answer == "n")
                        keepPlaying = false;
                }
                else
                {
                    Console.WriteLine("Wrong input. Closing program.");
                    keepPlaying = false;
                }
            }
            while (keepPlaying);
        } // main close bracket

        static void Rock(string option)
        {
            if (option == "r")
            {
                Console.WriteLine("You played rock.");
                Console.WriteLine("Computer played rock.");
                Console.WriteLine("It's a tie!");
            }
            else if (option == "p")
            {
                Console.WriteLine("You played paper.");
                Console.WriteLine("Computer played rock.");
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You played scissors.");
                Console.WriteLine("Computer played rock.");
                Console.WriteLine("You lost!");
            }
        }

        static void Paper(string option)
        {
            if (option == "r")
            {
                Console.WriteLine("You played rock.");
                Console.WriteLine("Computer played paper.");
                Console.WriteLine("You lost!");
            }
            else if (option == "p")
            {
                Console.WriteLine("You played paper.");
                Console.WriteLine("Computer played paper.");
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("You played scissors.");
                Console.WriteLine("Computer played paper.");
                Console.WriteLine("You won!");
            }
        }

        static void Scissors(string option)
        {
            if (option == "r")
            {
                Console.WriteLine("You played rock.");
                Console.WriteLine("Computer played scissors.");
                Console.WriteLine("You won!");
            }
            else if (option == "p")
            {
                Console.WriteLine("You played paper.");
                Console.WriteLine("Computer played scissors.");
                Console.WriteLine("You lost!");
            }
            else
            {
                Console.WriteLine("You played scissors.");
                Console.WriteLine("Computer played scissors.");
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
