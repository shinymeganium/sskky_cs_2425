using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type three integers to see if they can form a triangle:");
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            string userInput3 = Console.ReadLine();

            // check if the user input is an integer
            if (int.TryParse(userInput1, out int number1) == true && int.TryParse(userInput2, out int number2) == true && int.TryParse(userInput3, out int number3) == true)
            {
                if (number1 < number2 + number3 || number2 < number1 + number3 || number3 < number1 + number2)
                {
                    Console.WriteLine("The numbers can form a triangle.");
                }
                else
                {
                    Console.WriteLine("The numbers can't form a triangle.");
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid.");
            }
        }
    }
}
