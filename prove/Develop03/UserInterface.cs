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

        public void HideRandomWord()
        {
            // calls hide()

            // Random num part
            // https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
            Random r = new Random();
            int rInt = r.Next(0, 100);
        }

        public void Display(Scripture scripture)
        {
            // This function displays the scripture and prompts for user's next action.

            // Gets the output string then prints it
            string scriptString = scripture.GetWordsAsString();
            Console.WriteLine(scriptString);

            // Prompits for next action
            Console.Write($"\nEnter 'quit' to exit or next to hide next word.\n>");
            int rawInput = Console.Read();

            // TODO might not be needed....
            // turns rawInput to a string
            string input = "" + rawInput;

            // If user enters "Exit then the program returns to Program.cs main 
            // and ends. -- the use input will be changed to all lower case.
            if (input.ToLower() == "exit") {
                return;
            }
            
            

        }
    }
}