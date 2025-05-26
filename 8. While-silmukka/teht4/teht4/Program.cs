using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4 // 8.4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guess = 0;
            int answer = random.Next(1, 101);
            Console.WriteLine("Guess the number.");

            while (guess != answer)
            {
                guess = int.Parse(Console.ReadLine());

                //if (guess == answer)
                //{
                //    Console.WriteLine("Your guess was correct! The number was " + answer + "!");
                //    break;
                //}

                if (guess > answer)
                {
                    Console.WriteLine("The number you guessed is too big.");
                }
                else if (guess < answer)
                {
                    Console.WriteLine("The number you guessed is too small.");
                }
                else
                {
                    Console.WriteLine("Your guess was correct! The number was " + answer + "!");
                    break;
                }
            }
        }
    }
}
