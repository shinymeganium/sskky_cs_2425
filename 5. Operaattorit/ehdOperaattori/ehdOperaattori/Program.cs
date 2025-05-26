using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ehdOperaattori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ehto ? arvoJosTrue : arvoJosFalse;

            // is the number > 0 or number < 0 or number == 0

            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            string result = number > 0 ? "positive" : number < 0 ? "negative" : "zero";
            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}
