namespace OddNumbers1_500
{
    internal class Program
    {
        public static int count;
        static void Main(string[] args)
        {
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
