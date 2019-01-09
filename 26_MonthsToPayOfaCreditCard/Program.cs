using System;

namespace _26_MonthsToPayOfaCreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your balance?  ");
            double balance = GetUserInput();

            Console.Write("What is the APR on the card (as a percent)?  ");
            double aPR = GetUserInput();

            Console.Write("What is the monthly payment you can make?  ");
            double monthlyPayment = GetUserInput();

            double numberOfMonths = calculateMonthsUntilPaidOff(balance, aPR, monthlyPayment);

            Console.WriteLine("It will take you {0} months to pay off this card.", numberOfMonths);
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

        static double calculateMonthsUntilPaidOff(double balance, double aPR, double monthlyPayment)
        {
            //aPR = aPR / 100;
            double i = aPR; /// 365;
            double a = 1 + balance / monthlyPayment * (1 - Math.Pow((1 + i), 30));
            return (-1 / 30) * (Math.Log(a) / Math.Log(1 + i));
        }
    }
}
