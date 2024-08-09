using System;

namespace TemperatureConverter
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");

            string celsuis = Console.ReadLine();

            double celsius = Convert.ToDouble(celsuis);
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");

        }
    }
}