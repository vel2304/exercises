using System;
using System.Collections.Generic;

namespace _16_LegalDrivingAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age?  ");
            int userAge = GetUserInput();

            const int LEGALAGE = 16;
            string reject = "You are not old enough to legally drive in USA.";
            string permission = "You are old enough to legally drive in USA.";

            string output = (userAge >= LEGALAGE) ? permission : reject;

            Console.WriteLine(output);

            //_______________________________________________________________
            //create a lookup table for the driving ages and countries.
            //Prompt for the age, and display which countries the user can legally drive in.

            Dictionary<string, int> countriesLegalAge = new Dictionary<string, int>();
            countriesLegalAge["Brazil"] = 18;
            countriesLegalAge["United Arab Emirates"] = 18;
            countriesLegalAge["Japan"] = 18;
            countriesLegalAge["Estonia"] = 18;
            countriesLegalAge["France"] = 16;
            countriesLegalAge["Slovenia"] = 16;
            countriesLegalAge["Sweden"] = 16;
            countriesLegalAge["Australia"] = 15;
            countriesLegalAge["Northern Mariana Islands"] = 15;
            countriesLegalAge["El Salvador"] = 15;

            foreach (KeyValuePair<string, int> kvp in countriesLegalAge)
            {
                if (userAge >= kvp.Value)
                {
                    Console.WriteLine("You can legally drive in {0}", kvp.Key);
                }
            }
        }

        static int GetUserInput()
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int validNumber) || validNumber < 0)
            {
                Console.WriteLine("Please, enter your age (it should be positive number).");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
    }

}
