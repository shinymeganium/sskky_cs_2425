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
            List<int> list1 = new List<int>(10);
            List<int> list2 = new List<int>(10);
            Random random = new Random();

            for (int i = 0; i < list1.Capacity; i++)
            {
                list1.Add(random.Next(1, 21));
                list2.Add(random.Next(1, 21));
            }

            Console.WriteLine("List1 contains: ");
            foreach (int i in list1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("List2 contains: ");
            foreach (int i in list2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            list1.InsertRange(list1.Capacity, list2);

            list1.Sort();
            Console.WriteLine("After merging, list1 contains: ");
            foreach (int i in list1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            // create a new list to store unique numbers from list1
            List<int> mergedList = new List<int>();

            // loop list1
            for (int i = 0; i < list1.Count; i++)
            {
                // add number to mergedList from list1 if mergedList doesn't contain that number already
                if (mergedList.Contains(list1[i]) == false)
                    mergedList.Add(list1[i]);
            }

            mergedList.Sort();
            Console.WriteLine("List1 after removing duplicate numbers:");
            foreach (int i in mergedList)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
        }
    }
}
