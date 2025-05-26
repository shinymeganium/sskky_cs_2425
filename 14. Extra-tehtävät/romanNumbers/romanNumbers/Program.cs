using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romanNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please choose which function to use:");
            //Console.WriteLine("1. Convert Roman numerals to Arabic numerals");
            //Console.WriteLine("2. Convert Arabic numerals to Roman numerals");

            //string choise = Console.ReadLine();

            //if (int.TryParse(choise, out int choiseInt))
            //{
            //    switch (choiseInt)
            //    {
            //        case 1:
            //            break;
            //        case 2:
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("Please give a right input (1 or 2).");
            for (int i = 1; i < 40; i++)
                Console.WriteLine(i + ". " + ArabToRome(i));

        }

        static string ArabToRome(int x)
        {
            string number = "";

            if (x > 0 && x <= 3)
                number = OneToThree(x);
            else if (x > 3 && x < 9)
                number = FourToEight(x);
            else if (x >= 9 && x < 11)
                number = NineToTen(x);
            else if (x >= 11 && x < 40)
                number = ElevenToThirtynine(x);

            return number;
        }

        static string OneToThree(int x)
        {
            string number = "";

            for (int i = 0; i < x; i++)
                number += "I";

            return number;
        }

        static string FourToEight(int x)
        {
            string number = "";

            if (x == 4)
                number = "IV";
            else if (x == 5)
                number = "V";
            else
            {
                number = "V";
                for (int i = 5; i < x; i++)
                    number += "I";
            }

            return number;
        }

        static string NineToTen(int x)
        {
            string number = "";

            if (x == 9)
                number = "IX";
            else
                number = "X";

            return number;
        }

        static string OneToNine(int x)
        {
            string ones = "";
            if (x > 0 && x <= 3)
                ones = OneToThree(x);
            else if (x > 3 && x < 9)
                ones = FourToEight(x);
            else if (x >= 9 && x < 11)
                ones = NineToTen(x);

            return ones;
        }

        static string ElevenToThirtynine(int x)
        {
            string number = "";
            string ones = "";
            string tens = "";
            int y;

            for (int i = 11; i < x; i++)
            {
                if (i < 20)
                {
                    tens = "X";
                    y = x - 10;
                }
                else if (i >= 20 && i < 30)
                {
                    tens = "XX";
                    y = x - 20;
                }
                else
                {
                    tens = "XXX";
                    y = x - 30;
                }

                ones = OneToNine(y);

                number = tens + ones;
            }

            return number;
        }

        static string FourtyToFourtynine(int x)
        {
            string number = "";
            string ones = "";
            string tens = "XL";

            return number;
        }
    }
}
