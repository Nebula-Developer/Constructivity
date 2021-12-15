using System;
using Constructivity;

namespace Constructivity.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Nebula Constructivity Demo.\n");

            while (true) {
                string output = Construct.NewRandomSentence(Question.Int("Sentence Length?"), Question.Bool("Use characters like z, x, j, etc..? (Uncommon characters)"), Question.Bool("Use punctuation?"));
                // I'm using a quickly whipped up class for the questions. Find it in Question.cs.
                Console.WriteLine("Result:\n{0}", output);
                Console.ReadKey(true);
            }

        }
    }
}
