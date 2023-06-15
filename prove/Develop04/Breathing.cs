namespace Develop04
{
    class Breathing : Activity
    {
        private int _breathInTime;
        private int _breathOutTime;

        public Breathing(string startMessage, string endMessage, int breathInTime=0, int breathOutTime=0, int duration=0)
                    : base(startMessage, endMessage)
        {
            breathInTime = _breathInTime;
            breathOutTime = _breathOutTime;
        }

        public int getBreathInTime()
        {
            return _breathInTime;
        }

        public void setBreathInTime(int breathInTime)
        {
            _breathInTime = breathInTime;
        }

        public int getBreathOutTime()
        {
            return _breathOutTime;
        }

        public void setBreathOutTime(int breathOutTime)
        {
            _breathOutTime = breathOutTime;
        }
    }
}