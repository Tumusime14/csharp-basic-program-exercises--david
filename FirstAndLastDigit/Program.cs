using System;

namespace FirstAndLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any integer number: ");
            string number = Console.ReadLine();

            char lastDigit = number[number.Length - 1];
            char firstDigit = number[0];

            Console.WriteLine($"The last digit of entered number: {lastDigit}");
            Console.WriteLine($"The first digit of entered number: {firstDigit}");
        }
    }
}
