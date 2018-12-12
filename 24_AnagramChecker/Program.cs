using System;

namespace _24_AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter two strings and I'll tell you if they are anagrams:");
            Console.Write("Enter the first string:  ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string:  ");
            string str2 = Console.ReadLine();
            
            if (isAnogram(str1, str2))
            {
                Console.WriteLine("\"{0}\" and \"{1}\" are anagrams.", str1, str2);
            }
            else
            {
                Console.WriteLine("\"{0}\" and \"{1}\" are not anagrams.", str1, str2);
            }
        }

        static bool isAnogram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                bool b = true;
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                    return false;
            }
            return true;
        }

    }
}
