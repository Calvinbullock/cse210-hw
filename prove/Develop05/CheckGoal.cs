namespace Develop05
{
    class CheckGoal : Goal
    {
        private int _completionsNeeded;
        private int _achivedCompletions;
        private int _bonuesPointsAmt;

        public CheckGoal(int bonuesPointsAmt, int completionsNeeded, string nameOfGoal, string description, int pointValue) :
                base(nameOfGoal, description, pointValue)
        {
            _completionsNeeded = completionsNeeded;
            _bonuesPointsAmt = bonuesPointsAmt;
            _achivedCompletions = 0;
        }

        public CheckGoal(int bonuesPointsAmt, int completionsNeeded, int achivedCompletions, string nameOfGoal, string description, int pointValue, bool isCompleted) :
                base(nameOfGoal, description, pointValue, isCompleted)
        {
            _achivedCompletions = achivedCompletions;
            _completionsNeeded = completionsNeeded;
            _bonuesPointsAmt = bonuesPointsAmt;
            _achivedCompletions = 0;
        }

        public override int RecordProgress(bool completed)
        {
            // Changes the boolean parameter “completed” / other things depending on child class
            if (_achivedCompletions + 1 == _completionsNeeded)
            {
                this.SetCompletion(completed);
                _achivedCompletions++;
                return _bonuesPointsAmt + this.GetPointValue();
            }
            else
            {
                _achivedCompletions++;
                return this.GetPointValue();
            }
        }

        public override string Display()
        {
            // Displays a formatted string containing “nameOfGoal” and “description”
            return $"{this.GetCompletionString()} {this.GetNameOfGoal()} ({this.GetGoalDescription()}) -- currently completed {_achivedCompletions}/{_completionsNeeded}";
        }

        public override string GetStorageString()
        {
            return $"3|{this.GetNameOfGoal()}|{this.GetGoalDescription()}|{this.GetPointValue()}|{this.GetCompletionValue()}|{_completionsNeeded}|{_achivedCompletions}|{_bonuesPointsAmt}";
        }
        
    }
}