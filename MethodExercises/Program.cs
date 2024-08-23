namespace MethodExercises;

internal class Program
{
    static void Main(string[] args)
    {
        PersonInfo.DisplayPersonInfo("David", "TUMUSIME", 1999);
        Console.WriteLine();

        int[] evens = EvenNumbers.GetEvenNumbersLessThan(10);
        Console.WriteLine("Even numbers less than 10: " + string.Join(", ", evens));
        Console.WriteLine();
        
        int result = SumOfDigits.DisplaySumOfDigits(25);
        Console.WriteLine("Sum of digits(25): " + result);
        Console.WriteLine();
        
        int testArray = BiggestNumber.GetBiggestNumber(32, 54, 659, 434, 656, 2, 45);
        Console.WriteLine("The biggest number in given array: "+testArray);
        Console.WriteLine();
        
        string UserInput = CombineStrings.CombineStringsAlternating("TUMUSIME", "David");
        Console.WriteLine("Comined string: "+UserInput);
    }
}
