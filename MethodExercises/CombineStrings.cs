using System;

namespace MethodExercises
{

    public class CombineStrings
    {
        public static string CombineStringsAlternating(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            int maxLength = Math.Max(length1, length2);
            char[] combined = new char[length1 + length2];

            int i = 0;
            for (int j = 0; j < maxLength; j++)
            {
                if (j < length1)
                    combined[i++] = str1[j];
                if (j < length2)
                    combined[i++] = str2[j];
            }

            return new string(combined);
        }
    }
}