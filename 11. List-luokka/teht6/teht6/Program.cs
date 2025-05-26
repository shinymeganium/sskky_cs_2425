using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            for(int i = 1; i <= 10; i++)
                list1.Add(i);

            Console.WriteLine("List1 contains:");
            foreach (int i in list1)
                Console.Write($"{i} ");
            Console.WriteLine();

            list1.Reverse();
            Console.WriteLine("List1 contains after reversion:");
            foreach (int i in list1)
                Console.Write($"{i} ");
            Console.WriteLine();

        }
    }
}
