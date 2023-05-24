namespace Develop03
{
    class Scripture
    {
        private List<Word> _words;

        public List<Word> GetWords()
        {
            return _words;
        }

        public string GetWordsAsString() {
            // This function loops trough _words List and appends them all into a 
            // string then returns that string.
            string wordsString = "";

            for (int i = 0; i < _words.Count; i++) {
                wordsString += _words[i].GetWord();
            }
            
            return wordsString;
        }

        public void SetWords(string paragraph)
        {
            // Calls word(spilt word)
            // Change user input from string to list
            foreach (string word in paragraph.Split(':', StringSplitOptions.RemoveEmptyEntries))
            {
                // Adds the broken string bits to Words
                Word tempWord = new Word(word, true);
                _words.Add(tempWord);
            }
        }
    }
}