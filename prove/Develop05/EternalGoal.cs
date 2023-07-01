namespace Develop05
{
    class EteralGoal : Goal
    {
        public EteralGoal(string nameOfGoal, string description, int pointValue) :
                base(nameOfGoal, description, pointValue)
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
    }
}