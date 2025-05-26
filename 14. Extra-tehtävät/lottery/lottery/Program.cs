using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> availabeNumbers = new List<int>(39);
            int[] winningRow = new int[7];
            int[] myRow = new int[7];
            List<int> matchingNumbers = new List<int>();
            int range;
            int number = 0;
            Random random = new Random();

            // add numbers from 1 to 39 to the list of possible lottery numbers
            for (int i = 0; i < availabeNumbers.Capacity; i++)
            {
                int j = i + 1;
                availabeNumbers.Add(j);
            }

            // use a random number in a range to fetch a number
            // from the list. remove that number from the list and subtract
            // range to match the new count of the list
            for (int i = 0; i < winningRow.Length; i++)
            {
                range = availabeNumbers.Count;
                number = random.Next(1, range);
                int j = number - 1;
                winningRow[i] = availabeNumbers[j];
                availabeNumbers.RemoveAt(j);
                //range--;
            }

            myRow[0] = 7;
            myRow[1] = 8;
            myRow[2] = 3;
            myRow[3] = 4;
            myRow[4] = 28;
            myRow[5] = 21;
            myRow[6] = 6;

            Array.Sort(myRow);
            Array.Sort(winningRow);

            Console.WriteLine("The winning row is:");
            foreach (int i in winningRow)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Your row is:");
            foreach (int i in myRow)
                Console.Write(i + " ");
            Console.WriteLine("\n");


            for (int i = 0; i < myRow.Length; i++)
            {
                if (myRow.Contains(winningRow[i]))
                    matchingNumbers.Add(winningRow[i]);
            }

            if (matchingNumbers.Count > 0)
            {
                Console.WriteLine($"You got {matchingNumbers.Count} numbers right. They are:");
                foreach (int i in matchingNumbers)
                    Console.Write(i + " ");
                Console.WriteLine("\n");
            }

        }
    }
}
