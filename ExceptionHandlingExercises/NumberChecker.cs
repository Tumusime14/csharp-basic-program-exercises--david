using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercises
{
    public class NumberChecker
    {
        public void CheckNegative(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number should not be negative");
            }
            Console.WriteLine("It should look like: "+ number);
        }
    }
}
