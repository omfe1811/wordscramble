using System;

namespace WordScramble
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the unscrambled word: ");
                string UserInputGuess = Console.ReadLine();

            }
            /* 
                            2.Iterating Through Characters:
                                o Use a foreach loop or for loop to process each character in a string.
                                foreach (char c in "HELLO")
                            {
                                    Console.WriteLine(c);
                            }
                            3.Comparing Strings:
                                o Use .Equals() for case -sensitive comparison.
                                o Use .ToLower() or.ToUpper() to normalize strings for comparison.
                            string input = "HELLO";
                                if (input.ToUpper() == "HELLO")
                                Console.WriteLine("Match!");
                */
        }
    }
}