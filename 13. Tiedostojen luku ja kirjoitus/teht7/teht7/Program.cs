using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht7\diary.txt";

            if (File.Exists(path) == true)
            {
                string earlierEntries = null;

                using (StreamReader reader = new StreamReader(path))
                {
                    string line;

                    // store earlier entires here if there is any
                    while ((line = reader.ReadLine()) != null)
                        earlierEntries += line;
                }

                // if the file was empty, just create a new entry
                if (earlierEntries == null)
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        Console.WriteLine("Add a diary entry:");

                        DateTime dateTime = DateTime.Now;
                        string entry = Console.ReadLine();

                        writer.WriteLine(dateTime);
                        writer.WriteLine(entry);

                        Console.WriteLine("Diary entry saved");
                    }
                }
                else
                {
                    // store old entries to a string so formatting stays
                    string oldEntriesCopy = File.ReadAllText(path);

                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        Console.WriteLine("Add a diary entry:");

                        DateTime dateTime = DateTime.Now;
                        string entry = Console.ReadLine();

                        writer.WriteLine(oldEntriesCopy);
                        writer.WriteLine();
                        writer.WriteLine(dateTime);
                        writer.WriteLine(entry);

                        Console.WriteLine("Diary entry saved");
                    }
                }
            }
            else
                Console.WriteLine("Path not found.");
        }
    }
}