using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 3, 5, 7, 9, 11, 13 ,15, 17, 19 };
            int[] list1CopyArray = new int[list1.Count];
            List<int> list1Copy = new List<int>();

            Console.WriteLine("List1:");
            foreach (int i in list1)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            list1.CopyTo(list1CopyArray);

            for (int i = 0;  i < list1CopyArray.Length; i++)
            {
                list1Copy.Add(list1CopyArray[i]);
            }

            list1.Add(21);
            list1.Add(23);
            list1.Add(25);

            Console.WriteLine("List1 after adding numbers: ");
            foreach (int i in list1)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Copy of list1: ");
            foreach (int i in list1Copy)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

        }
    }
}
