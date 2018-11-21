using System;

namespace _20_MultistateSalesTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the order amount?  ");
            decimal orderAmount = GetUserInput();

            Console.Write("What state do you live in?  ");
            string state = Console.ReadLine();
            state = state.ToUpper();

            decimal tax = 0m;
            string output = string.Empty;
            decimal stateTax = 0m;
            decimal countyTax = 0m;

            if (state == "WI" || state == "WISCONSIN")
            {
                stateTax = 0.05m;

                Console.Write("What county do you live in?  ");
                string county = Console.ReadLine();
                county = county.ToUpper();

                switch (county)
                {
                    case "EAU CLAIRE":
                        countyTax = 0.005m;
                        break;
                    case "DUNN":
                        countyTax = 0.004m;
                        break;
                    default:
                        countyTax = 0m;
                        break;
                }

                tax = Tax(orderAmount, stateTax, countyTax);
                output += String.Format("The tax is {0:c}.\n", tax);
            }
            else if (state == "IL" || state == "ILLINOIS")
            {
                stateTax = 0.08m;
                tax = Tax(orderAmount, stateTax, countyTax);
                output += String.Format("The tax is {0:c}.\n", tax);
            }

            decimal total = Total(orderAmount, tax);

            output += String.Format("The total is {0:c}", total);

            Console.WriteLine(output);
        }

        static decimal Tax(decimal orderAmount, decimal stateTax, decimal countyTax)
        {
            return Decimal.Ceiling(orderAmount * (stateTax + countyTax) * 100) / 100;  //rounded up to the nearest cent
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
