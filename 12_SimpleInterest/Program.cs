using System;

namespace _12_SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the principal:  ");
            decimal principalAmount = GetUserInput();

            Console.Write("Enter the annual rate of interest as a percentage (like 15, not .15):  ");
            decimal percentageRateOfInterest = GetUserInput();
            decimal rateOfIntetest = percentageRateOfInterest / 100;

            Console.Write("Enter the number of years:  ");
            decimal numberOfYears = GetUserInput();

            Console.WriteLine("\nAfter {0} years at {1:p1}, the investment will be worth {2:c}.", numberOfYears, rateOfIntetest, CalculateSimpleInterest(rateOfIntetest, principalAmount, numberOfYears));
            
            for (int i = 1; i < numberOfYears; i++)
            {
                decimal amountEachYear = principalAmount * (1 + rateOfIntetest * i);
                Console.WriteLine("The investment at the end of year {0} will be {1}", i, amountEachYear);
            }
        }
        
        static decimal CalculateSimpleInterest(decimal rateOfIntetest, decimal principalAmount, decimal numberOfYears)
        {
            decimal amountAtTheEnd = principalAmount * (1 + rateOfIntetest * numberOfYears);
            return Decimal.Ceiling(amountAtTheEnd * 100) / 100;
        }
        
        static decimal GetUserInput()
        {
            string input = Console.ReadLine();
            while (!decimal.TryParse(input, out decimal validNumber) || validNumber < 0)
            {
                Console.WriteLine("Please, enter the positive number.");
                input = Console.ReadLine();
            }
            return decimal.Parse(input);
        }
    }
}
