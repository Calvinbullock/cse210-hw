using System;
using System.Threading;


namespace Develop04
{
    class Activity
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private int _duration;

        private string _reflection;

        private string _activityDescription;

        private string _endMessage;


        public Activity() { }

        public Activity(string activityDescription, string endMessage, int duration = 0, string reflection = "")
        {
            _startTime = DateTime.Now;
            _endTime = _startTime.AddSeconds(duration);
            _duration = duration;
            _reflection = reflection;
            _activityDescription = activityDescription;
            _endMessage = endMessage;
        }

        public void Animation(int runtime)
        {
            // Stores the animation.
            // the animation has a base time of 4 seconds to complete
            string[] animation = { "-", "\\", "|", "/" };
            int count = 0;

            while (count != runtime)
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
            _endTime = _startTime.AddSeconds(duration);
        }

        public string GetActivityDescription()
        {
            return _activityDescription;
        }

        public string ShowEndMessage()
        {
            return _endMessage;
        }
        public void SetReflection(string reflection)
        {
            _reflection = reflection;
        }

        public int CheckTime()
        {
            // returns 1 times up, 
            // return 0 times not up
            DateTime currentTime = DateTime.Now;
            if (currentTime < _endTime)
            {
                return 1;
            }

            return 0;
        }
    }
}