using System;

namespace MethodExercises
{
    public class BiggestNumber
    {
        public static int GetBiggestNumber(params int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
    }
}
