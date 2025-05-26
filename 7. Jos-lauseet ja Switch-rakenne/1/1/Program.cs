using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
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
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number " + number + " is even.");
                }
                else
                {
                    Console.WriteLine("The number " + number + " is odd.");
                }
            }
            else {
                Console.WriteLine("Your input is invalid.");
            }
        }
    }
}
