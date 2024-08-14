namespace PasswordMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password: ");
            var userPassword = Convert.ToString(Console.ReadLine());

            if (userPassword.Equals("s3cr3t!p@ssw0rd"))
            {
                Console.WriteLine("\nWelcome!");
            }
            else
            {
                Console.WriteLine("\nWrong password!");
            }

        }
    }
}
