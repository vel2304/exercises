using System;
using System.Collections.Generic;

namespace _21_NumbersToNames
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //1. Using a switch statement instead of dictionary (exercise before challenges)

            Console.WriteLine("Please enter the number of the month:");
            int numberOfMonth = GetUserInput();

            string nameofMonth = string.Empty;

            switch (numberOfMonth)
            {
                case 1:
                    nameofMonth = "January";
                    break;
                case 2:
                    nameofMonth = "February";
                    break;
                case 3:
                    nameofMonth = "March";
                    break;
                case 4:
                    nameofMonth = "April";
                    break;
                case 5:
                    nameofMonth = "May";
                    break;
                case 6:
                    nameofMonth = "June";
                    break;
                case 7:
                    nameofMonth = "July";
                    break;
                case 8:
                    nameofMonth = "August";
                    break;
                case 9:
                    nameofMonth = "September";
                    break;
                case 10:
                    nameofMonth = "October";
                    break;
                case 11:
                    nameofMonth = "November";
                    break;
                case 12:
                    nameofMonth = "December";
                    break;
            } 
            
            Console.WriteLine("The name of the month is {0}.", nameofMonth);
            */

            //2. Challenges. Support multiple languages. Use dictionary to remove the switch statement

            Console.WriteLine(@"Choose the language for the name of the month.
            For English press e
            For Spanish press s
            For Ukrainian press u");
            string languageChoise = GetUserChoice();

            Dictionary<int, string> englishMonth = new Dictionary<int, string>();

            englishMonth.Add(1, "January");
            englishMonth.Add(2, "February");
            englishMonth.Add(3, "March");
            englishMonth.Add(4, "April");
            englishMonth.Add(5, "May");
            englishMonth.Add(6, "June");
            englishMonth.Add(7, "July");
            englishMonth.Add(8, "August");
            englishMonth.Add(9, "September");
            englishMonth.Add(10, "October");
            englishMonth.Add(11, "November");
            englishMonth.Add(12, "December");

            Dictionary<int, string> spanishMonth = new Dictionary<int, string>();
            spanishMonth.Add(1, "enero");
            spanishMonth.Add(2, "febrero");
            spanishMonth.Add(3, "marzo");
            spanishMonth.Add(4, "abril");
            spanishMonth.Add(5, "mayo");
            spanishMonth.Add(6, "junio");
            spanishMonth.Add(7, "julio");
            spanishMonth.Add(8, "agosto");
            spanishMonth.Add(9, "septiembre");
            spanishMonth.Add(10, "octubre");
            spanishMonth.Add(11, "noviembre");
            spanishMonth.Add(12, "diciembre");

            Dictionary<int, string> ukrainianMonth = new Dictionary<int, string>();
            ukrainianMonth.Add(1, "sichen’");
            ukrainianMonth.Add(2, "Lyutyi");
            ukrainianMonth.Add(3, "Berezen’");
            ukrainianMonth.Add(4, "Kviten'");
            ukrainianMonth.Add(5, "Traven'");
            ukrainianMonth.Add(6, "Cherven'");
            ukrainianMonth.Add(7, "Lypen'");
            ukrainianMonth.Add(8, "Serpen'");
            ukrainianMonth.Add(9, "Veresen'");
            ukrainianMonth.Add(10, "Zhovten'");
            ukrainianMonth.Add(11, "Lystopad");
            ukrainianMonth.Add(12, "Gruden'");

            Console.WriteLine("Please enter the number of the month:");
            int numberOfMonth = GetUserInput();

            string nameofMonth = string.Empty;

            if (languageChoise == "E")
            {
                englishMonth.TryGetValue(numberOfMonth, out nameofMonth);
            }
            else if (languageChoise == "S")
            {
                spanishMonth.TryGetValue(numberOfMonth, out nameofMonth);
            }
            else
            {
                ukrainianMonth.TryGetValue(numberOfMonth, out nameofMonth);
            }

            Console.WriteLine("The name of the month is {0}.", nameofMonth);
        }

        static int GetUserInput()
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int validNumber) || validNumber > 12 || validNumber < 1)
            {
                Console.WriteLine("Please, enter the number of the month (between 1 and 12)");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        static string GetUserChoice()
        {
            string input = Console.ReadLine().ToUpper();
            while (input != "E" && input != "S" && input != "U")
            {
                Console.WriteLine(@"Please press E if you need the name of the month in English
                or press S for Spanish months
                or press U for Ukrainian name of the month");
                input = Console.ReadLine().ToUpper();
            }
            return input;
        }
    }
}
