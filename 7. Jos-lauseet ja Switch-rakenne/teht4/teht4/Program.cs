using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your age: ");
            string userInput = Console.ReadLine();
            
            // check if the user input is an integer
            if (double.TryParse(userInput, out double number) == true)
            {
                if (number >= 0 && number < 2)
                {
                    Console.WriteLine("You are an infant.");
                }
                else if (number >= 2 && number < 5)
                {
                    Console.WriteLine("You are a toddler.");
                }
                else if (number >= 5 && number < 13)
                {
                    Console.WriteLine("You are a child.");
                }
                else if (number >= 13 && number <= 19)
                {
                    Console.WriteLine("You are a teen.");
                }
                else if (number > 19 && number <= 39)
                {
                    Console.WriteLine("You are an adult.");
                }
                else if (number >= 40 && number <= 59)
                {
                    Console.WriteLine("You are a middle aged adult.");
                }
                else if (number >= 60 && number < 100)
                {
                    Console.WriteLine("You are a senior adult.");
                }
                else if(number >= 100)
                {
                    Console.WriteLine("Wow you are really being " + number + " years old!");
                }
                else
                {
                    Console.WriteLine("Your age can't be negative.");
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid.");
            }
        }
    }
}
