using System;
using System.Collections.Generic;

namespace Develop04
{
    class Listening : Activity
    {
        private int _pauseTime;
        private List<string> _questions;
        private List<string> _responses;

        public Listening(string startMessage)
                    : base(startMessage)
        {

        }

        public string GetQuestion()
        {
            // Returns a random question
            Random rnd = new Random();
            int randNum = rnd.Next(_questions.Count);
            return _questions[randNum];
        }

        public void StoreResponse(string response)
        {
            _responses.Add(response);
        }
    }
}