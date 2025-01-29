using System;

namespace WordScramble
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a secret word");
            /*  1.Splitting and Joining Strings:
                 o Use .Split() to break a string into parts(e.g., for Caesar Cipher).
                 o Use string.Join() to combine parts into a single string.
                string[] words = "apple orange banana".Split(' ');
                string combined = string.Join("-", words);
                        Output:
                "apple-orange-banana"
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