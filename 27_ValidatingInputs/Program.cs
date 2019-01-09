using System;

namespace _27_ValidatingInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name:  ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name:  ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the ZIP code:  ");
            string zipCod = Console.ReadLine();

            Console.Write("Enter an employee ID:  ");
            string employeeID = Console.ReadLine();

            string output = ValidateInput(firstName, lastName, zipCod, employeeID);
            Console.WriteLine(output);
        }

        static string ValidFirstName(string firstName)
        {
            string output = string.Empty;
            if (firstName == string.Empty)
            {
                output = "The first name must be filled in.\n";
            }
            else if (firstName.Length < 2)
            {
                output = "\"" + firstName + "\" is not a valid first name. It is too short.\n";
            }
            return output;
        }

        static string ValidLastName(string lastName)
        {
            string output = string.Empty;
            if (lastName == string.Empty)
            {
                output = "The last name must be filled in.\n";
            }
            else if (lastName.Length < 2)
            {
                output = "\"" + lastName + "\" is not a valid last name. It is too short.\n";
            }
            return output;
        }

        static string ValidZipCode(string zipCod)
        {
            string output = string.Empty;
            if (zipCod == string.Empty)
            {
                output = "The zip cod must be filled in.\n";
            }
            else if (zipCod.Length < 5)
            {
                output = "Zip cod must be at least five characters long.\n";
            }
            else if (!int.TryParse(zipCod, out int result))
            {
                output = "The ZIP code must be numeric.\n";
            }
            return output;
        }

        static string ValidEmployeeID(string employeeID)
        {
            string output = string.Empty;
            if (employeeID.Length != 7)
            {
                output = "An employee ID must be seven characters long";
                return output;
            }

            bool firstTwoLetters = char.IsLetter(employeeID[0]) && char.IsLetter(employeeID[1]);
            bool thirdHyphen = employeeID[2] == '-';
            int res = 0;
            bool lastFourNumbers = int.TryParse(employeeID.Substring(3, 4), out res);
            
            if (firstTwoLetters && thirdHyphen && lastFourNumbers) 
            {
                return output;
            }
            
            return output = employeeID + " is not a valid ID.";

            // else if (!(char.IsLetter(employeeID[0]) && char.IsLetter(employeeID[1]) //check first two letters
            // && employeeID[2] == '-'                                                 //check a hyphen
            // && char.IsNumber(employeeID[3]) && char.IsNumber(employeeID[4]) && char.IsNumber(employeeID[5])//check last four nubers
            // && char.IsNumber(employeeID[6])))                       //check last four nubers                                             
            // {
            //     output = employeeID + " is not a valid ID.";
            // }
            // return output;
        }

        static string ValidateInput(string firstName, string lastName, string zipCod, string employeeID)
        {
            string output = string.Empty;
            output = ValidFirstName(firstName);
            output += ValidLastName(lastName);
            output += ValidZipCode(zipCod);
            output += ValidEmployeeID(employeeID);
            if (output == string.Empty)
            {
                output = "There were no errors found.";
            }
            return output;
        }
    }
}
