using System;
namespace SumAndAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine("First number must be less than second number");
            }
            int sum = 0;
            int count = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sum += i;
                count++;
            }
            double average = (double)sum / count;
            Console.WriteLine($"Sum range between {firstNumber} and {secondNumber} is {sum}");
            Console.WriteLine($"Their average is: {average}");
        }
    }
}
