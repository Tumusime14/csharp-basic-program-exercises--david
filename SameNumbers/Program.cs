namespace SameNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum == secondNum && secondNum == thirdNum)
            {
                Console.WriteLine($"{firstNum} , {secondNum} and {thirdNum} are all the same!");
            }
            else
            {
                Console.WriteLine($"{firstNum} , {secondNum} and {thirdNum} are not the same!");
            }
        }
    }
}