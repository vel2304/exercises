using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_ComparingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            /* Console.Write("Enter the first number:  ");
            int firstNumber = GetUserInput();

            Console.Write("Enter the second number:  ");
            int secondNumber = GetUserInput();

            Console.Write("Enter the third number:  ");
            int thirdNumber = GetUserInput();

            //Check first to see that all numbers are different. If they’re not different, then exit the program.
            if (firstNumber == secondNumber || firstNumber == thirdNumber || secondNumber == thirdNumber)
            {
                return;
            }

            int output = LargestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("The largest number is {0}.", output);
            */

            //____________________________________________________________________
            //This exersice whith challenges

            Console.Write("Enter the number:  ");
            string input = Console.ReadLine();

            Dictionary<int, bool> allEnteredNumbers = new Dictionary<int, bool>();


            while (int.TryParse(input, out int validNumer))
            {
                if (allEnteredNumbers.ContainsKey(validNumer))
                {
                    Console.WriteLine("This number already has been entered. Please enter the other number.");
                }
                else
                {
                    allEnteredNumbers.Add(validNumer, true);
                }

                Console.Write("Enter the number:  ");
                input = Console.ReadLine();
            }

            int[] numbers = allEnteredNumbers.Keys.ToArray();

            int max = Max(numbers);

            Console.WriteLine("The largest number is {0}.", max);

        }

        //Task 1
        /* static int GetUserInput() 
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int validNumer))
            {
                Console.WriteLine("Please, enter the number.");
                input = Console.ReadLine();
            }
            return validNumber;
        } 

        static int LargestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int largest = 0;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                largest = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                largest = secondNumber;
            }
            else
            {
                largest = thirdNumber;
            }

            return largest;
        }*/


        //____________________________________________________________________
        //This exersice whith challenges
        static int Max(int[] numbers)
        {
            int max = Int32.MinValue;

            foreach (int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
    }


}
