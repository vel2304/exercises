using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // with using variables
            Console.WriteLine("version with using variables");
            string a = "What is your name? ";
            string b = "Hello, ";
            string c = ", nice to meet you!";
            Console.Write(a);
            string d = Console.ReadLine();
            Console.WriteLine(b + d + c);
            // without using any variables
            Console.WriteLine("_________________________________");
            Console.WriteLine();
            Console.WriteLine("version without using any variables");
            Console.Write("What is your name? ");
            Console.Write("Hello, " + Console.ReadLine() + ", nice to meet you!");
        }
    }
}
