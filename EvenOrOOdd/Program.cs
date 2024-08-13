namespace EvenOrOdd
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an Even number");
            }
            else
            {
                Console.WriteLine($"{num} is Odd");
            }
        }
    }
}
