using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                int j = i + 1;
                Console.WriteLine(j);

                i = j; // set i to j so the program prints even numbers
            }
        }
    }
}
