namespace Develop05
{
    class Goal
    {
        //private List<string>;
        private string nameOfGoal;
        private string description;
        private bool completed;
        private int pointValue;

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



