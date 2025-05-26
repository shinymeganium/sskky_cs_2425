using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            if (dice1 == dice2)
            {
                if (dice1 == 1)
                {
                    Console.WriteLine("You got the same numbers:");
                    Console.WriteLine("Dice1: " + dice1);
                    Console.WriteLine("Dice2: " + dice2);
                    Console.WriteLine("Snake eyes!");
                }
                else
                {
                    Console.WriteLine("You got the same numbers:");
                    Console.WriteLine("Dice1: " + dice1);
                    Console.WriteLine("Dice2: " + dice2);
                }
            }
            else
            {
                Console.WriteLine("You got different numbers:");
                Console.WriteLine("Dice1: " + dice1);
                Console.WriteLine("Dice2: " + dice2);
            }
        }
    }
}
