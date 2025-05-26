using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    internal class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello world!");
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        static int Square(int number)
        {
            return number * number;
        }

        static int Sum(int num1, int num2) // 12.6
        {
            return num1 + num2;
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            return sum;
        }

        static int Fibonacci(int n)
        {
            int x = 0;
            int y = 1;
            int z = 0;
            int answer;
            
            for (int i = 2; i <= n; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }

            if (n == 0)
                answer = 0;
            else if (n == 1)
                answer = 1;
            else
                answer = z;

            return answer;
        }

        static void PrintTriangle(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void Swap(ref int x, int newX, ref int y, int newY) // 12.9
        {
            Console.Write($"{x} is now ");
            x = newX;
            Console.WriteLine(newX);
            Console.Write($"{y} is now ");
            y = newY;
            Console.WriteLine(newY);
        }
        static void Swap2(ref int x, ref int y)
        {
            
        }

        static void Main(string[] args)
        {
            SayHello();
            Greet("Susanna");
            Console.WriteLine(Square(55));
            Console.WriteLine(Sum(775, 29014));
            Console.WriteLine(IsEven(444));
            int[] numbers1 = { 1, 5, 2222, 653, 8 };
            Console.WriteLine(CalculateSum(numbers1));
            Console.WriteLine(Fibonacci(7));
            PrintTriangle(6);
            int a = 22;
            int b = 34;
            Swap(ref a, 55, ref b, 777);
            //Swap2(ref a, ref b);
           
        }
    }
}
