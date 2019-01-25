using System;
using System.Collections;

namespace _35_PickingAWinner
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList contestants = new ArrayList();

            do
            {
                Console.Write("Enter a name:  ");
                string name = Console.ReadLine();
                if (name == string.Empty)
                {
                    break;
                }
                contestants.Add(name);
            } while (true);

            Random winner = new Random();
            int winnerIndex = winner.Next(contestants.Count);

            Console.WriteLine("The winner is... {0}.", contestants[winnerIndex]);

            do
            {
                contestants.Remove(contestants[winnerIndex]);
                if (contestants.Count == 0)
                {
                    Console.WriteLine("No any contestants.");
                    break;
                }

                Console.Write("If you want to continue press any key.");
                Console.ReadKey();

                winnerIndex = winner.Next(contestants.Count);

                Console.WriteLine("\nThe next winner is... {0}", contestants[winnerIndex]);
            } while (true); 

        }
    }
}
