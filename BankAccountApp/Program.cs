namespace BankAccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountUser = new Account(1, "David", "TUMSIME");
            Console.WriteLine($"Welcome dear customer {accountUser.FirstName}!");
                
            while (true)
            {
                Console.WriteLine("Menu:\n 1: Deposit amount\n 2: Withdraw amount\n 3: Check balance\n 0 Exit");
                Console.WriteLine("Select option");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        accountUser.Deposit(depositAmount);
                        break;
                    case "2":
                        Console.Write("Enter withdraw amount: ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        accountUser.Withdraw(withdrawAmount);
                        break;
                    case "3":
                        accountUser.PrintBalance();
                        break;
                    case "0":
                        Console.WriteLine("Thank you for using our service. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Oops!; Invalid option. Retry again!");
                        break;
                }
            }
        }
    }
}
