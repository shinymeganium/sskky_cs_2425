using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palautus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTwoNums(67.093, 3218.421));
            Console.WriteLine(ReturnPositive(-3456.134));
            Console.WriteLine(LastLetter("Susanna"));
        }

        // 1.
        static double SumTwoNums(double num1, double num2)
        {
            return num1 + num2;
        }

        // 2.
        static double ReturnPositive(double num)
        {
            if (num < 0)
                num *= -1;

            return num;
        }

        // 3.
        static char LastLetter(string name)
        {
            int last = name.Length - 1;

            return name[last];
        }
    }
}
