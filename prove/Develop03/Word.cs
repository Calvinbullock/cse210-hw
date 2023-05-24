using System;
namespace Develop03
{

    class Word
    {
        private bool _hidden;
        private string _word;

        public Word(string word)
        {
            _hidden = false;
            _word = word;
        }

        public string GetWord()
        {
            // Get the word, if it is hidden will return underscores
            if (_hidden)
            {
                string hiddenWord = "";

                // Loop breaks the string into individuwal words based on spaces.
                foreach (char letter in _word)
                {
                    hiddenWord += "_";
                }
                // Hidden return
                return hiddenWord;
            }
            // Visable word return
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