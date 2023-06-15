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

        public Activity(string startMessage, string endMessage, int duration=0, string reflection = "")
        {
            _duration = duration;
            _reflection = reflection;
            _startMessage = startMessage;
            _endMessage = endMessage;
        }

        public void Animation(int duration)
        {
            // Stores the animation.
            string[] animation = { "-", "\\", "|", "/", "-", "\\", "|", "//" };
            int count = 0;

            while (count != duration)
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

        public void SetDuration(int duration)
        {
            _duration = duration;
            Animation(3);
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