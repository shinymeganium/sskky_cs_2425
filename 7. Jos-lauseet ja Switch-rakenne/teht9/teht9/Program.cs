using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program selects a random weekday:");

            Random random = new Random();
            int dayNum = random.Next(1, 8);

            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("You got Monday!");
                    break;
                case 2:
                    Console.WriteLine("You got Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("You got Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("You got Thursday!");
                    break;
                case 5:
                    Console.WriteLine("You got Friday!");
                    break;
                case 6:
                    Console.WriteLine("You got Saturday!");
                    break;
                case 7:
                    Console.WriteLine("You got Sunday!");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
