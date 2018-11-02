using System;

namespace _13_CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the principal amount?  ");
            decimal principalAmount = GetUserInput();

            Console.Write("What is the rate as a percentage (like 15, not .15)?  ");
            decimal percentageRate = GetUserInput();
            decimal rate = percentageRate / 100;

            Console.Write("What is the number of years?  ");
            decimal numberOfYears = GetUserInput();

            Console.Write(@"What is the number of times the interest
        is compounded per year?  ");
            decimal numberCompaunded = GetUserInput();

            decimal amountInvestment = AmountAtTheEndInvestment(numberCompaunded, numberOfYears, principalAmount, rate);

            Console.WriteLine(@"{0:c} invested at {1:p1} for {2} years
       compounded {3} times per year is {4}", principalAmount, rate, numberOfYears, numberCompaunded, amountInvestment);

            Console.WriteLine("You can determine the initial amount you’d need to invest to reach a specific goal.");

            Console.Write("How much do you want to make?  ");
            decimal goal = GetUserInput();
            decimal principalAmountSupposedToBe = SpecificGoal(numberCompaunded, numberOfYears, goal, rate);
            Console.WriteLine(@"To reach your goal {0:c} with {1:p1} in {2} years
       compounded {3} times per year your principal amount supposed to be {4:c}", goal, rate, numberOfYears, numberCompaunded, principalAmountSupposedToBe);

        }
        static decimal SpecificGoal(decimal numberCompaunded, decimal numberOfYears, decimal goal, decimal rate)
        {
            decimal power = numberCompaunded * numberOfYears;
            return goal / (decimal)Math.Pow((double)(1 + rate / numberCompaunded), (double)power);
        }
        static decimal AmountAtTheEndInvestment(decimal numberCompaunded, decimal numberOfYears, decimal principalAmount, decimal rate)
        {
            decimal power = numberCompaunded * numberOfYears;
            decimal amountInvestment = principalAmount * (decimal)Math.Pow((double)(1 + rate / numberCompaunded), (double)power);

            return Decimal.Ceiling(amountInvestment * 100) / 100;
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
