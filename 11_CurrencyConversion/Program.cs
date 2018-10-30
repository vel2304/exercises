using System;
using System.Collections.Generic;

namespace _11_CurrencyConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many euros are you exchanging?  ");
            decimal amountFrom = GetUserInput();
            Dictionary<string, decimal> conversionRates = new Dictionary<string, decimal>();
            conversionRates.Add("England", 0.89m);
            conversionRates.Add("Ukraine", 32.27m);
            conversionRates.Add("China", 7.93m);
            conversionRates.Add("USA", 1.14m);
            List<string> keyListCountry = new List<string>(conversionRates.Keys);//добавила список стран - перестало работать вообще
            Console.WriteLine("You could choose for currency exchange from these countries: {0}", keyListCountry);
            do
            {
                Console.Write("Enter the country wich currency you need:   ");
                string userChooseCountry = Console.ReadLine();
                decimal rateTo = 0m;
                if (conversionRates.TryGetValue(userChooseCountry, out rateTo))
                {
                    decimal amountTo = Convert(amountFrom, rateTo);
                    Console.WriteLine("{0} euros at an exchange rate of {1} is {2}", amountFrom, rateTo, amountTo);
                    break;
                }
                else
                {

                    Console.WriteLine("Please enter the name of country from {0}", keyListCountry) ;
                }
            } while (true);
            

        }
        static decimal Convert(decimal amountFrom, decimal rateTo)
        {
            return Math.Ceiling(amountFrom * rateTo);
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
