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
            List<int> list1 = new List<int>(20);
            Random random = new Random();

            // adds a random number between 1 and 5 to every index
            for (int i = 0; i < list1.Capacity; i++)
                list1.Add(random.Next(1, 6));

            foreach (int i in list1)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Insert a number between 1 and 5 to see how many times that number is on list1:");
            int number1 = int.Parse(Console.ReadLine());

            List<int> list2 = list1.FindAll(x => x == number1);
            Console.WriteLine($"The number {number1} is on the list {list2.Count} times.");
        }
    }
}
