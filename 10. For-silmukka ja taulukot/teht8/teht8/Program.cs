using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = 200;
            double interest = 0.05;

            Console.WriteLine($"You started with {savings} savings.");
            Console.WriteLine($"Your interest rate is {interest}. \n");

            for (int years = 1; years <= 10; years++)
            {
                savings = savings + interest * years;
                Console.WriteLine($"Your savings after {years} years: {savings}");
            }
        }
    }
}
