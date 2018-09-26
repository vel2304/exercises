using System;

namespace _7_AreaOfRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the length of the room in feet?  ");
            double length = GetUserInput();
            Console.Write("What is the width of the room in feet?  ");
            double width = GetUserInput();
            Console.WriteLine("You entered dimensions of {0} feet by {1} feet.", length, width);
            double areaF = length * width;
            const double TOSQUAREMETERS = 0.09290304;
            double areaM = areaF * TOSQUAREMETERS;
            Console.WriteLine("The area is\n{0} square feet\n{1:0.000} square meters", areaF, areaM);

            //a new version that allows you to choose feet or meters for inputs
            Console.WriteLine("_________________________________________");
            Console.Write("If your measurement in feet - press f.\nIf your measurement in meters - press m.  ");

            string chooseMeasurement = GetUserChoice();

            if (chooseMeasurement == "f")
            {
                CalculateArea("feet");
            }
            else if (chooseMeasurement == "m")
            {
                CalculateArea("meters");
            }
        }
        // Calculate Area
        static void CalculateArea(string feetOrMeters)
        {
            Console.Write($"What is the length of the room in {feetOrMeters}?  ");
            double length = GetUserInput();
            Console.Write($"What is the width of the room in {feetOrMeters}?  ");
            double width = GetUserInput();
            Console.WriteLine($"You entered dimensions of {length} {feetOrMeters} by {width} {feetOrMeters}.");
            double area = length * width;
            Console.WriteLine($"The area is\n{area} square {feetOrMeters}");
        }

        // return "m" or "f"
        static string GetUserChoice()
        {
            string input = Console.ReadLine();
            while (input != "m" && input != "f")
            {
                Console.WriteLine("Please press f for feet or press m for meters on your keyboard.");
                input = Console.ReadLine();
            }
            return input;
        }

        static double GetUserInput()
        {
            string input = Console.ReadLine();
            while (!double.TryParse(input, out double validNumber) || validNumber < 0)
            {
                Console.WriteLine("Please, enter the positive number.");
                input = Console.ReadLine();
            }
            return double.Parse(input);
        }
    }
}
