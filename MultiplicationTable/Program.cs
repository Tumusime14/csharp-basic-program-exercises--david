using System;
namespace MultiplicationTable;
class Program
{
    static void Main()
    {
        int tableSize = 10;

        Console.Write("      ");
        for (int i = 1; i <= tableSize; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine();
        Console.WriteLine();

        for (int row = 1; row <= tableSize; row++)
        {
            Console.Write($"{row,3}  ");
            for (int col = 1; col <= tableSize; col++)
            {
                Console.Write($"{row * col,4}");
            }
            Console.WriteLine();
        }
    }
}
