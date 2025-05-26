using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht10Laskin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This is a simple calculator.");
            Console.WriteLine("Please input two numbers:");
            Console.WriteLine("Number 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Number 2:");
            string input2 = Console.ReadLine();
            double num1, num2 = 0;

            if (double.TryParse(input1, out num1) && double.TryParse(input2, out num2))
            {
                Console.WriteLine("Which operation would you like to do?");
                Console.WriteLine("1: Addition,");
                Console.WriteLine("2: Subtraction,");
                Console.WriteLine("3: Multiplication or");
                Console.WriteLine("4: Division?");

                int userInput = int.Parse(Console.ReadLine()); // at this point it's assumed that the user gives a right input (no more error checks)
                double answer = 0;

                switch (userInput)
                {
                    case 1: 
                        answer = num1 + num2;
                        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + answer);
                        break;
                    case 2:
                        answer = num1 - num2;
                        Console.WriteLine("The subtraction of " + num1 + " and " + num2 + " is: " + answer);
                        break;
                    case 3:
                        answer = num1 * num2;
                        Console.WriteLine(num1 + " times  " + num2 + " is: " + answer);
                        break;
                    case 4:
                        answer = num1 / num2;
                        Console.WriteLine(num1 + " divided by " + num2 + " is: " + answer);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
