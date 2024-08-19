using System;
using System.Globalization;

namespace BankAccountApp
{
    public class Account
    {
        private int userId;
        private string firstName;
        private string lastName;
        private decimal balance = 0.0m;

        public Account(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = 0;
        }
        public int UserId
        {
            get { return userId; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrown {amount:C}. New balance: {balance:C}.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Your balance: {balance:C}");
        }

    }
}
