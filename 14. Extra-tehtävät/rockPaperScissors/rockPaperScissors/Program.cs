using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            Console.WriteLine("Let's play Rock, Paper, Scissors!");

            while (keepPlaying == true)
            {
                Random random = new Random();
                int computerChoise = random.Next(1, 4);
                Console.WriteLine("Give your option (r/p/s):");
                string player = Console.ReadLine();
                string computersChoise = ComputersMove(computerChoise);

                if (player == "r" || player == "p" || player == "s")
                    keepPlaying = PlayGame(player, computersChoise);
                else
                    Console.WriteLine("Please give a right choise (r or p or s).");
            }
        }

        static string ComputersMove(int x)
        {
            string option;

            if (x == 1)
                option = "r";
            else if (x == 2)
                option = "p";
            else if (x == 3)
                option = "s";
            else
                option = "something went wrong";

            return option;
        }

        static bool PlayGame(string p, string c)
        {
            bool continuePlaying = false;
            if (p == "r")
            {
                if (c == "r")
                {
                    Console.WriteLine("Your move: rock.");
                    Console.WriteLine("Computer's move: rock.");
                    Console.WriteLine("It's a tie.");
                }
                else if (c == "p")
                {
                    Console.WriteLine("Your move: rock.");
                    Console.WriteLine("Computer's move: paper.");
                    Console.WriteLine("You lose!");
                }
                else if (c == "s")
                {
                    Console.WriteLine("Your move: rock.");
                    Console.WriteLine("Computer's move: scissors.");
                    Console.WriteLine("You win!");
                }
            }
            else if (p == "p")
            {
                if (c == "r")
                {
                    Console.WriteLine("Your move: paper.");
                    Console.WriteLine("Computer's move: rock.");
                    Console.WriteLine("You win!");
                }
                else if (c == "p")
                {
                    Console.WriteLine("Your move: paper.");
                    Console.WriteLine("Computer's move: paper.");
                    Console.WriteLine("It's a tie.");
                }
                else if (c == "s")
                {
                    Console.WriteLine("Your move: paper.");
                    Console.WriteLine("Computer's move: scissors.");
                    Console.WriteLine("You lose!");
                }
            }
            else if (p == "s")
            {
                if (c == "r")
                {
                    Console.WriteLine("Your move: scissors.");
                    Console.WriteLine("Computer's move: rock.");
                    Console.WriteLine("You lose!");
                }
                else if (c == "p")
                {
                    Console.WriteLine("Your move: scissors.");
                    Console.WriteLine("Computer's move: paper.");
                    Console.WriteLine("You win!");
                }
                else if (c == "s")
                {
                    Console.WriteLine("Your move: scissors.");
                    Console.WriteLine("Computer's move: scissors.");
                    Console.WriteLine("It's a tie.");
                }
            }

            Console.WriteLine("Would you like to continue? y/n");
            string continueGame = Console.ReadLine();

            
            if (continueGame == "y")
                continuePlaying = true;
            else if (continueGame == "n")
                continuePlaying = false;
            else
                Console.WriteLine("Wrong input, closing game.");

            return continuePlaying;
        }
    }
}
