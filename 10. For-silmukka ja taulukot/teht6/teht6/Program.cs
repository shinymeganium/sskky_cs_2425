using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 20; i++)
            {
                int square = i * i;
                Console.WriteLine($"Number: {i}, square of {i}: {square}");
            }
        }
    }
}
