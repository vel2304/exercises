using System;

namespace _5_SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the first number?  ");
            double firstNumber = GetUserInput();
            Console.Write("What is the second number?  ");
            double secondNumber = GetUserInput();
            double resultsum = firstNumber + secondNumber;
            double resultdiffer = firstNumber - secondNumber;
            double resultproduct = firstNumber * secondNumber;
            double resultquotient = firstNumber / secondNumber;
            Console.WriteLine("{0} + {1} = {2}\n{0} - {1} = {3}\n{0} * {1} = {4}\n{0} / {1} = {5}", firstNumber, secondNumber, resultsum, resultdiffer, resultproduct, resultquotient);
        }
        static double GetUserInput()
        {
            string input = Console.ReadLine();
            while (!double.TryParse(input, out double validNumber) || validNumber < 0)
            {
                Console.WriteLine("Please, enter the positive number.");
                input = Console.ReadLine();
            }
            return double.Parse(input);
        }
    }
}
