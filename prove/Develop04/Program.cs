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
            // User interface class instatiation
            UserInterface UI = new UserInterface();
            UI.Menu();

            // Breating class instantiation
            string activityTypeBreath = "Reflection Activity";
            string breatingStartMsg = program.startMessage(activityTypeBreath);
            string breatingEndMsg = program.endMessage(activityTypeBreath);
            Breathing breath = new Breathing(breatingStartMsg, breatingEndMsg);

            // Listeing class instantiation
            string activityTypeListen = "Reflection Activity";
            string listeingStartMsg = program.startMessage(activityTypeListen);
            string listeingEndMsg = program.endMessage(activityTypeListen);
            Breathing listeing = new Breathing(listeingStartMsg, listeingEndMsg);

            // Reflection class instantiation
            string activityTypeReflect = "Reflection Activity";
            string reflectionStartMsg = program.startMessage(activityTypeReflect);
            string reflectionEndMsg = program.endMessage(activityTypeReflect);
            Breathing reflection = new Breathing(reflectionStartMsg, reflectionEndMsg);

            string listingStart = $"Welcome to the {activityType}, Please enter the amount of time you would like the activity to run for in seconds: \nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";



            Activity act = new Activity(1, breatingStart, "");

            act.Animation();
        }
    }
}