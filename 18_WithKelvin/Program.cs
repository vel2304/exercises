using System;

namespace _18_WithKelvin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"
            Choose temperature unit you want to convert from:
            Press C if you have Celsius
            Press F if you have Fahrenheit
            Press K if you have Kelvin  ");
            string inputChoice = GetUserChoice();

            Console.Write(@"
            Choose temperature unit you want to convert to:
            Press C if you want Celsius
            Press F if you want Fahrenheit
            Press K if you want Kelvin  ");
            string outputChoice = GetUserChoice();

            string fahrenheit = "Fahrenheit";
            string celsius = "Celsius";
            string kelvin = "Kelvin";
            string inputUnit = string.Empty;
            string outputUnit = string.Empty;

            if (inputChoice == "C")
                inputUnit = celsius;
            else if (inputChoice == "F")
                inputUnit = fahrenheit;
            else
                inputUnit = kelvin;


            if (outputChoice == "C")
                outputUnit = celsius;
            else if (outputChoice == "F")
                outputUnit = fahrenheit;
            else
                outputUnit = kelvin;

            Console.Write("Please enter the temperature in {0}:  ", inputUnit);
            int temperature = GetUserInput();

            int outputValue = 0;

            if (inputChoice == "C" && outputChoice == "F")
                outputValue = CelsiusToFahrenheit(temperature);
            else if (inputChoice == "F" && outputChoice == "C")
                outputValue = FahrenheitToCelsius(temperature);
            else if (inputChoice == "C" && outputChoice == "K")
                outputValue = CelsiusToKelvin(temperature);
            else if (inputChoice == "K" && outputChoice == "C")
                outputValue = KelvinToCelsius(temperature);
            else if (inputChoice == "K" && outputChoice == "F")
                outputValue = KelvinToFahrenheit(temperature);
            else
                outputValue = FahrenheitToKelvin(temperature);

            Console.WriteLine("The temperature in {0} is {1}", outputUnit, outputValue);
        }

        static string GetUserChoice()
        {
            string input = Console.ReadLine().ToUpper();
            while (input != "C" && input != "F" && input != "K")
            {
                Console.WriteLine(@"Please press C if your temperature in Celsius 
                or press F if your temperature in Fahrenheit
                or press K if your temperature in Kelvin");
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

        static int CelsiusToKelvin(int temperature)
        {
            return temperature + 273;
        }

        static int KelvinToCelsius(int temperature)
        {
            return temperature - 273;
        }

        static int KelvinToFahrenheit(int temperature)
        {
            return (temperature - 273) * 9 / 5 + 32;
        }

        static int FahrenheitToKelvin(int temperature)
        {
            return (temperature - 32) * 5 / 9 + 273;
        }
    }
}
