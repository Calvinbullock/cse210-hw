using System.Collections.Generic;
using System;


namespace Develop03
{
    class Scripture
    {
        private List<Word> _words;

        public Scripture(string rawScripture)
        {
            _words = new List<Word>();

            SetWords(rawScripture);
        }

        public List<Word> GetWords()
        {
            return _words;
        }

        public string GetWordsAsString()
        {
            // This function loops trough _words List and appends them all into a 
            // string then returns that string.
            string wordsString = "";

            // Loop puts together a paragraph of words
            for (int i = 0; i < _words.Count; i++)
            {
                wordsString += _words[i].GetWord() + " ";
            }

            return wordsString;
        }

        public void SetWords(string paragraph)
        {
            // Change user input from string to word list
            foreach (string word in paragraph.Split(' '))
            {
                // Adds the broken string bits to _words
                Word tempWord = new Word(word);
                _words.Add(tempWord);
            }
        }

        public void HideRandomWord()
        {
            // TODO Use recurstion to check if word is already hiden if yes
            // call this function again

            // Random num code source:
            // https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
            Random rand = new Random();
            int randInt = rand.Next(0, _words.Count);
            
            // Takes random number and hides a random word
            _words[randInt].Hide();
        }
    }
}