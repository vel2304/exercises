using System;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the input string? ");
            string str = Console.ReadLine();
            Console.WriteLine("'{0}' has {1} characters.", str, str.Length);

            //If the user enters nothing...
            Console.WriteLine("___________________________________");
            Console.WriteLine("Asking the user to enter something");
            Console.WriteLine();
            Console.Write("What is the input string? ");
            string str1 = Console.ReadLine();
            while (String.IsNullOrEmpty(str1))
            {
                Console.WriteLine("Please, enter something.");
                str1 = Console.ReadLine();
            }
            Console.WriteLine("'{0}' has {1} characters.", str1, str1.Length);

        }
    }
}
