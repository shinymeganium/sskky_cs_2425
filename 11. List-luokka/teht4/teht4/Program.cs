using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Anna", "Matti", "Liisa", "Pekka" };

            Console.WriteLine("Check if the name you input is on the list:");
            string input1 = Console.ReadLine();
            
            if(nameList.Contains(input1))
            {
                Console.WriteLine($"The name \"{input1}\" is on the list.");
            }
            else
            {
                Console.WriteLine($"The name \"{input1}\" is not on the list.");
            }
            Console.WriteLine("\n");

            ///////////////////////////

            List<string> nameList2 = new List<string>() { "Will", "Gabriel", "Daniel", "Sarah", "Cecilia", "Caroline", "Peter" };
            nameList2.Sort();

            Console.WriteLine("NameList 2 contains:");
            foreach (string name in nameList2)
                Console.WriteLine(name);
            Console.WriteLine("\n");

            //////////////////////////////
        }
    }
}
