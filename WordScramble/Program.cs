using System;
namespace WordScramble
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a secret word");
            string secretWord = Console.ReadLine().ToUpper();
            if (secretWord == string.Empty)
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
                else 
                {
                    Console.WriteLine("Wrong! Try again"); 
                }
            }
        }
    }
}