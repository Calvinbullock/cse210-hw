using System;
namespace Develop03
{

    class Word
    {
        private bool _hidden;
        private string _word;

        public Word(string word, bool hidden)
        {
            _hidden = hidden;
            _word = word;
        }

        public string GetWord()
        {
            // Get the word, if it is hidden will return underscores
            if (_hidden)
            {
                string hiddenWord = "";
                foreach (char letter in _word)
                {
                    hiddenWord += "-";
                }
                return hiddenWord;
            }
            return _word;
        }

        public bool IsHidden()
        {
            return _hidden;
        }

        public void Hide()
        {
            _hidden = true;
        }

        public void Show()
        {
            _hidden = false;
        }

    }
}