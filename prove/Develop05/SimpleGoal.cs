namespace Develop05
{
    class SimpleGoal : Goal
    {

        public SimpleGoal(string nameOfGoal, string description, int pointValue) :
                base(nameOfGoal, description, pointValue)
        {}

        public SimpleGoal(string nameOfGoal, string description, int pointValue, bool isCompleted) :
                base(nameOfGoal, description, pointValue, isCompleted)
        {}

        public override int RecordProgress(bool completed)
        {
            // Changes the boolean parameter “completed” / other things depending on child class
            this.SetCompletion(completed);
            return this.GetPointValue();
        }

        public override string GetStorageString()
        {
            return $"1|{this.GetNameOfGoal()}|{this.GetGoalDescription()}|{this.GetPointValue()}|{this.GetCompletionValue()}";
        }
    }
}