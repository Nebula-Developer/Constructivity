using System;
using Constructivity;

namespace Constructivity.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Nebula Constructivity Demo.\n");
            Console.ReadKey();

            while (true) {
                Console.Clear();
                Console.WriteLine("[0]. Random Sentence");
                Console.WriteLine("[1]. Modern Sentence");
                Console.WriteLine("[2]. Random Chars");
                int.TryParse(Console.ReadLine(), out int a);

                Console.Clear();

                string output = "";
                switch (a) {
                    case 0:
                    // ----> Random Sentence:
                        output = Construct.NewRandomSentence(Question.Int("Sentence Length?"), Question.Bool("Use characters like z, x, j, etc..? (Uncommon characters)"), Question.Bool("Use punctuation?"));
                        break;

                    case 1:
                    // ----> Modern Sentence (beta):
                        output = Construct.NewModernSentence(Question.Int("Sentence Length?"), Question.Bool("Use punctuation?"));
                        break;

                    case 2:
                    // ----> Random Chars:
                        output = Construct.RandomChars(Question.Int("Sentence Length?"));
                        break;

                    default:
                        Console.WriteLine("Please spesify a sentence type.");
                        continue;
                }
                
                
                
                // I'm using a quickly whipped up class for the questions. Find it in Question.cs.
                Console.Clear();
                Console.WriteLine("Result:\n{0}", output);
                Console.ReadKey(true);
            }

        }
    }
}
