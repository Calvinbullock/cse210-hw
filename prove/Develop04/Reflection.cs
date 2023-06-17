using System;
using System.Collections.Generic;

namespace Develop04
{
    class Reflection : Activity
    {
        private List<string> _prompts;

        private List<string> _questions;

        public Reflection(string description)
                    : base(description)
        {
            _prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        public string ShowPrompt()
        {
            // Creates a random number to get a randome index
            // From _prompts then returns the index as a string.
            Random rnd = new Random();
            int randNum = rnd.Next(_prompts.Count);
            return _prompts[randNum];
        }

        public string ShowQuestion()
        {
            // Returns a random question
            Random rnd = new Random();
            int randNum = rnd.Next(_questions.Count);
            return _questions[randNum];
        }

        public string GetResponse(int index)
        {
            return "";
        }
    }
}