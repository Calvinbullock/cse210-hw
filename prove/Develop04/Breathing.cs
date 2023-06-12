namespace Develop04
{
    class Breathing : Activity
    {
        private int _breathInTime;
        private int _breathOutTime;


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