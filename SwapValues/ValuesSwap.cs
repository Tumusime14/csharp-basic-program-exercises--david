using System;

namespace SwapValues
{
    class ValuesSwap
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"After swapping: Number 1 = {number1}, Number 2 = {number2}");
        }
    }
}
