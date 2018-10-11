using System;

namespace _8_PizzaParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people?");
            int quantityOfPeople = GetUserInput();

            Console.WriteLine("How many pizzas do you have?");
            int quantityOfPizza = GetUserInput();
            const int SLICESPERPIZZA = 8;

            string choosePerson;
            string choosePizza = "pizza";
            if (quantityOfPeople == 1)
            {
                choosePerson = "person";
            }
            else
            {
                choosePerson = "people";
            }
            if (quantityOfPizza > 1 || quantityOfPizza < 1)
            {
                choosePizza += "s";
            }
            Console.WriteLine("{0} {1} with {2} {3}", quantityOfPeople, choosePerson, quantityOfPizza, choosePizza);

            int piecesOfPizza = quantityOfPizza * SLICESPERPIZZA / quantityOfPeople;
            string piece = "piece";
            if (piecesOfPizza > 1)
            {
                piece += "s";
            }
            Console.WriteLine("Each person gets {0} {1} of pizza.", piecesOfPizza, piece);

            int leftover = quantityOfPizza * SLICESPERPIZZA % quantityOfPeople;
            Console.WriteLine("There are {0} leftover {1}.", leftover, piece);

            
            Console.WriteLine("____________________________________________________\n"+
            "A variant of the program that prompts for the number of people and the number " +
            "of pieces each person wants, and calculate how many full pizzas you need to purchase.");

            Console.WriteLine("How many people?");
            quantityOfPeople = GetUserInput();
            if (quantityOfPeople > 0)
            {
                int numberOfPerson = 1;
                double sum = 0;
                do
                {
                    Console.WriteLine("How many pieces of pizza {0} person wants?  ", numberOfPerson);
                    int numberOfPieces = GetUserInput();
                    sum = sum + numberOfPieces;
                    numberOfPerson ++;
                } while (numberOfPerson <= quantityOfPeople);
                double pizzas = sum / SLICESPERPIZZA;
                double wholepizzas = Math.Ceiling(pizzas);
                Console.WriteLine("You should to buy {0} pizzas", wholepizzas);
            }
            else
            Console.WriteLine("So you probably don't need pizzas...");

        }


        static int GetUserInput()
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int validNumber) || validNumber < 0)
            {
                Console.WriteLine("Please, enter the positive integer.");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
    }
}
