
using System;

namespace MethodExercises
{
    public class SumOfDigits
    {
        public static int DisplaySumOfDigits(int userNum)
        {
            int sum = 0;
            while (userNum > 0)
            {
                sum += userNum % 10;
                userNum /= 10;
            }
            return sum;
        }
    }
}