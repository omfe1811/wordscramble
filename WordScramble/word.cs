namespace WordScramble
{
    public class WordInput
    {
        public string SecretWord(string UserInput)
        {

            char[] WordChars = UserInput.ToCharArray();
            Random rand = new Random();
            WordChars = WordChars.OrderBy(x => rand.Next()).ToArray();
            string scrambled = new string(WordChars);
            return scrambled;
        }



    }
}