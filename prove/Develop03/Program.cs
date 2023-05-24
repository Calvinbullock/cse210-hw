using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {

            string rawScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

            Scripture scripture = new Scripture(rawScripture);
            UserInterface ui = new UserInterface();

            // Display() prompts the  user for input and returns a 1 for quit or 0 
            // for cuntinue.
            int quit;
            do
            {
                quit = ui.Display(scripture);
            }
            while (quit == 0);
        }
    }
}