using System;

namespace _18_TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Press C to convert from Fahrenheit to Celsius.
            Press F to convert from Celsius to Fahrenheit.  ");
            string choice = GetUserChoice();
            Console.WriteLine("Your choice: {0}", choice);

            string fahrenheit = "Fahrenheit";
            string celsius = "Celsius";

            string inputUnit = (choice == "C") ? fahrenheit : celsius;
            string outputUnit = (choice == "C") ? celsius : fahrenheit;

            Console.Write("Please enter the temperature in {0}:  ", inputUnit);
            int temperature = GetUserInput();

            int outputValue = (choice == "C") ? FahrenheitToCelsius(temperature) : CelsiusToFahrenheit(temperature);
            Console.WriteLine("The temperature in {0} is {1}", outputUnit, outputValue);

        }
        static string GetUserChoice()
        {
            string input = Console.ReadLine().ToUpper();
            while (input != "C" && input != "F")
            {
                Console.WriteLine(@"Please press C to convert from Fahrenheit to Celsius 
                or press F to convert from Celsius to Fahrenheit on your keyboard.");
                input = Console.ReadLine().ToUpper();
            }
            return input;
        }
        static int GetUserInput()
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int validNumber))
            {
                Console.WriteLine("Please, enter the temperature.");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        static int FahrenheitToCelsius(int temperature)
        {
            return (temperature - 32) * 5 / 9;
        }

        static int CelsiusToFahrenheit(int temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

    }
}
