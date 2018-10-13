using System;

namespace _9_PaintCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("If you have rectangle shape of the ceiling press re\n  " +
            "If you have round shape of the ceiling press ro\n  " +
            "If you have L shape of the ceiling press l\n  ");
            string shooseShape = GetUserChoice();
            double area;
            if (shooseShape == "re")
                area = ReсtangleArea();
            else if (shooseShape == "ro")
                area = RoundArea();
            else
                area = L_ShapeArea();

            double wholeGallonsOfPaint = CalculateGallonsOfPaint(area);
            Console.WriteLine("You will need to purchase {0} gallons of\n" +
       "paint to cover {1} square feet.", wholeGallonsOfPaint, area);

        }
        static double ReсtangleArea()
        {
            Console.Write("What is the length of the ceiling in feet?  ");
            double length = GetUserInput();
            Console.Write("What is the width of the ceiling in feet?  ");
            double width = GetUserInput();
            return length * width;
        }
        static double L_ShapeArea()
        {
            Console.Write("What is the long side's length of the ceiling in feet?  ");
            double l_length = GetUserInput();
            Console.Write("What is the long side's width of the ceiling in feet?  ");
            double l_width = GetUserInput();
            Console.Write("What is the short side's length of the ceiling in feet?  ");
            double s_length = GetUserInput();
            Console.Write("What is the short side's width of the ceiling in feet?  ");
            double s_width = GetUserInput();
            return l_length * l_width + s_length * s_width;
        }
        static double RoundArea()
        {
            Console.Write("What is the radius of the ceiling in feet?  ");
            double radius = GetUserInput();
            const double PI = 3.14;
            return PI * radius * radius;
        }
        static double CalculateGallonsOfPaint(double area)
        {
            const int ONEGALLONCOVER = 350;
            double gallons = area / ONEGALLONCOVER;
            return Math.Ceiling(gallons);
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
        static string GetUserChoice()
        {
            string input = Console.ReadLine();
            while (input != "re" && input != "ro" && input != "l")
            {
                Console.WriteLine("Please press re on your keyboard for rectangle shape of the ceiling " +
                 "or press ro for round shape or press l for L-shape.");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
