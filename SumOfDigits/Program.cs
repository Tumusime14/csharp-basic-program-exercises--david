using System;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            string number = Console.ReadLine();

            int sum = 0;

            foreach (char digit in number)
            {
                if (char.IsDigit(digit))
                {
                    sum += int.Parse(digit.ToString());
                }
            }

            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
