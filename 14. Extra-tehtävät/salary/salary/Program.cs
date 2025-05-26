using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double workHours;
            double payPerHour;
            double taxPercent;
            string hours;

            Console.WriteLine("Check your gross pay, tax amount and net pay.");

            do
            {
                Console.WriteLine("Please give your work hours:");
                hours = Console.ReadLine();
                Console.WriteLine("Please give your pay per hour:");
                string pay = Console.ReadLine();
                Console.WriteLine("Please give your tax percentage:");
                string tax = Console.ReadLine();

                if (double.TryParse(hours, out workHours) && double.TryParse(pay, out payPerHour) && double.TryParse(tax, out taxPercent))
                {
                    Gross(workHours, payPerHour, taxPercent);
                }
                else
                    Console.WriteLine("Please check your input.");
            }
            while (double.TryParse(hours, out workHours));
        }

        static void Gross(double hours, double ratePerHour, double taxRate)
        {
            double gross = hours * ratePerHour;
            double tax = gross * (taxRate / 100);
            double net = gross - tax;

            Console.WriteLine($"Gross pay is {gross} euros.");
            Console.WriteLine($"Tax is {tax} euros.");
            Console.WriteLine($"Net pay is {net} euros.");
        }
    }
}
// bruttopalkka = palkka ennen veroja