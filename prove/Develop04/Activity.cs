using System;
using System.Threading;


namespace Develop04
{
    class Activity
    {
        private int _duration;

        private string _reflection;

        private string _startMessage;

        private string _endMessage;


        public Activity() { }

        public Activity(int duration, string startMessage, string endMessage, string reflection = "")
        {
            _duration = duration;
            _reflection = reflection;
            _startMessage = startMessage;
            _endMessage = endMessage;
        }

        public void Animation()
        {
            // Stores the animation.
            string[] animation = { "-", "\\", "|", "/", "-", "\\", "|", "//" };
            int count = 0;

            while (count != _duration)
            {
                foreach (string value in animation)
                {
                    Thread.Sleep(1000);
                    Console.Write("\b");
                    Console.Write(value);
                }
                count++;
            }
        }

        public int GetDuration()
        {
            return _duration;
        }

        public string ShowStartMessage()
        {
            return _startMessage;
        }

        public string ShowEndMessage()
        {
            return _endMessage;
        }
        public void SetReflection(string reflection)
        {
            _reflection = reflection;
        }

        public void StartTimer()
        {
            // Keeps track of the time??
        }
    }
}