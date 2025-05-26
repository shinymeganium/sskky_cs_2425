using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2 // 9.2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double average = 0;
            double amount = 0;


            do
            {
                Console.WriteLine("Keep inputing numbers to see their average.");
                x = double.Parse(Console.ReadLine());
                amount++;
                average = (average + x) / amount;

                Console.WriteLine("You added " + x + " to average.");
                Console.WriteLine("Your average is " + average);
            }
            while (x >= 0);
        }
    }
}
