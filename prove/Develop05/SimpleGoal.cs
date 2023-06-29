namespace Develop05
{
    class SimpleGoal : Goal
    {
        private int _completionsNeeded;
        private int _achivedCompletions;

        public SimpleGoal(int completionsNeeded, string nameOfGoal, string description, int pointValue) :
                base(nameOfGoal, description, pointValue)
        {
            _completionsNeeded = completionsNeeded;
        }

        public override void RecordProgress()
        {
            // Changes the boolean parameter “completed” / other things depending on child class
        }

        public void PartialPoints()
        {
            // Gives partial points based on how many times they have RecodedProgress()

        }
    }
}