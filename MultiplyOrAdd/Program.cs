namespace MultiplyOrAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            Double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            Double secondNum = Convert.ToDouble(Console.ReadLine());

            if (firstNum % 2 == 0 || secondNum % 3 == 0)
            {
                Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
            }
            else
            {
                Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");

            }
        }
    }
}
