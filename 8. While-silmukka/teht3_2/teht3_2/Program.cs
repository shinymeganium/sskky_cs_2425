using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("Please type two numbers.");
            

            while (num1 >= 0 && num2 >= 0)
            {
                Console.WriteLine("Number 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Number 2: ");
                num2 = double.Parse(Console.ReadLine());

                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("You typed a negative number, program closes.");
                    break;
                }
                double num3 = num1 + num2;

                Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + num3);

                num1 = 0;
                num2 = 0;
            }

        }
    }
}
