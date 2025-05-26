using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            double answer = num1 + num2;

            return answer;
        }

        public double Subtract(double num1, double num2)
        {
            double answer = num1 - num2;

            return answer;
        }

        public double Multiply(double num1, double num2)
        {
            double answer = num1 * num2;

            return answer;
        }

        public double Divide(double num1, double num2)
        {
            double answer = num1 / num2;

            return answer;
        }

        public void PrintAnswer(double number)
        {
            Console.WriteLine($"The answer is {number}.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double number1 = calculator.Add(45, 87);
            double number2 = calculator.Subtract(832, 491);
            double number3 = calculator.Multiply(39, 21);
            double number4 = calculator.Divide(222, 14);

            calculator.PrintAnswer(number1);
            calculator.PrintAnswer(number2);
            calculator.PrintAnswer(number3);
            calculator.PrintAnswer(number4);
        }
    }
}
