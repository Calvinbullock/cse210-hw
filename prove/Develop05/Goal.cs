namespace Develop05
{
    class Goal
    {
        // List<string>;
        string nameOfGoal;
        string description;
        bool completed;
        int pointValue;

        public void AddGoal()
        {
            // Add a goal and description to the list
        }

        public virtual void RecordProgress()
        {
            // Changes the boolean parameter “completed” / other things depending on child class
        }

        public virtual void VirtualDisplay()
        {
            // Displays a formatted string containing “nameOfGoal” and “description”
        }
    }
}



