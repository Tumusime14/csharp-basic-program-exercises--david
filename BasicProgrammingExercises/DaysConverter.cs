using System;

namespace DaysConverter
{
    class DaysConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            if (int.TryParse(Console.ReadLine(), out int days))
            {
                int years = days / 365;
                int remainingDays = days % 365;
                int weeks = remainingDays / 7;
                remainingDays %= 7;

                Console.WriteLine($"{days} days is approximately {years} years, {weeks} weeks, and {remainingDays} days.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}
