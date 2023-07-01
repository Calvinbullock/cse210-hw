namespace Develop05
{
    abstract class Goal
    {
        private string _nameOfGoal;
        private string _description;
        private int _pointValue;
        private bool _isCompleted = false;
        private string _completedValueString = "[ ]";

        public Goal(string nameOfGoal, string description, int pointValue)
        {
            _description = description;
            _pointValue = pointValue;
            _nameOfGoal = nameOfGoal;
        }

        public abstract int RecordProgress(bool completed);
        

        public virtual void SetCompletion(bool completed)
        {
            _isCompleted = completed;

            if (completed)
            {
                _completedValueString = "[*]";
            }
            else
            {
                _completedValueString = "[ ]";
            }
        }

        public virtual string Display()
        {
            // Displays a formatted string containing “nameOfGoal” and “description”
            return $"{_completedValueString} {_nameOfGoal} ({_description})";
        }

        public virtual string GetStorageString()
        {
            return $"{_nameOfGoal}|{_description}|{_pointValue}|{_isCompleted}*";
        }

        public string GetNameOfGoal()
        {
            return _nameOfGoal;
        }

        public string GetGoalDescription()
        {
            return _description;
        }

        public bool GetCompletionValue()
        {
            return _isCompleted;
        }

        public string GetCompletionString()
        {
            return _completedValueString;
        }

        public int GetPointValue()
        {
            return _pointValue;
        }
    }
}



