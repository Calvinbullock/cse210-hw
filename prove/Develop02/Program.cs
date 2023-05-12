using System;
using System.Collections.Generic;

// Journal Program
namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {

            // ------------------------------------------------------------------ \\
            // Main Run

            // Creats main Menu, Journal and CosoleInteract instances
            Menu menu = new Menu();
            Journal journal = new Journal();
            ConsoleInteract console = new ConsoleInteract();


            // The detuminer of what action from the menu is taken
            // Delared so it is in and out of the do while scope
            int menuChoice;

            // Loop will only stop when the user inputs a 5 (menu exit choice)
            do
            {
                // propmpts the user for an action.
                menuChoice = console.MenuInteract(menu);

                // Parses the user choice and enacts it
                menu.StartMenuLogic(menuChoice, journal);
            }
            while (menuChoice != 5);
            Console.WriteLine("Good Bye");

            // ------------------------------------------------------------------ \\
            // // Entry and Journal test case

            // Entry myEntry = new Entry();
            // myEntry.Store("What is my name?", "Calvin Bullock", "8 may 2023");

            // Entry yourEntry = new Entry();
            // yourEntry.Store("What is your name?", "Matt", "8 may 2023");

            // Journal journal = new Journal();
            // journal.StoreEntry(myEntry);
            // journal.StoreEntry(yourEntry);

            // List<Entry> entries = journal.GetAllEntrys();
            // foreach (Entry entry in entries)
            // {
            //     string message = entry.GetAsString();
            //     Console.WriteLine(message);
            // }

            // ------------------------------------------------------------------ \\
            // // Test for prompts class

            // Prompts prompt = new Prompts();
            // string randPrompt = prompt.GetRandomPrompt();
            // Console.WriteLine($"{randPrompt}");

            // ------------------------------------------------------------------ \\
            // // FileManger class test case

            // FileManager fileMan = new FileManager();
            // string file = "journalEntry.txt";
            // string content = "If the wighted companion cube talks back ignore it.\nNot that it can talk back.";

            // fileMan.SaveToFile(file, content);
            // string fileContent = fileMan.ReadFromFile(file);
            // Console.WriteLine($"{fileContent}");

        }
    }
}