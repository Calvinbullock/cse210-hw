namespace Develop05
{
    class EteralGoal : Goal
    {
        int completions;

        public override void RecordProgress()
        {
            // Changes the boolean parameter “completed” / other things depending on child class
        }

        public override void VirtualDisplay()
        {
            // Displays a formatted string containing “nameOfGoal” and “description”
        }

        public void PartialPoints()
        {
            // Gives partial points based on how many times they have RecodedProgress()
        }
    }
}