using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int x = 0;
            int y = 1;
            int z = 0;

            Console.WriteLine("Fibonacci sequence first 10 numbers:");
            Console.WriteLine(x);
            Console.WriteLine(y);

            while (i < 10)
            {
                z = x + y;
                Console.WriteLine(z);

                x = y;
                y = z;
                
                i++;
            }
        }
    }
}
// set the first two numbers, they're known. form the function with the 2 known numbers, set the next round before the current loop ends