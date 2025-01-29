namespace WordScramble
{
    public class WordInput
    {
        public static string SecretWord(string UserInput)
        {
            /* char[] wordChars = UserInput.ToCharArray(); */
            Random rand = new Random();
            char[] wordChars = UserInput.ToCharArray();
            wordChars = wordChars.OrderBy(x => rand.Next()).ToArray();
            string scrambled = new string(wordChars);
            //Console.WriteLine(scrambled);
            return scrambled;
    }
}