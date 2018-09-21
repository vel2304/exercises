using System;

namespace PrintingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the quote?  ");
            string quote = Console.ReadLine();
            Console.Write("Who said it?  ");
            string name = Console.ReadLine();
            Console.WriteLine(name + " says, \"" + quote + "\"");
        }
    }
}
