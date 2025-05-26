using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateHypotenuse(3.78, 8.32);
        }

        static void CalculateHypotenuse(double cath1, double cath2)
        {
            double hypotenuseSquare = Math.Pow(cath1, 2) * Math.Pow(cath2, 2);
            double hypotenuse = Math.Sqrt(hypotenuseSquare);

            Console.WriteLine($"The lenght of hypotenuse is {hypotenuse}");
            Console.WriteLine($"when the lengths of cathetuses are {cath1} and {cath2}.");
            Console.WriteLine($"The rounded value of hypotenuse is {Math.Round(hypotenuse})");
        }
    }
}
