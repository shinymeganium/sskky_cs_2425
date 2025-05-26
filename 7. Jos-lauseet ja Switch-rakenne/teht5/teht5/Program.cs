using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See your score as a grade. Please enter your score:");
            string userInput = Console.ReadLine();

            // check if the user input is an integer
            if (int.TryParse(userInput, out int number) == true)
            {
                if (number >= 0 && number < 65)
                {
                    Console.WriteLine("Your grade is F.");
                }
                else if (number >= 65 && number < 70)
                {
                    Console.WriteLine("Your grade is D.");
                }
                else if (number >= 70 && number < 80)
                {
                    Console.WriteLine("Your grade is C.");
                }
                else if (number >= 80 && number < 90)
                {
                    Console.WriteLine("Your grade is B.");
                }
                else if (number >= 90 && number <= 100)
                {
                    Console.WriteLine("Your grade is A.");
                }
                else
                {
                    Console.WriteLine("Your score is higher than the maximum score of 100.");
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid.");
            }
        }
    }
}
