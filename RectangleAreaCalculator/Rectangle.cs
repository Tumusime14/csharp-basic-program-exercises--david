using System;

namespace RectangleAreaCalculator
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle: ");
            string widthInput = Console.ReadLine();

            Console.Write("Enter the length of the rectangle: ");
            string lengthInput = Console.ReadLine();

            double width = Convert.ToDouble(widthInput);
            double length = Convert.ToDouble(lengthInput);

            double area = width * length;

            Console.WriteLine($"The area of the rectangle is {area} square units.");
        }
    }
}
