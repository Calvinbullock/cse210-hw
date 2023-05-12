using System.Collections.Generic;
using System;

namespace Develop02
{
    class Menu
    {
        List<string> menuItems = new List<string>()
                    {
                        "1. Write",
                        "2. Display",
                        "3. Load",
                        "4. Save",
                        "5. Quit"
                    };

        public void StartMenuLogic(int menuItem)
        {
            // Creats instances of FileManager and ConsoleInteract 
            FileManager fileMan = new FileManager();
            ConsoleInteract console1 = new ConsoleInteract();

            // creats new instance of Prompt and Journal
            Prompts prompt = new Prompts();
            Journal journal = new Journal();

            // creats an instance of dateTime
            DateTime date1 = new DateTime();
            DateTime dateOnly = date1.Date;

            // A string to store the user input fileName 
            string fileName;

            switch (menuItem)
            {
                case 1: // Write
                    string randPrompt = prompt.GetRandomPrompt();
                    string entry = console1.EntryInput(randPrompt);

                    // Creats a new journal entry
                    Entry myEntry = new Entry();
                    myEntry.Store(randPrompt, entry, dateOnly.ToString("MM/dd/yyyy"));

                    // Adds the entry to the active journal
                    journal.StoreEntry(myEntry);
                    break;

                case 2: // Display
                    console1.DisplayJournalEntries(journal);
                    break;

                case 3: // Load
                    // Gets filename from user input
                    fileName = console1.FileSelector();

                    // Stores content to user given file
                    fileMan.ReadFromFile(fileName);
                    break;

                case 4: // Save
                    // Gets filename from user input
                    fileName = console1.FileSelector();

                    // Stores content to user given file
                    // fileMan.SaveToFile(fileName, content); //TODO BROKEN CONTENT VARIABLE
                    break;

                case 5: // Exit program
                    // exit the program
                    break;
            }
        }
    }
}