using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14 //7.14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give the x and y coordinates:");
            Console.WriteLine("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y = int.Parse(Console.ReadLine());

            /*
             -x,y = 1st quater
            x,y = 2nd quater
            -x,-y = 3rd quater
            x,-y = forth quater
             */

            if(x < 0 && y > 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the first quater.");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the second quater.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the third quater.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the forth quater.");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the \"middle\" of the 1st and 2nd quater.");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the \"middle\" of the 3rd and 4th quater.");
            }
            else if (y == 0 && x > 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the \"middle\" of the 2nd and 4th quater.");
            }
            else if (y == 0 && x < 0)
            {
                Console.WriteLine("The coordinates " + x + "," + y + " are at the \"middle\" of the 1st and 3rd quater.");
            }
            else
            {
                Console.WriteLine("The coordinates are in the middle of the area");
            }
        }
    }
}
