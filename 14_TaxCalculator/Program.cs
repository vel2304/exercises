using System;

namespace _14_TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the order amount?  ");
            decimal orderAmount = GetUserInput();

            Console.Write("What is the state?  ");
            string state = Console.ReadLine();
            state = state.ToUpper(); //Allow the user to enter a state in upper, lower, or mixed case.

            decimal tax = 0m;
            string output = string.Empty;

            if (state == "WI"||state == "WISCONSINE")
            {
                decimal stateTax = 0.055m;
                tax = Decimal.Ceiling(orderAmount * stateTax * 100) / 100;  //rounded up to the nearest cent
                output += String.Format("The subtotal is {0:c}.\nThe tax is {1:c}.\n", orderAmount, tax);
            }
            decimal total = Total(orderAmount, tax);

            output += String.Format("The total is {0:c}", total);

            Console.WriteLine(output);
        }

        static decimal Total(decimal orderAmount, decimal tax)
        {
            return Decimal.Ceiling((orderAmount + tax) * 100) / 100;  //rounded up to the nearest cent
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
