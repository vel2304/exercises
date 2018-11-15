using System;

namespace _19_BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"If you prefer imperial units (lb, in) - press i.
            If you use metric units (kg, m) - press m  ");
            string units = GetUnitPreferens();

            string weightUnits = string.Empty;
            string heightUnits = string.Empty;
            double bodyHeight = 0;

            if (units == "i")
            {
                weightUnits = "pounds";
                heightUnits = "feet and inches";
            }
            else
            {
                weightUnits = "kilograms";
                heightUnits = "centimeters";
            }
            if (units == "i")
            {
                Console.Write(@"Enter your height in {0}.
                Enter feet:  ", heightUnits);
                double feet = GetUserInput();

                Console.Write("Enter inches:  ");
                double inches = GetUserInput();

                bodyHeight = feet * 12 + inches;
            }
            else
            {
                Console.Write("Enter your height in {0}:  ", heightUnits);
                bodyHeight = GetUserInput();
            }

            Console.Write("Enter your weight in {0}:  ", weightUnits);
            double bodyWeight = GetUserInput();

            double bmi = (units == "i") ? bmiImperialUnits(bodyHeight, bodyWeight) : bmiMetricUnits(bodyHeight, bodyWeight);

            if (bmi < 18.5)
            {
                Console.WriteLine(@"Your BMI is {0:n1}.
                You are underweight. You should see your doctor.", bmi);
            }
            else if (bmi > 25)
            {
                Console.WriteLine(@"Your BMI is {0:n1}.
                You are overweight. You should see your doctor.", bmi);
            }
            else
            {
                Console.WriteLine(@"Your BMI is {0:n1}.
                You are within the ideal weight range.", bmi);
            }
        }

        static double GetUserInput()
        {
            string input = Console.ReadLine();
            while (!double.TryParse(input, out double validNumber))
            {
                Console.WriteLine("Please, enter the temperature.");
                input = Console.ReadLine();
            }
            return double.Parse(input);
        }

        static string GetUnitPreferens()
        {
            string input = Console.ReadLine();
            while (input != "m" && input != "i")
            {
                Console.WriteLine(@"Please press m for metric system (kg, m)
                or press i for imperial (US) system (lb, in) on your keyboard.");
                input = Console.ReadLine();
            }
            return input;
        }

        static double bmiImperialUnits(double bodyHeight, double bodyWeight)
        {
            return bodyWeight / (bodyHeight * bodyHeight) * 703;
        }

        static double bmiMetricUnits(double bodyHeight, double bodyWeight)
        {
            return bodyWeight / (bodyHeight * bodyHeight) * 10000;
        }
    }
}
