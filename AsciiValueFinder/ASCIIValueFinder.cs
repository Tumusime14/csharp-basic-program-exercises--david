namespace AsciiValueFinder
{
    class ASCIIValueFinder
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char userChar = Console.ReadKey().KeyChar;
            int asciiValue = (int)userChar;
            Console.WriteLine($"\nThe ASCII value of '{userChar}' is {asciiValue}.");
        }
    }
}
