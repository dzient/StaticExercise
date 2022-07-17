using System;
//-----------------------------------------------------------------
// Static Exercise
//
// Name: David Zientara
// Date: 7-16-2022
// Comments: An exercise in classes (exercise 1)
// Added methods per the instructions
//-----------------------------------------------------------------
namespace StaticExercise
{
    public static class TempConverter
    {
        // FahrenheitToCelsius
        // Given a temperature in Fahrenheit,
        // function returns the result in celsius
        // PARAMS: fahrenheit (double)
        // RETURNS temperature in celsius (double)
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32.0) / 1.8;

            return result;
        }
        // CelsiusToFahrenheit
        // Given a temperature in Celsius,
        // function returns the result in Fahrenheit
        // PARAMS: celsius (double)
        // RETURNS temperature in Fahrensheit (double)
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9.0) / 5.0 + 32.0;
        }
    }
}
