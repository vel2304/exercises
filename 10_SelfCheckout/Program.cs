using System;

namespace _10_SelfCheckout
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItem = 1;
            decimal subtotal = 0m;
            string choice = string.Empty;
            decimal tax = 0m;
            const decimal TAXRATE = 5.5m;
            decimal total = 0m;
            do
            {
                Console.Write("Enter the price of item {0}:  ", numberOfItem);
                decimal price = GetUserInput();
                Console.Write("Enter the quantity of item {0}:  ", numberOfItem);
                decimal quantity = GetUserInput();
                Console.Write("Continue shopping. Press y if yes or n if no.  ");
                choice = GetUserChoice();
                subtotal = subtotal + price * quantity;
                tax = subtotal * TAXRATE / 100;
                total = subtotal + tax;
                numberOfItem++;
            } while (choice == "y");
            Console.WriteLine("Subtotal:  {0:C}", subtotal);
            Console.WriteLine("Tax:  {0:C}", tax);
            Console.WriteLine("Total:  {0:C}", total);

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
        static string GetUserChoice()
        {
            string input = Console.ReadLine();
            while (input != "y" && input != "n")
            {
                Console.WriteLine("Please press y on your keyboard if you still shopping " +
                 "or press n if you are done.");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
