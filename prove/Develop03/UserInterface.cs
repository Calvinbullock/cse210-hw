using System;

namespace Develop03
{

    class UserInterface
    {
        public string EnterScripture()
        {
            // Takes user input of a scripture to feed to 
            Console.Write($"Enter scripture.\n>");
            string paragraph = Console.ReadLine();
            return paragraph;
        }

        public int Display(string scriptRefrance, string scriptureString)
        {
            // This function displays the scripture and prompts for user's next action.
            // Function returns 1 if user wants to exit program.

            Console.Clear();
            Console.WriteLine(scriptRefrance + "" + scriptureString);

            // Prompits for next action
            Console.Write($"\nEnter 'quit' to exit or next to hide next word.\n>");
            string input = Console.ReadLine();

            // If user enters "Exit then the program returns to Program.cs main 
            // and ends. -- the use input will be changed to all lower case.
            if (input.ToLower() == "exit")
            {
                return 1;
            }

            return 0;
        }
    }
}