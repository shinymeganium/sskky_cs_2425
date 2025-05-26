using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type three different integers: ");
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            string userInput3 = Console.ReadLine();

            // check if the user input is an integer
            if (int.TryParse(userInput1, out int number1) == true && int.TryParse(userInput2, out int number2) == true && int.TryParse(userInput3, out int number3) == true)
            {
                Console.WriteLine("Your numbers were: " + number1 + ", " + number2 + " and " + number3);

                if (number1 > number2 && number1 > number3) 
                {
                    Console.WriteLine(number1 + " is the largest number.");
                }
                else if (number2 > number1 && number2 > number3)
                {
                    Console.WriteLine(number2 + " is the largest number.");
                }
                else if (number3 > number1 && number3 > number2)
                {
                    Console.WriteLine(number3 + " is the largest number.");
                }
                else
                {
                    Console.WriteLine("Please type three different numbers, your numbers were: " + number1 + ", " + number2 + " and " + number3 + ".");
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid.");
            }
        }
    }
}
