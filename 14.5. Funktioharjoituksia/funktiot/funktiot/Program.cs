using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktiot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            CallHelloWorld();
            Ouch();
        }

        // 1.
        static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }

        // 2.
        static void CallHelloWorld()
        {
            HelloWorld();
        }

        // 3.
        static void Ouch()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ouch");
            }
        }
    }
}
