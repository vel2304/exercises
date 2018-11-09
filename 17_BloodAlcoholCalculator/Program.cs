using System;

namespace _17_BloodAlcoholCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"If you prefer imperial units (lb, oz) - press i.
            If you use metric units (kg, ml) - press m  ");
            string units = GetUnitPreferens();

            string weight = string.Empty;
            string volume = string.Empty;

            if (units == "i")
            {
                weight = "pounds";
                volume = "ounces";
            }
            else
            {
                weight = "kilograms";
                volume = "milliliters";
            }

            Console.Write("What is your weight in {0}?  ", weight);
            double bodyWeight = GetUserInput();

            if (units == "m")
            {
                bodyWeight = bodyWeight * 2.204622;
            }

            Console.Write("What is your gender? (enter m for male or f for female)  ");
            string gender = GetUserChoice();

            Console.Write("How many drinks did you have? (enter the number)  ");
            double numberOfDrinks = GetUserInput();

            Console.Write("Please enter the amount of alcohol by volume of the one drink, in {0}:  ", volume);
            double oneDrinkVolume = GetUserInput();

            if (units == "m")
            {
                oneDrinkVolume = oneDrinkVolume * 0.03333333333;
            }

            Console.Write("Please, enter the amount of time since your last drink (in hours):  ");
            double timeSinceLastDrink = GetUserInput();

            const double MENALCOHOLDISTRIBUTION = 0.73;
            const double WOMENALCOHOLDISTRIBUTION = 0.66;
            double alcoholDistribution = (gender == "m") ? MENALCOHOLDISTRIBUTION : WOMENALCOHOLDISTRIBUTION;

            double totalAlcoholConsumed = numberOfDrinks * oneDrinkVolume;

            double bloodAlcoholContent = (totalAlcoholConsumed * 5.14) / (bodyWeight * alcoholDistribution) - 0.015 * timeSinceLastDrink;

            double legalContent = 0.08;
            string legal = "It is legal for you to drive.";
            string notLegal = "It is not legal for you to drive.";

            string output = (bloodAlcoholContent <= legalContent) ? legal : notLegal;

            Console.WriteLine(output);
            Console.WriteLine(bloodAlcoholContent);


        }
        static string GetUserChoice()
        {
            string input = Console.ReadLine();
            while (input != "m" && input != "f")
            {
                Console.WriteLine("Please press f for female or press m for male on your keyboard.");
                input = Console.ReadLine();
            }
            return input;
        }

        static string GetUnitPreferens()
        {
            string input = Console.ReadLine();
            while (input != "m" && input != "i")
            {
                Console.WriteLine(@"Please press m for metric system (kg, liter)
                or press i for imperial (US) system (lb, oz, F) on your keyboard.");
                input = Console.ReadLine();
            }
            return input;
        }

        static double GetUserInput()
        {
            string input = Console.ReadLine();
            while (!double.TryParse(input, out double validNumber) || validNumber < 0)
            {
                Console.WriteLine("Please, enter your age (it should be positive number).");
                input = Console.ReadLine();
            }
            return double.Parse(input);
        }
    }
}
