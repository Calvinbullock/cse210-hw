using System;
using System.Collections.Generic;

namespace Develop04
{
    class Listing : Activity
    {
        private List<string> _questions;
        private List<string> _responses;

        public Listing(string startMessage)
                    : base(startMessage)
        {
            _questions = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            _responses = new List<string> {};
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

        public int GetResponsesNumber() {
            return _responses.Count;
        }
    }
}