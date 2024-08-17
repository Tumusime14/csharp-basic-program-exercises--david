using System;

namespace SeparatNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };

            int[] positiveNumbers = Array.FindAll(array, n => n > 0);
            int[] negativeNumbers = Array.FindAll(array, n => n < 0);

            Console.WriteLine("Positive numbers:");
            foreach (int num in positiveNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Negative numbers:");
            foreach (int num in negativeNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
