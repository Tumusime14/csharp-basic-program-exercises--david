namespace ClassLibrary
{
    public static class ExceptionsHandling
    {
        //1. Method responsible to devide number ensuring exceptions handling.
        public static void Divide()
        {
            try
            {
                Console.WriteLine("Enter a divident: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a divisor: ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (y == 0)
                {
                    throw new Exception("Divisor can not be zero");
                }
                double quotient = x / y;
                Console.WriteLine($"The quostient is {quotient}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid number value");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");

            }
        }
        //2. Method to check if the number is negative.
        public static void CheckNegative(int number)
        {
            try
            {
                if (number < 0)
                {
                    throw new ArgumentException("Number should not be negative");
                }
                Console.WriteLine("It not negative: " + number);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Numberr should not be negativeo");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
        }
        //3. Method to check if entered number is in specified range.
        public static void RangeCheck()
        {
            Console.WriteLine("Enter a number between 1 and 100: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (userInput < 0 || userInput > 1000)
                {
                    throw new OverflowException("Error: Out of specified range!");
                }
                else
                {
                    Console.WriteLine($"Thank you! {userInput}");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The input is too large or too small for the range.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }
        //4. Method to parse user input string to integer if possible 
        public static void StringToInt()
        {
            Console.WriteLine("Enter a number");
            try
            {
                string userNum = Console.ReadLine();
                int convertedValue = int.Parse(userNum);
                Console.WriteLine($"Number you entered: {convertedValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: The input is not a valid integer. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The input is too large or too small for an integer.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
        //5. Method that devide two numbers and check denominator if is zero the throw error.
        public static void DevideMethod()
        {
            Console.WriteLine("Enter first number: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (denominator == 0)
                {
                    throw new Exception("Denominator must be greater than 0");
                }
                double divisionResult = (double)numerator / denominator;
                Console.WriteLine($"{numerator} / {denominator} = {divisionResult}");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The input is too large or too small for an integer.");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Oops! {e.Message}");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }


    }
}