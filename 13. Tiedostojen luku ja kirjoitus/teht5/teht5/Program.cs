using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht5\text.txt";

            if (File.Exists(path) == true)
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    int lineCount = 0;

                    while ((line = reader.ReadLine()) != null)
                        lineCount++;

                    Console.WriteLine($"The file has {lineCount} lines.");
                }
            }
            else
                Console.WriteLine("Path not found.");
        }
    }
}
