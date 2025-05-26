using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>(5);

            Console.WriteLine("Please enter 5 numbers to the list.");
            for (int i = 0; i < list1.Capacity; i++)
            {
                Console.WriteLine($"List index {i}: ");
                list1.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("List1: ");
            foreach (int i in list1)
                Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine($"The highest number is: {list1.Max()}");
            Console.WriteLine($"The lowest number is: {list1.Min()}");
        }
    }
}
