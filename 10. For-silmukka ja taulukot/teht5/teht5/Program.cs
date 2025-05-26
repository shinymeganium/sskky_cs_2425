using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5 // 10.5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prints 5 rows
            for (int i = 1; i <= 5; i++)
            {
                // prints i times j until j = 5 (also spaces between numbers)
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
