using System;
using System.Collections.Generic;

namespace _15_PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the username?  ");
            string username = Console.ReadLine();

            const string USERNAMEMATCH = "ValeriiaRudyk";
            const string PASSWORDMATCH = "Hey";

            if (username == USERNAMEMATCH)
            {
                Console.WriteLine("Welcome, {0}. Please, enter your password", username);
            }
            else
            {
                Console.WriteLine("I don’t know you.");
                return;
            }

            Console.Write("What is the password?  ");
            string password = Console.ReadLine();

            if (password == PASSWORDMATCH)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Password is not correct, try again.");
            }
            //___________________________________________________
            //Create a map of usernames and passwords and ensure
            //the username and password combinations match.

            Dictionary<string, string> usernamePassword = new Dictionary<string, string>();

            usernamePassword["Alex"] = "Dobro";
            usernamePassword["ValeriiaRudyk"] = "Hey";


            Console.Write("What is the username?  ");
            username = Console.ReadLine();

            if (usernamePassword.ContainsKey(username))
            {
                Console.WriteLine("Welcome, {0}. Please, enter your password", username);
            }
            else
            {
                Console.WriteLine("I don’t know you.");
                return;
            }

            Console.Write("What is the password?  ");
            password = Console.ReadLine();

            if (password == usernamePassword[username])
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Password is not correct, try again.");
            }
        }
    }
}
