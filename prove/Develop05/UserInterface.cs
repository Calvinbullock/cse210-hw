using System;
using System.Collections.Generic;

namespace Develop05
{
    class UserInterface
    {
        private List<Goal> _goals;

        private int _totalScore = 0;

        public int Menu()
        {
            // Console display
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
            foreach (Goal goal in _goals)
            {
                goal.Display();
            }
        }

        public void SetNewGoal()
        {
            Console.WriteLine("Would you like a:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
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
            Console.Clear();

            // use / build constructers....
            if (input == 1)
            {
                SimpleGoal simpGoal = new SimpleGoal(3, name, description, points);
                Console.WriteLine($"Bot-----{simpGoal}");
                _goals.Add(simpGoal); // TODO Broken.... object issues?
            }
            else
            {
                EteralGoal EGoal = new EteralGoal(name, description, points);
                _goals.Add(EGoal); // TODO Broken.... object issues?
            }
        }

        public void SaveGoals(FileManager fileMan)
        {
            Console.Write("What would you like to name you goal file: ");
            string FileName = Console.ReadLine();

            fileMan.SaveToFile(_goals, FileName);
        }

        public void LoadGoals(FileManager fileMan)
        {
            Console.Write("What Goal file would you like to read from: ");
            string FileName = Console.ReadLine();

            _goals = fileMan.ReadFromFile(FileName);
        }

        public void RecordEvent()
        {
            ListGoals();

            Console.WriteLine();
            Console.Write("Whitch Goal did you acomplish?:  ");
            int goalNum = Convert.ToInt32(Console.ReadLine());

            // Change goalNum (user input) to index value
            goalNum--;

            // Interact with choosen instance of Goal
            _goals[goalNum].SetCompletionValue(true);
            int pointsValue = _goals[goalNum].GetPointValue();
            _totalScore += pointsValue;
            
            Console.WriteLine();
            Console.WriteLine($"{pointsValue}");
        }

        public void GoodByeMsg()
        {
            Console.WriteLine("Good Bye");
        }
    }
}