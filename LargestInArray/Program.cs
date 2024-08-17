namespace LargestInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 156, 78, 43, 85, 13, 34 };
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Biggest numbers: {max}");
        }
    }
}
