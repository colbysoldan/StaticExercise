using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(30);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(30);

            Console.WriteLine($"Temperature Conversions:" +
                $"\nCelsius: {celsius}" +
                $"\nFahrenheit: {fahrenheit}");

            Console.ReadLine();
        }
    }
}

