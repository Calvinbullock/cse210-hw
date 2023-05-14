using System.Collections.Generic;
using System;

namespace Develop02
{
    ///<summary> 
    // The responibility of Menu is to store the menu items and deturnman what action will be taken.
    ///</summary> 
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

        public List<string> GetMenuItems()
        {
            return menuItems;
        }

        public void StartMenuLogic(int menuItem, Journal journal)
        {
            // Creats instances of FileManager and ConsoleInteract 
            FileManager fileMan = new FileManager();
            ConsoleInteract console1 = new ConsoleInteract(); // Might be redundent think about just passing in console

            // Creats new instance of Prompt
            Prompts prompt = new Prompts();

            // Creats an instance of dateTime
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            // A string to store the user input fileName
            string fileName;

            switch (menuItem)
            {
                case 1: // Write
                    string randPrompt = prompt.GetRandomPrompt();
                    string entry = console1.EntryInput(randPrompt);

                    // Creats a new journal entry
                    Entry myEntry = new Entry();
                    myEntry.Store(randPrompt, entry, dateText);
                    // Console.WriteLine(myEntry.ToString() + "pop-51"); // ---------------------------------------------- $$$$$$ Remove

                    // Adds the entry to the active journal
                    journal.StoreEntry(myEntry);
                    // Console.WriteLine(journal.entries.Count + "pop-55"); // ---------------------------------------------- $$$$$$ Remove
                    break;

                case 2: // Display
                    // Console.WriteLine(journal.entries.Count); // ---------------------------------------------- $$$$$$ Remove
                    console1.DisplayJournalEntries(journal);
                    break;

                case 3: // Load
                    // Gets filename from user input
                    fileName = console1.FileSelector();

                    // Stores content to user given file
                    fileMan.ReadFromFile(fileName, journal);
                    break;

                case 4: // Save
                    // Gets filename from user input
                    fileName = console1.FileSelector();
                    List<Entry> entries = journal.GetAllEntrys();

                    foreach (Entry eachEntry in entries)
                    {
                        // Stores content to user given file
                        fileMan.SaveToFile(fileName, eachEntry.GetAsString());
                    }
                    break;

                case 5: // Exit program
                    break;
            }
        }
    }
}