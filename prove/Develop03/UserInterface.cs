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
            string scriptString = scripture.GetWordsAsString();

            Console.WriteLine(scriptString);

            Console.WriteLine($"print words string");
            Console.Write($"Enter 'quit' to exit or next to hide next word.\n>");

        }
    }
}