namespace Develop04
{
    class Program
    {

        static void Main(string[] args)
        {
            // ----------------- User Interface class instantiation ----------------- \\
            UserInterface UI = new UserInterface();
            UI.Menu();


            // ----------------- Breating class instantiation ----------------- \\
            string breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            Breathing breath = new Breathing(breathingDescription);


            // ----------------- Listening class instantiation ----------------- \\
            string listeningDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            Listening listening = new Listening(listeningDescription);


            // ----------------- Reflection class instantiation ----------------- \\
            string reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            Reflection reflection = new Reflection(reflectionDescription);



            // ----------------- Program Run ----------------- \\
            int exit = 0;
            while (exit == 0)
            {
                int activityChoice = UI.Menu();

                // Launches the chosen activity 
                switch (activityChoice)
                {
                    case 1: // breathing
                        break;

                    case 2: // reflection
                        break;

                    case 3: // listing
                        UI.RunListening(listening);
                        break;

                    case 4: // quite
                        exit = 0;
                        break;

                }
            }
        }
    }
}