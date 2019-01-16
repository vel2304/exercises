using System;

namespace _33_Magic_8_ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your question?   ");
            string question = Console.ReadLine();

            string [] answers = {"Most likely", "Ask again later", "Yes", "No", "Maybe", "Very doubtful",
                                "It is decidedly so", "Sings point to yes"};

            Random anyAnswer = new Random();
            int answerIndex = anyAnswer.Next(answers.Length);

            Console.WriteLine("{0}", answers[answerIndex]);
        }
    }
}
