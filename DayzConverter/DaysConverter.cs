namespace DaysConverter
{
    class DaysConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            int remainingDays = days % 365;
            int weeks = remainingDays / 7;
            int les7days = remainingDays %= 7;

            Console.WriteLine($"{days} days is approximately {years} year(s), {weeks} week(s), and {remainingDays} day(s).");

        }
    }
}
