namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/

            // ----------------- User Interface class instantiation ----------------- \\
            UserInterface UI = new UserInterface();

            // ------------------ File Manager class instantiation ------------------ \\
            FileManager FileMan = new FileManager();

            // ----------------- ----------- Program Run ---------- ----------------- \\
            int exit = 0;
            while (exit == 0)
            {
                int actionChoice = UI.Menu();

                // Launches the chosen activity
                switch (actionChoice)
                {
                    case 1: // Create New Goal
                        UI.SetNewGoal();
                        break;

                    case 2: // List Goals
                        UI.ListGoals();
                        break;

                    case 3: // Save Goals
                        UI.SaveGoals(FileMan);
                        break;

                    case 4: // Load Goals
                        UI.LoadGoals(FileMan);
                        break;

                    case 5: // Record Event
                        UI.RecordEvent();
                        break;

                    case 6: // quit
                        exit = 1;
                        UI.GoodByeMsg();
                        break;
                }
            }
        }
    }
}