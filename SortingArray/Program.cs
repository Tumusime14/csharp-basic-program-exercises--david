namespace SortingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 82, 346, 4, 5, 60, 7, 18, 55 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
