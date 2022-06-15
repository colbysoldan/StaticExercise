﻿using System;
namespace StaticExercise
{
	public static class TempConverter
	{

		public static double FahrenheitToCelsius(double fahrenheit)
        {
			return (fahrenheit - 32) * 5.0/9.0;
        }

		public static double CelsiusToFahrenheit(double celsius)
        {
			return (celsius * 1.8) + 32;
        }
	}
}

