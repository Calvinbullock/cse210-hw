namespace Develop05
{
    class SimpleGoal : Goal
    {

        public SimpleGoal(string nameOfGoal, string description, int pointValue) :
                base(nameOfGoal, description, pointValue)
        {}

        public override int RecordProgress(bool completed)
        {
            // Changes the boolean parameter “completed” / other things depending on child class
            this.SetCompletion(completed);
            return this.GetPointValue();
        }
    }
}