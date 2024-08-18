using System;

namespace MethodExercises
{
    public class EvenNumbers
    {
        public static int[] GetEvenNumbersLessThan(int num)
        {
            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            int[] evens = new int[count];
            int index = 0;
            for (int i = 2; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    evens[index++] = i;
                }
            }

            return evens;
        }
    }
}
