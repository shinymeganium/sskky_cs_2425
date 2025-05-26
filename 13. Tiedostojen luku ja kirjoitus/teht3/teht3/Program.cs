using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht3\text.txt";
            string destinationPath = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht3\textCopy.txt";

            List<string> rows = new List<string>();

            if (File.Exists(sourcePath))
            {
                using (StreamReader reader = new StreamReader(sourcePath))
                {
                    string line;
                    Console.WriteLine("The source file contains:");

                    // adds all rows of the file to a list
                    while ((line = reader.ReadLine()) != null)
                    {
                        rows.Add(line);
                        Console.WriteLine(line);
                    }

                }
                if (File.Exists(destinationPath))
                {
                    using (StreamWriter writer = new StreamWriter(destinationPath))
                    {
                        // writes to destinationPath from the rows List, also adds row numbers
                        for (int i = 0; i < rows.Count(); i++)
                            writer.WriteLine($"{i + 1}. {rows[i]}");

                        Console.WriteLine("The file has been written.");
                    }
                }
                else
                    Console.WriteLine("Path not found.");
            }
            else
                Console.WriteLine("Path not found.");
        }
    }
}
