namespace Develop04
{
    class Program
    {

        private string startMessage(string activityType)
        {
            string startMsg = $"Welcome to the {activityType}, Please enter the amount of time you would like the activity to run for in seconds: \nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            return startMsg;
        }

        private string endMessage(string activityType)
        {
            string endMsg = $" Well done. \nYou have completed a {activityType}.";
            return endMsg;
        }

        static void Main(string[] args)
        {
            string activityType = "";

            string breatingStart = $"Welcome to the {activityType}, Please enter the amount of time you would like the activity to run for in seconds: \nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

            string reflectionStart = $"Welcome to the {activityType}, Please enter the amount of time you would like the activity to run for in seconds: \nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

            string listingStart = $"Welcome to the {activityType}, Please enter the amount of time you would like the activity to run for in seconds: \nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";



            Activity act = new Activity(1, breatingStart, "");

            act.Animation();
        }
    }
}