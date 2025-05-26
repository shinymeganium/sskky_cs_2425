using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    // teht 9-13
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 1, 33, 456, 22, 1267, 7 };

            Console.WriteLine($"The array has {array.Length} numbers. They are: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Lowest number in the array is: {array.Min()}"); // 10.11
            Console.WriteLine($"Highest number in the array is: {array.Max()}"); //

            Console.WriteLine($"The average of array's values is: {array.Average()}");

            Array.Sort(array);
            Console.Write("Array's values in a different order: ");

            foreach (int i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

    }
}
