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
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            bool success = false;
            // Get a temperature from stdin; keep going until we
            // get valid input:
            do
            {

                Console.WriteLine("Enter temperature in Fahrenheit: ");
                string str = Console.ReadLine();
                success = double.TryParse(str, out temp);
            } while (!success);
            // Convert to Celsius, then convert back to Fahrenheit
            var celsius = TempConverter.FahrenheitToCelsius(temp); // 20
            var fahrenheit = TempConverter.CelsiusToFahrenheit(celsius); //68

            Console.WriteLine("After conversion:");
            Console.WriteLine($"Celsius {celsius}");
            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }
    }
}
