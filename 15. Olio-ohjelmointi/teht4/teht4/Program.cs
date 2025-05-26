using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    public class Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea(double width, double height)
        {
            double area = 0;

            area = width * height;

            return area;
        }

        public double CalculatePerimeter(double width, double height)
        {
            double perimeter = 0;

            perimeter = 2 * width + 2 * height;

            return perimeter;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(21, 48);

            double area = rectangle.CalculateArea(rectangle.Width, rectangle.Height);
            double perimeter = rectangle.CalculatePerimeter(rectangle.Width, rectangle.Height);

            Console.WriteLine($"The area of rectangle is {area} cm^2");
            Console.WriteLine($"and the perimeter of rectangle is {perimeter} cm.");
        }
    }
}
