using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // path of the file you want to read
            string path = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht2\textFile1.txt";

            if (File.Exists(path))
            {
                // save the content of the file to a string
                string content = File.ReadAllText(path);
                Console.WriteLine("File content has been saved.");

                // path of the file you want to write the copy of the first file
                string targetPath = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht2\textFile1 – kopio.txt";

                if (File.Exists(targetPath))
                {
                    // writes everything from a file and writes it on another file
                    File.WriteAllText(targetPath, content);
                    Console.WriteLine($"Text of the original file \"path\" has been written onto a file \"targetPath\"");
                }
                else
                    Console.WriteLine("Path not found");
            }
            else
                Console.WriteLine("Path not found");
        }
    }
}
