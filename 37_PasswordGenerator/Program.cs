using System;
using System.Collections;
using System.Linq;

namespace _37_PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the minimum length?  ");
            int length = GetUserInput();

            Console.Write("How many special characters?  ");
            int amountOfCharacters = GetUserInput();

            Console.Write("How many numbers?  ");
            int amountOfNumbers = GetUserInput();

            int amountOfLetters = length - amountOfCharacters - amountOfNumbers;

            int codeFirstLetter = (int)'a';
            int codeLastLetter = (int)'z';
            int codeFirstNumber = (int)'0';
            int codeLastNumber = (int)'9';
            int codeFirstCharacter = (int)'!';
            int codeLastCharacter = (int)'/';

            Random rand = new Random();

            ArrayList password = new ArrayList();

            for (int option = 1; option < 5; option++)
            {
                for (int i = 0; i <= amountOfLetters; i++)
                {
                    int letterIndex = rand.Next(codeFirstLetter, codeLastLetter);
                    char letter = (char)letterIndex;
                    password.Add(letter);
                }

                for (int i = 0; i <= amountOfCharacters; i++)
                {
                    int characterIndex = rand.Next(codeFirstCharacter, codeLastCharacter);
                    char character = (char)characterIndex;
                    password.Add(character);
                }

                for (int i = 0; i <= amountOfNumbers; i++)
                {
                    int numberIndex = rand.Next(codeFirstNumber, codeLastNumber);
                    char number = (char)numberIndex;
                    password.Add(number);
                }

                Shuffle(rand, password);

                PrintValue(password);
                Console.WriteLine();
                password.Clear();
            }

        }

        static void Shuffle(Random rng, ArrayList array)
        {
            int n = array.Count;
            while (n > 1)
            {
                int k = rng.Next(n--);
                char temp = (char)array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        static int GetUserInput()
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int validNumber))
            {
                Console.WriteLine("Please, enter the integer.");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        static void PrintValue(ArrayList password)
        {
            foreach (char k in password)
            {
                Console.Write("{0}", k);
            }
        }
    }
}
