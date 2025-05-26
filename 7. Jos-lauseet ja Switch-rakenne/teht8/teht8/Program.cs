using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which greeting you want to see:");
            Console.WriteLine("Press 1 to see a formal greeting.");
            Console.WriteLine("Press 2 to see a cheerful greeting.");
            Console.WriteLine("Press 3 to see a rude greeting.");

            Console.WriteLine("Please enter your choise!");
            string input = Console.ReadLine();

            if(int.TryParse(input, out int number) == true)
            {
                switch (number) 
                {
                    case 1:
                        Console.WriteLine("Good day. I am pleased to meet you.");
                        break;
                    case 2:
                        Console.WriteLine("Hi! I'm so happy meeting you here!");
                        break;
                    case 3:
                        Console.WriteLine("Hello. You have an ugly face.");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
