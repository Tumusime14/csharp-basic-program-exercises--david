namespace ExceptionHandlingExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1. DivideNumbers devideNum = new DivideNumbers();
            //devideNum.Divide();
            NumberChecker checkNum = new NumberChecker();
            try
            {
                checkNum.CheckNegative(45);
            }
            catch(ArgumentException ex) {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
        }
    }
}
