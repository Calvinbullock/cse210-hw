namespace Develop05
{
    class EteralGoal : Goal
    {
        public EteralGoal(string nameOfGoal, string description, int pointValue) :
                base(nameOfGoal, description, pointValue)
        { }
        public override void RecordProgress()
        {
            // Changes the boolean parameter “completed” / other things depending on child class
        }
    }
}