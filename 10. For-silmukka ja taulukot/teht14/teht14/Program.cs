using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    // teht 14-17
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 55, 2, 755, 354, 8, 11 };

            Console.WriteLine($"Check if a number is in the table. Type a number: ");
            int input1 = int.Parse(Console.ReadLine());

            if (Array.Exists(array1, element => element.Equals(input1)) == true)
            {
                Console.WriteLine($"{input1} is in the array.");
            }
            else
            {
                Console.WriteLine($"{input1} is not in the array.");
            }

            //////////////////////////////

            int[] array2 = { 1, 3, 4, 7 };

            int[] array3 = array1.Concat(array2).ToArray();

            Console.Write("New fused array: ");
            for(int i = 0; i < array3.Length; i++)
                Console.Write($"{array3[i]} ");

            Console.WriteLine();

            ////////////////////////
            
            int[,] array4 = { { 1, 2, 3 }, { 4, 5, 6}, { 7, 8, 9} };

            for (int i = 0; i < array4.GetLength(0);i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    Console.Write($"{array4[i, j]} ");
                }
                Console.WriteLine();
            }

            /////////////

            int[] array5 = { 4, 66, 234, 2, 34 };

            Array.Sort(array5);

            foreach (int i in array5)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
