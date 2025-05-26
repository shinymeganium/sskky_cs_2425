using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the same word or sentence two times. The program checks that there are no errors.");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string quote = "\"";

            if (input1 == input2)
            {
                Console.WriteLine("You wrote: " + quote+ input1 + quote + " two times.");
            }
            else
            {
                Console.WriteLine("You didn't write the same thing on the second time. You wrote:");
                Console.WriteLine(quote + input1 + quote + " on the first time and");
                Console.WriteLine(quote + input2 + quote + " on the second time.");
            }
        }
    }
}
