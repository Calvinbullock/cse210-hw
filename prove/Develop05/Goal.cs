namespace Develop05
{
    abstract class Goal
    {
        private string _nameOfGoal;
        private string _description;
        private int _pointValue;
        private bool _completedValue = false;
        private string _completedValueString = "[ ]";

        public Goal(string nameOfGoal, string description, int pointValue)
        {
            _description = description;
            _pointValue = pointValue;
            _nameOfGoal = nameOfGoal;
        }

        public void AddGoal()
        {
            // Add a goal and description to the list
        }

        public virtual void RecordProgress()
        {
            // Changes the boolean parameter “completed” / other things depending on child class
        }

        public string Display()
        {
            // Displays a formatted string containing “nameOfGoal” and “description”
            return $"[{_completedValue}] {_nameOfGoal} ({_description})";
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
            return _completedValue;
        }

        public string GetCompletionString()
        {
            return _completedValueString;
        }

        public void SetCompletionValue(bool completed)
        {
            _completedValue = completed;
            if (completed)
            {
                _completedValueString = "[*]";
            }
            else
            {
                _completedValueString = "[ ]";
            }
        }

        public int GetPointValue()
        {
            return _pointValue;
        }
    }
}



