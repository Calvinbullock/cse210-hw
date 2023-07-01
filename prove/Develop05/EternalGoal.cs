namespace Develop05
{
    class EteralGoal : Goal
    {
        public EteralGoal(string nameOfGoal, string description, int pointValue) :
                base(nameOfGoal, description, pointValue)
        { }

        public EteralGoal(string nameOfGoal, string description, int pointValue, bool isCompleted) :
                base(nameOfGoal, description, pointValue, isCompleted)
        { }

        public override int RecordProgress(bool completed)
        {
            // Changes the boolean parameter “completed” / other things depending on child class
            if (completed)
            {
                return this.GetPointValue();
            }
            else
            {
                return 0;
            }
        }

        public override string GetStorageString()
        {
            return $"2|{this.GetNameOfGoal()}|{this.GetGoalDescription()}|{this.GetPointValue()}|{this.GetCompletionValue()}";
        }
    }
}