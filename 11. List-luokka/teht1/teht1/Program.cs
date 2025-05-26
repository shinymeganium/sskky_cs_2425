using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    internal class Program
    {
        // teht 1-
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();

            for (int i = 1; i <= 10; i++)
                list1.Add(i);

            Console.Write("List1 contains: ");
            foreach (int i in list1)
                Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine($"The sum of list elemts is: {list1.Sum()} \n");
            
            //////////////////
            
            List<int> list2 = new List<int>();

            for (int i = 1; i <= 20; i++)
                list2.Add(i);

            Console.WriteLine("List 2 contains:");
            foreach (int i in list2)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            // method that checks if the number e is even
            // not sure how it interacts with List.RemoveAll
            bool IsNumberEven(int e)
            {
                return e % 2 == 0;
            }

            // removes all numbers that are even
            list2.RemoveAll(IsNumberEven);
            // list2.RemoveAll(x => x % 2 == 0); does the same thing as IsNumberEven()

            Console.WriteLine("List 2 contains after removing even numbers:");
            foreach (int i in list2)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
        }
    }
}
