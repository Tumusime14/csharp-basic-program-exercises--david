namespace PosNegZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userNum > 0 ? $"{userNum} is positive" : userNum < 0 ? $"{userNum} is negative" : $"{userNum} is Zero");
        }
    }
}
