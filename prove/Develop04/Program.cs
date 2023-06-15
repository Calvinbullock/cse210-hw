using System;
namespace Develop04
{
    class Program
    {

        private int BuildStartMessage(UserInterface UI, string activityType, string activityDescription)
        {
            UI.PrintMsg($"Welcome to the {activityType} activity.");

            UI.PrintMsg(activityDescription);

            int duration = UI.CollectInputInt("Please enter the amount of time you would like the activity to run for in intervales of 10 seconds: ");
            return duration;
        }

        private string endMessage(string activityType)
        {
            string endMsg = $" Well done. \nYou have completed a {activityType}.";
            return endMsg;
        }

        static void Main(string[] args)
        {
            // ----------------- Program class instantiation ----------------- \\
            // This is needed...
            Program program = new Program();


            // ----------------- User Interface class instantiation ----------------- \\
            // User interface class instatiation
            UserInterface UI = new UserInterface();
            UI.Menu();


            // ----------------- Breating class instantiation ----------------- \\
            // sets end and start messages 
            string activityTypeBreath = "Reflection Activity";
            string breatingEndMsg = program.endMessage(activityTypeBreath);
            string breathingMSG = "/nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

            // Breating class instantiation
            Breathing breath = new Breathing(breathingMSG, breatingEndMsg);


            // ----------------- Listening class instantiation ----------------- \\
            // sets end and start messages 
            string activityTypeListen = "Reflection Activity";
            string listeingEndMsg = program.endMessage(activityTypeListen);
            string listeningMSG = "/nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

            // Listeing class instantiation
            Breathing listeing = new Breathing(listeningMSG, listeingEndMsg);


            // ----------------- Reflection class instantiation ----------------- \\
            // sets end and start messages 
            string activityTypeReflect = "Reflection Activity";
            string reflectionEndMsg = program.endMessage(activityTypeReflect);
            string reflectionMSG = "/nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

            // Reflection class instantiation
            Breathing reflection = new Breathing(reflectionMSG, reflectionEndMsg);



            // ----------------- Program Run ----------------- \\
            int exit = 0;
            while (exit == 0)
            {
                int input = UI.Menu();
                int duration;

                // Launches the chosen activity 
                switch (input)
                {
                    case 1: // breathing
                        // Prints out all parts of start message
                        duration = program.BuildStartMessage(UI, "breathing", breath.GetActivityDescription());
                        breath.SetDuration(duration);

                        // set the breating in / out times each is half of the total time
                        int breathInOut = breath.GetDuration() / 2;
                        breath.setBreathInTime(breathInOut);
                        breath.setBreathOutTime(breathInOut);
                        breath.Animation(2);
                        break;

                    case 2: // reflection
                        // Prints out all parts of start message
                        duration = program.BuildStartMessage(UI, "breathing", reflection.GetActivityDescription());
                        breath.SetDuration(duration);
                        break;

                    case 3: // listing
                        // Prints out all parts of start message
                        duration = program.BuildStartMessage(UI, "breathing", listeing.GetActivityDescription());
                        breath.SetDuration(duration);
                        break;

                    case 4: // quite
                        exit = 0;
                        break;

                }
            }
        }
    }
}