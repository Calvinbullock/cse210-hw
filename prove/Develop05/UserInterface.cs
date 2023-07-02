using System;
using System.Collections.Generic;

namespace Develop05
{

    class UserInterface
    {
        /* =======================================================*\
        || Handals all console interaction for this goals list    ||
        ||      program.                                          ||
        ||                                                        ||
        \*========================================================*/

        private List<Goal> _goals = new List<Goal>();

        private int _totalScore = 0;

        public int Menu()
        {
            /*========================================================*\
            || Create's a user interactable console menu.             ||
            ||                                                        ||
            \*========================================================*/

            Console.WriteLine($"You have {_totalScore} points.\n");

            Console.WriteLine("Menu Items");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit.");
            Console.Write("Select a choice from the menu: ");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            return input;
        }

        public void ListGoals()
        {
            /* =======================================================*\
            || Enables user interactions to choose and create new     ||
            ||       goal instances of the three types.               ||
            ||                                                        ||
            \*========================================================*/

            int goalCount = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goalCount + ". " + goal.Display());
                goalCount++;
            }
            Console.WriteLine();
        }

        public void SetNewGoal()
        {
            /* =======================================================*\
            || Enables user interactions to choose and create new     ||
            ||       goal instances of the three types.               ||
            ||                                                        ||
            \*========================================================*/

            Console.WriteLine("Would you like a:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Check List Goal");
            Console.Write("Select a choice from the menu: ");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();

            Console.Write("What is the short description of your goal: ");
            string description = Console.ReadLine();

            Console.Write("What is the point association of your goal: ");
            int points = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // use / build constructers....
            if (input == 1)
            {
                SimpleGoal simpGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpGoal);
            }
            else if (input == 2)
            {
                EteralGoal EGoal = new EteralGoal(name, description, points);
                _goals.Add(EGoal);
            }
            else
            {
                Console.Write("How many times does this goal need to be acomplished for a bonues?: ");
                int neededIterations = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the bonues?: ");
                int bonuesAmt = Convert.ToInt32(Console.ReadLine());

                CheckGoal cGoal = new CheckGoal(bonuesAmt, neededIterations, name, description, points);
                _goals.Add(cGoal);
            }

            Console.Clear();
        }

        public void SaveGoals(FileManager fileMan)
        {
            /* =======================================================*\
            || Writes the list of goals and the users score to a      ||
            ||      save file.                                        ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      fileMan: Passes the instace of Filemanager from   ||
            ||               Program.cs                               ||
            \*========================================================*/
            Console.Write("What would you like to name you goal file: ");
            string FileName = Console.ReadLine();

            fileMan.SaveToFile(_goals, _totalScore, FileName);
        }

        public void LoadGoals(FileManager fileMan)
        {
            /* =======================================================*\
            || The go between for FileManager's load functions and     ||
            ||      the Program.cs header class                       ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      fileMan: Passes the instace of Filemanager from   ||
            ||               Program.cs                               ||
            \*========================================================*/

            Console.Write("What Goal file would you like to read from: ");
            string FileName = Console.ReadLine();

            // Sets goal list and socre from save file
            _goals = fileMan.ReadFromFile(FileName);
            _totalScore = fileMan.GetTotalScore();
        }

        public void RecordEvent()
        {
            /* =======================================================*\
            || Enables the user to record the completion of a goal.   ||
            ||                                                        ||
            \*========================================================*/

            ListGoals();

            Console.WriteLine();
            Console.Write("Whitch Goal did you acomplish?:  ");
            int goalNum = Convert.ToInt32(Console.ReadLine());

            // Change goalNum (user input) to index value
            goalNum--;

            // Interact with choosen instance of Goal
            int pointsValue = _goals[goalNum].RecordProgress(true);
            _totalScore += pointsValue;

            Console.WriteLine();
        }

        public void GoodByeMsg()
        {
            Console.WriteLine("Good Bye");
        }
    }
}