using System;

namespace TemperatureConverter
{
    class TemperatureConverter
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");

            Double celsuis = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((celsuis * 1.8) + 32);
            Console.WriteLine($"{celsuis}°C is equal to {fahrenheit}°F");
        }
    }
}