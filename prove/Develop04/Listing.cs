using System.Collections.Generic;

namespace Develop04
{
    class Listing : Activity
    {
        private int _pauseTime;
        private List<string> _questions;
        private List<string> Responses;

        public Listing(int duration, string reflection, string startMessage, string endMessage)
                    : base(startMessage, endMessage)
        {

        }

        private string ShowQuestion()
        {
            // Returns a random question
            return "";
        }
    }
}