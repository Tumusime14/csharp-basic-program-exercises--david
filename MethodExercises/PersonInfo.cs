using System;

namespace MethodExercises
{
    internal class PersonInfo
    {
        public static void DisplayPersonInfo(string firstName, string lastName, int yearOfBirth)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - yearOfBirth;
            Console.WriteLine($"{firstName} {lastName}, {age} years old.");
        }
    }
}
