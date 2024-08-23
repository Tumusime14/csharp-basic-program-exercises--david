using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercises
{
    public class DivideNumbers
    {
        public void Divide()
        {
            try
            {
                Console.WriteLine("Enter a divident: ");
                int divident = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                double quotient = (double)divident / divisor;
                Console.WriteLine($"The quostient is {quotient}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid nuumber vallue");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Divisor can never be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");

            }
        }
    }
}