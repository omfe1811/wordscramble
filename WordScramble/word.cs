namespace WordScramble
{
    public class RandomWord
    {
        public List<string> RandomWordList { get; set; } = new List<string>();

        public RandomWord() { }


        //populate our randomwordlist

        public void PopulateList(string word)
        {
            RandomWordList.Add(word);
        }

        // Method to pick a random word from RandomWordList
        public string PickWord()
        {
            Random random = new Random();
            int listLength = RandomWordList.Count;
            int randomIndex = random.Next(listLength);
            string secretWord = RandomWordList[randomIndex];
            return secretWord;
        }
        public static string GetRandomWordFromStaticList()
        {
            string[] predefinedWords = { "Oscar", "dwight", "Michael", "Angela" };
            Random random = new Random();
            int randomIndex = random.Next(predefinedWords.Length);
            System.Console.WriteLine("index no" + randomIndex);
            return predefinedWords[randomIndex];

        }
    }
}