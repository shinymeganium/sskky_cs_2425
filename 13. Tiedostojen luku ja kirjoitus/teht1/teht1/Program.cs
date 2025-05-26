using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write to a file File.WriteAllText
            string filePath1 = @"C:\\Users\\181123\\OneDrive - Salon seudun koulutuskuntayhtymä\\Ohjelmoinnin perusteet\\C#\\13. Tiedostojen luku ja kirjoitus\\teht1\\example1.txt";
            string content1 = "The first text I wrote to a file.";

            File.WriteAllText(filePath1, content1);
            Console.WriteLine($"{content1} has been written on the file {filePath1}.");

            if (File.Exists(filePath1) )
            {
                // read the content of a file and save it to a string File.ReadAllText()
                string content2 = File.ReadAllText(filePath1);
                Console.WriteLine("Content of the file filePath1");
                Console.WriteLine(content2);
            }

            // add text to an existing file File.AppendAllText()
            string content3 = "\nThe second line I wrote to a file.";
            File.AppendAllText(filePath1, content3);
            Console.WriteLine("New text has been written on the file.");
            string content4 = File.ReadAllText(filePath1);
            Console.WriteLine(content4);

            if (File.Exists(filePath1))
            {
                // read a file line by line
                string[] lines = File.ReadAllLines(filePath1);
                Console.WriteLine("Lines of the file:");

                foreach (string line in lines)
                    Console.WriteLine(line);
            }
            else
                Console.WriteLine($"The file {filePath1} was not found.");

            string filePath2 = @"C:\\Users\\181123\\OneDrive - Salon seudun koulutuskuntayhtymä\\Ohjelmoinnin perusteet\\C#\\13. Tiedostojen luku ja kirjoitus\\teht1\\example2.txt";
            
            // write to file using a StreamWriter, have more control with writing
            using (StreamWriter writer = new StreamWriter(filePath2))
            {
                writer.WriteLine("First line.");
                writer.WriteLine("Second line.");
                writer.WriteLine("Third line.");
            }

            // read a file row by row using a StreamReader
            using (StreamReader reader = new StreamReader(filePath2))
            {
                string line;
                Console.WriteLine("File content row by row");

                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }

            // copy a file to another file
            string sourcePath = filePath1;
            string targetPath = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht1\example1_copy.txt";
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, targetPath, true);
                Console.WriteLine($"File copied to {targetPath}");
            }
            else
                Console.WriteLine($"Source file {sourcePath} wasn't found.");

            // delete a file
            if (File.Exists(targetPath))
            {
                File.Delete(targetPath);
                Console.WriteLine($"File {targetPath} was deleted.");
            }
        }
    }
}
