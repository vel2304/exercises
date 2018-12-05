using System;

namespace _23_TroubleshootingCarIssues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please answer on the questions yes or no.
            Press y if your answer yes
            or press n if your answer no.");

            Console.Write("Is the car silent when you turn the key?  ");
            string answer = GetUserChoice();

            if (answer == "Y")
            {
                Console.Write("Are the battery terminals corroded?  ");
                answer = GetUserChoice();
                if (answer == "Y")
                {
                    Console.WriteLine("Clean terminals and try starting again.");
                }
                else
                {
                    Console.WriteLine("Replace cables and try again.");
                }
            }
            else
            {
                Console.Write("Does the car make a clicking noise?  ");
                answer = GetUserChoice();
                if (answer == "Y")
                {
                    Console.WriteLine("Replace the battery.");
                }
                else
                {
                    Console.Write("Does the car crank up but fail to start?  ");
                    answer = GetUserChoice();
                    if (answer == "Y")
                    {
                        Console.WriteLine("Check spark plug connections.");
                    }
                    else
                    {
                        Console.Write("Does the engine start and then die?  ");
                        answer = GetUserChoice();
                        if (answer == "Y")
                        {
                            Console.WriteLine("Does your car have fuel injection?  ");
                            answer = GetUserChoice();
                            if (answer == "Y")
                            {
                                Console.WriteLine("Get it in for service.");
                            }
                            else
                            {
                                Console.WriteLine("Check to ensure the choke is opening and closing.");
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }

        }

        static string GetUserChoice()
        {
            string input = Console.ReadLine().ToUpper();

            while (input != "Y" && input != "N")
            {
                Console.WriteLine(@"Please press y on your keyboard if your answer yes,
            or press n if your answer no.");
                input = Console.ReadLine().ToUpper();
            }
            return input;
        }
    }
}
