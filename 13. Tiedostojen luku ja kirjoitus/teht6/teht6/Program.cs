using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht6\text.txt";

            if (File.Exists(path) == true)
            {
                string content = File.ReadAllText(path);

                int words = content.Split(' ').Length;

                Console.WriteLine($"The file has {words} words.");
            }
            else
                Console.WriteLine("Path not found.");
        }
    }
}
