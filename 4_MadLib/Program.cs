using System;

namespace _4_MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a noun:  ");
            string n = Console.ReadLine();
            Console.Write("Enter a verb:  ");
            string v = Console.ReadLine();
            Console.Write("Enter an adjective:  ");
            string adj = Console.ReadLine();
            Console.Write("Enter an adverb:  ");
            string adv = Console.ReadLine();
            Console.WriteLine("You {0} your {1} {2} {3}. That's hilarious!", v, adj, n, adv);
        }
    }
}
