using System.Collections.Generic;
using System;

namespace Develop02
{
    ///<summary> 
    // The responibility of ConsoleInteract is to handal all console interactions
    // Both input and output.
    ///</summary> 
    class ConsoleInteract
    {
        public int MenuInteract(Menu menu)
        {
            // Lists out menu items and prompts the user to enter a 
            // choice from the menu.
            // Paramiter: takes a menu instance
            // returns: the menu chouice as a int

            // loops trough menuItems and prints each on a new line.
            List<string> menuItems = menu.GetMenuItems();
            foreach (string item in menuItems)
            {
                Console.WriteLine(item);
            }

            // Prompts for input
            Console.Write($"What would you like to do?: ");
            string entry = Console.ReadLine();

            // converts input to an int then returns the int.
            return Convert.ToInt32(entry);
        }

        public string EntryInput(string prompt)
        {
            // Prompts the user for input.
            // Paramiter: string - journal prompt
            // returns: the users input as a string.
            Console.Write($"{prompt}\n>");
            string entry = Console.ReadLine();
            return entry;
        }

        public void DisplayJournalEntries(Journal journal)
        {
            // gets all the journal entries from the Joural class list
            List<Entry> entries = journal.GetAllEntrys();

            // loops trough the Journal List of Entries instances prints each Entry
            foreach (Entry entry in entries)
            {
                // Gets the instance of Entry from Entry and prints to console
                Console.WriteLine(entry.GetAsString());
            }
        }

        public string FileSelector()
        {
            // Reutrns: a file name as a String
            // Prompt for file name to save or load from.
            Console.Write("What is the file name?\n>");
            string fileName = Console.ReadLine();
            return fileName;
        }
    }
}