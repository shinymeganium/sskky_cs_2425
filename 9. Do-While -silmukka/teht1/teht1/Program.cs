using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            do
            {
                Console.WriteLine("Please enter the password:");
                password = Console.ReadLine();

            }
            while (password != "salasana");

            Console.WriteLine("Password right!");
        }
    }
}
