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
            int i = 0;
            while (i < 101)
            {
                i++;
                if (i % 2 != 0 && i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);  // prints even numbers and numbers that are divisible by three
            }
        }
    }
}
