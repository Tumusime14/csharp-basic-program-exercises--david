using System;

namespace RectangleAreaCalculator
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle: ");
            int widthInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the length of the rectangle: ");
            int lengthInput = Convert.ToInt32(Console.ReadLine());

            double area = widthInput * lengthInput;

            Console.WriteLine($"The area of the rectangle is {area} squared unit.");
        }
    }
}
