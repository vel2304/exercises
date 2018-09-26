using System;

namespace _6_RetirementCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your current age?  ");
            int currentAge = GetUserInput();
            Console.Write("At what age would you like to retire?  ");
            int retireAge = GetUserInput();
            int yearsLeft = retireAge - currentAge;
            Console.WriteLine("You have {0} years left until you can retire.", yearsLeft);
            int currentYear = DateTime.Now.Year;
            if (currentAge > retireAge)
            {
                Console.WriteLine("You can already retire.");
            }
            else
            {
                int canRetireYear = currentYear + yearsLeft;
                Console.WriteLine("It's {0}, so you can retire in {1}.", currentYear, canRetireYear);
            }
        }
        static int GetUserInput()
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int validNumber) || validNumber < 0)
            {
                Console.WriteLine("You should enter the positive number.");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
    }
}
