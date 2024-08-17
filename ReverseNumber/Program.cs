using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one integer number: ");
            string number = Console.ReadLine();

            char[] reversedNumberArray = number.ToCharArray();
            Array.Reverse(reversedNumberArray);

            string reversedNumber = new string(reversedNumberArray);

            Console.WriteLine($"Reverse number: {reversedNumber}");
        }
    }
}
