using System;

namespace Develop04
{
    class Activity
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private int _duration;

        private string _reflection;

        private string _activityDescription;


        public Activity() { }

        public Activity(string activityDescription)
        {
            _activityDescription = activityDescription;
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

        public void SetReflection(string reflection)
        {
            _reflection = reflection;
        }

        public void StartTimer()
        {
            _startTime = DateTime.Now;
            _endTime = _startTime.AddSeconds(_duration);
        }

        public int CheckTime()
        {
            // returns 1 times up, 
            // return 0 times not up
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(_startTime);
            Console.WriteLine(currentTime);
            Console.WriteLine(_endTime);
            if (currentTime < _endTime)
            {
                return 1;
            }

            return 0;
        }
    }
}