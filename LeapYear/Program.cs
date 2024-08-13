namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int userYear = Convert.ToInt32(Console.ReadLine());

            if (userYear % 4 == 0)
            {
                if (userYear % 100 == 0)
                {
                    if (userYear % 400 == 0)
                    {
                        Console.WriteLine($"{userYear} is a leap year");
                    }
                    else
                    {
                        Console.WriteLine($"{userYear} is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine($"{userYear} is a leap year");
                }
            }
            else
            {
                Console.WriteLine($"{userYear} is not a leap year");
            }
        }
    }
}
