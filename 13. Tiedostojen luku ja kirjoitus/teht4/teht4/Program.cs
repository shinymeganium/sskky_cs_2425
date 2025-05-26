using System;
using System.IO;
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
            string path = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht4\text.txt";

            if (File.Exists(path) == true)
            {
                string content = File.ReadAllText(path);

                if (content.Contains("dog") || content.Contains("dog".ToUpperInvariant()))
                {
                    content = content.Replace("dog", "cat");
                    content = content.Replace("Dog", "Cat");

                    string newPath = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht4\text_new.txt";

                    if (File.Exists(newPath) == true)
                    {
                        File.WriteAllText(newPath, content);
                        Console.WriteLine("Content copied to a new file.");
                    }
                    else
                        Console.WriteLine("Path not found.");
                }
            }
            else
                Console.WriteLine("Path not found.");
        }
    }
}
