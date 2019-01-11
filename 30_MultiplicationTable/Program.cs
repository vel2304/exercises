using System;

namespace _30_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("|    ");
            for (int i = 0; i <= 12; i++)
            {
                Console.Write("|{0, -4}", i);
            }
            Console.WriteLine("|");
            Console.WriteLine("______________________________________________________________________");
            for (int i = 0; i <= 12; i++)
            {
                Console.Write("|{0, -4}", i);
                for (int j = 0; j <= 12; j++)
                {
                    int result = i * j;
                    Console.Write("|{0, -4}", result);
                }
                Console.WriteLine("|");
                Console.WriteLine("______________________________________________________________________");
            }
        }
    }
}
