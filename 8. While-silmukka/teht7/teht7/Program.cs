using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7 // 8.7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see how many years it takes to earn your goal amount.");

            Console.WriteLine("How much would you like to deposit?");
            double deposit= double.Parse(Console.ReadLine());

            Console.WriteLine("How much is the yearly interest rate?");
            double interest = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("What is your goal amount?");
            double goal = double.Parse(Console.ReadLine());

            double years = 0;

            while (goal > deposit)
            {
                deposit = deposit + deposit * interest;
                years++;
            }

            Console.WriteLine("It took " + years + " years to reach your savings goal.");
            Console.WriteLine("Your current deposit is " + deposit);
        }
    }
}
