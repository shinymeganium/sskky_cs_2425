using System;
using System.IO;
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
            string path = @"C:\Users\181123\OneDrive - Salon seudun koulutuskuntayhtymä\Ohjelmoinnin perusteet\C#\13. Tiedostojen luku ja kirjoitus\teht8\text.txt";

            if (File.Exists(path) == true)
            {
                string content = File.ReadAllText(path);
                int count = 0;
                string word1 = "dog";
                string word2 = "Dog";
                
                if (content.Contains(word1) || content.Contains(word2))
                {
                    // get the index of the first "dog"
                    // get the index of the last "dog"
                    for (int currentIndex = content.IndexOf(word1); currentIndex <= content.LastIndexOf(word1); currentIndex++)
                    {
                        // get the index of next "dog"
                        int index = content.IndexOf(word1, currentIndex);
                        // update current index and word count
                        currentIndex = index;
                        count++;
                    }
                    Console.WriteLine($"The word \"dog\" appears {count} times.");
                    // refresh the counter
                    count = 0;

                    // checks same with "Dog"
                    for (int currentIndex = content.IndexOf(word2); currentIndex <= content.LastIndexOf(word2); currentIndex++)
                    {
                        int index = content.IndexOf(word2, currentIndex);
                        currentIndex = index;
                        count++;
                    }
                    Console.WriteLine($"The word \"Dog\" appears {count} times.");
                }  
            }
            else
                Console.WriteLine("Path not found.");
        }
    }
}
