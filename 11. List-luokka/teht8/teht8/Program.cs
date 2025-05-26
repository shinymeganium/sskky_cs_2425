using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Essi", "Aida", "Eemeli", "Frederik", "Paul", "Josh" };

            Console.WriteLine("Please type a name you would like to remove from the list");
            string name1 = Console.ReadLine();

            if (nameList.Contains(name1))
            {
                Console.WriteLine("What is the name you would like to replace it with?");
                string name2 = Console.ReadLine();

                nameList.Remove(name1);
                nameList.Add(name2);

                Console.WriteLine("NameList now contains:");
                foreach (string s in nameList)
                    Console.WriteLine(s);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The name {name1} is not on the list. No names were removed.");
            }
        }
    }
}
