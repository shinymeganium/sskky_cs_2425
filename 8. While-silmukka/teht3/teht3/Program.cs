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
            Console.WriteLine("Please type two numbers.");
            Console.WriteLine("Number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            /*while (num1 >= 0 && num2 >= 0)
            {
                double num3 = num1 + num2;

                Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + num3);

                if (num1 >= 0 && num2 >= 0)
                    continue;
            }*/
        }
    }
}
