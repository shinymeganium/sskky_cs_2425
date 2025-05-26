using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See the multiplication table of wanted number:");
            Console.WriteLine("Number:");

            int input = int.Parse(Console.ReadLine());
            int i = 0;

            Console.WriteLine("Multiplication table of " + input);

            while (i < 10)
            {
                i++;
                int result = input * i;
                Console.WriteLine(result);
            }
        }
    }
}
