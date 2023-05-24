namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mian content strings
            string scriptRefrance = "Proverbs: 3: 5-6 ";
            string rawScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

            // Creats scripture and UI instances
            Scripture scripture = new Scripture(rawScripture);
            UserInterface ui = new UserInterface();

            // Calls Display() > prompts the user for input and returns a 1 for quit  
            // or 0 for cuntinue looping.
            int quit;
            do
            {
                // Gets the output string then passes it to Display to output it
                string scriptString = scripture.GetWordsAsString();
                quit = ui.Display(scriptRefrance, scriptString);

                // Hide 3 words
                scripture.HideRandomWord();
                scripture.HideRandomWord();
                scripture.HideRandomWord();
            }
            while (quit == 0);
        }
    }
}