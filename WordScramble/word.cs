namespace WordScramble
{
    public class WordInput
    {
        public string SecretWord(string UserInput)
        {
            /* char[] wordChars = UserInput.ToCharArray(); */
            Random rand = new Random();
            char[] UserInputChar = UserInput.ToCharArray();
            UserInputChar = UserInputChar.OrderBy(x => rand.Next()).ToArray();
            string scrambled = new string(UserInputChar);
            Console.WriteLine(scrambled);
            return scrambled;

        }



    }
}