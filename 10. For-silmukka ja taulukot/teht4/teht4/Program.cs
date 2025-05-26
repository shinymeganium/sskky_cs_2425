using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prints 5 rows
            for (int i = 1; i <= 5; i++)
            {
                // prints the j amount of stars on the row, when printing is done, move to the next row with WriteLine()
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
