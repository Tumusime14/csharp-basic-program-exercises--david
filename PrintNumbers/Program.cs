using System;

namespace PrintNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] excludedNumbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number {i + 1} (1 to 100): ");
                excludedNumbers[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (Array.Exists(excludedNumbers, num => num == i))
                    continue;

                Console.Write(i + " ");
                count++;

                if (count % 7 == 0)
                    Console.WriteLine();
            }
        }
    }
}
