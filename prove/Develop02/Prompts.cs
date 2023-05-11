using System;
using System.Collections.Generic;

namespace Develop02
{
    class Prompts
    {
        public List<string> promptsList;

        public Prompts()
        {
            promptsList = new List<string>()
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
        }

        public string GetRandomPrompt()
        {
            // Creats a random number to get a randome index
            // from promptsList then returns the index as a string.
            Random rnd = new Random();
            int randNum = rnd.Next(promptsList.Count);
            return promptsList[randNum];
        }
    }
}
