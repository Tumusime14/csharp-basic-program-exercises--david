using System;

namespace SumOfEvens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one integer number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 2; i <= number; i += 2)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of all even numbers between 1 to {number} is: {sum}");
        }
    }
}
