using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type an integer: ");
            string userInput = Console.ReadLine();

            // check if the user input is an integer
            if (int.TryParse(userInput, out int number) == true)
            {
                if (number > 0)
                {
                    Console.WriteLine("The number " + number + " is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number " + number + " is negative.");
                }
                else
                {
                    Console.WriteLine("The number is 0.");
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid.");
            }
        }
    }
}