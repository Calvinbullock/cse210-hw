namespace Develop05
{
    abstract class Goal
    {
        /*========================================================*\
        || Parent Goal class.                                     ||
        ||                                                        ||
        \*========================================================*/

        private string _nameOfGoal;
        private string _description;
        private int _pointValue;
        private bool _isCompleted;
        private string _completedValueString;

        public Goal(string nameOfGoal, string description, int pointValue)
        {
            _description = description;
            _pointValue = pointValue;
            _nameOfGoal = nameOfGoal;
            _completedValueString = "[ ]";
            _isCompleted = false;
        }

        public Goal(string nameOfGoal, string description, int pointValue, bool isCompleted)
        {
            _description = description;
            _pointValue = pointValue;
            _nameOfGoal = nameOfGoal;
            _isCompleted = isCompleted;

            // Sets completion indicater after laoding from file.
            if (isCompleted)
            {
                _completedValueString = "[*]";
            }
            else
            {
                _completedValueString = "[ ]";
            }
        }

        // ----------------------------- Abstract Functions ---------------------------- \\
        public abstract int RecordProgress(bool completed);

        public abstract string GetStorageString();

        // ----------------------------- Virtual Functions ----------------------------- \\

        public virtual void SetCompletion(bool completed)
        {
            /*========================================================*\
            || Sets bool completion stat and the complition string.   ||
            ||                                                        ||
            \*========================================================*/

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

        // ------------------------------- Getters & Setters ------------------------------- \\

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



