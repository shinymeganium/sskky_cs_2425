using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametritJaArgumentit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleNumber(63);
            AddOne(99);
            Greetings("Susanna");
            MultipleHelloWorlds(4);
        }

        // 1.
        static void DoubleNumber(double num)
        {
            Console.WriteLine(num * 2);
        }

        // 2.
        static void AddOne(double num)
        {
            Console.WriteLine(num + 1);
        }

        // 3.
        static void Greetings(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // 4.
        static void MultipleHelloWorlds(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Hello world!");
            }
        }
    }
}
