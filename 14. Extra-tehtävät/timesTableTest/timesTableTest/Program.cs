using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesTableTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\181123\\OneDrive - Salon seudun koulutuskuntayhtymä\\Ohjelmoinnin perusteet\\C#\\14. Extra-tehtävät\\timesTableTest\\highscores.txt";

            if (File.Exists(path) == true)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hi {name}! Please solve these calculations:");

                bool answer = true;
                int times = 0;
                int answerAmount = 0;

                // remember to save function return value
                answerAmount = TimesTableGame(answer, times, answerAmount);

                if (answerAmount >= 1)
                {
                    string highScore = name + ", " + answerAmount + " right answer(s).\n";

                    WriteToFile(path, highScore);
                }
                
            }
            else
                Console.WriteLine("Path not found.");
        }

        static int TimesTableGame(bool rightAnswer, int tries, int rightAnswers)
        {
            while (rightAnswer == true || tries < 10)
            {
                Random random = new Random();
                int a = random.Next(1, 16);
                int b = random.Next(1, 16);

                Console.WriteLine($"What is {a} times {b}?");
                string answer = Console.ReadLine();
                int answerInt;

                if (int.TryParse(answer, out answerInt) == true)
                {
                    if (answerInt == a * b)
                    {
                        Console.WriteLine("Correct!");
                        Console.WriteLine($"{a} times {b} is {answerInt}\n");
                        tries++;
                        rightAnswers = tries;
                        if (tries == 10)
                            rightAnswer = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        Console.WriteLine($"The right answer was {a * b}!");
                        rightAnswer = false;
                        tries = 10;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    Console.WriteLine($"Right answer was {a * b}!");
                    rightAnswer = false;
                    tries = 10;
                }
            }

            return rightAnswers;
        }

        static void WriteToFile(string filePath, string score)
        {
            if (File.ReadAllText(filePath).Length != 0)
                File.AppendAllText(filePath, score);
            else
                File.WriteAllText(filePath, score);

            Console.WriteLine("Score has been saved!");
        }

        // saves and prints times tables through 1 to 15, for fun c:
        /*int[,] timesTable = new int[15, 15];
        int x = 1;
        int y = 1;

        for (int i = 0; i < timesTable.GetLength(0); i++)
        {
            for (int j = 0; j < timesTable.GetLength(1); j++)
            {
                timesTable[i, j] = x * y;
                Console.Write(timesTable[i, j] + " ");
                y++;
            }
            Console.WriteLine();
            x++;
            y = 1;
        }*/
    }
}
