using System;

namespace _25_PasswordStrength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password:  ");
            string password = UserInput();
            int output = PasswordStrenghtIndicator(password);
            Console.WriteLine("{0}", output);

        }

        static string UserInput()
        {
            string password = Console.ReadLine();

            while (string.IsNullOrEmpty(password))
            {
                Console.Write("Enter a password:  ");
                password = Console.ReadLine();
            }
            return password;
        }

         static int PasswordStrenghtIndicator(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c) && password.Length < 8)
                {
                    return 1;
                }
                else if (char.IsLetter(c) && password.Length < 8)
                {
                    return 2;
                }
                else if (char.IsLetterOrDigit(c) && password.Length >= 8)
                {
                    return 3;
                }
                else if (char.IsLetterOrDigit(c) && char.IsSymbol(c) && password.Length >= 8)
                {
                    return 4;
                }
                else
                    return 5;
            }
            return 6;
        } 

        
    }
}
