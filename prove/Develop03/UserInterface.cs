using System;
namespace Develop03
{

    class UserInterface
    {
        public string EnterScripture()
        {
            Console.Write($"Enter scripture.\n>");
            string paragraph = Console.ReadLine();
            return paragraph;
        }

        public int Display(Scripture scripture)
        {
            // This function displays the scripture and prompts for user's next action.
            // Function returns 1 if user wants to exit program.

            // Gets the output string then prints it
            string scriptString = scripture.GetWordsAsString();
            Console.Clear();
            Console.WriteLine(scriptString);

            // Prompits for next action
            Console.Write($"\nEnter 'quit' to exit or next to hide next word.\n>");
            int rawInput = Console.Read();

            // TODO might not be needed....
            // turns rawInput to a string
            string input = "" + rawInput;

            // If user enters "Exit then the program returns to Program.cs main 
            // and ends. -- the use input will be changed to all lower case.
            if (input.ToLower() == "exit")
            {
                return 1;
            }

            scripture.HideRandomWord();
            return 0;
        }
    }
}