namespace NumbToWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number between 0 and 9: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            switch (userNum)
            {
                case 0:
                    Console.WriteLine($"{userNum} => Zero");
                    break;
                case 1:
                    Console.WriteLine($"{userNum} => One");
                    break;
                case 2:
                    Console.WriteLine($"{userNum} => Two");
                    break;
                case 3:
                    Console.WriteLine($"{userNum} => Three");
                    break;
                case 4:
                    Console.WriteLine($"{userNum} => Four");
                    break;
                case 5:
                    Console.WriteLine($"{userNum} => Five");
                    break;
                case 6:
                    Console.WriteLine($"{userNum} => Six");
                    break;
                case 7:
                    Console.WriteLine($"{userNum} => Seven");
                    break;
                case 8:
                    Console.WriteLine($"{userNum} => Eight");
                    break;
                case 9:
                    Console.WriteLine($"{userNum} => Nine");
                    break;
                default:
                    Console.WriteLine("Number too big");
                    break;
            }

        }
    }
}