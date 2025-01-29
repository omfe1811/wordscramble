using System;

namespace WordScramble
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a secret word");
            string secretWord = Console.ReadLine().ToUpper();
            if (secretWord == null)
            {
                Console.WriteLine("You must enter a word!");
            }
            else 
            {
                Console.Clear();
            }

            string scrambled = WordInput.SecretWord(secretWord);
            Console.WriteLine(scrambled);

            while(true)
            {
                Console.WriteLine("Enter your guess:");
                string guess = Console.ReadLine().ToUpper();
                if(guess == secretWord)
                {
                    Console.WriteLine($"You're right, the word was {secretWord}");
                    break;
                }
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
                4.Reversing or Scrambling:
                 o Use .ToCharArray() to convert a string to a character array, then shuffle or
                  reverse it.
                  char[] arr = "apple".ToCharArray();
                  Array.Reverse(arr);
                  string reversed = new string(arr); 
                  Output: "elppa"
                 o Use .ToCharArray() and Random to shuffle characters for scrambling.
                    char[] arr = word.ToCharArray();
                    Random rand = new Random();
                    arr = arr.OrderBy(x => rand.Next()).ToArray();
                    string scrambled = new string(arr)
*/
        }
    }
}