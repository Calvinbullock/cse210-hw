using System.Collections.Generic;
using System;

namespace Develop02
{
    ///<summary> 
    // The responibility of am journal is to store instances of the entry class
    ///</summary> 
    class ConsoleInteract
    {
        public string EntryInput(string prompt)
        {
            // Prompts the user for input.
            // Paramiter: string - journal prompt
            // returns: the users input as a string.
            Console.WriteLine($"{prompt}\n>");
            string entry = Console.ReadLine();
            return entry;
        }

        public void DisplayJournalEntries(Journal journal)
        {
            List<Entry> entries = journal.GetAllEntrys();
            foreach (Entry entry in entries)
            {
                string message = entry.GetAsString();
                Console.WriteLine(message);
            }
        }

        public string FileSelector()
        {
            // Reutrns: a file name as a String
            // Prompt for file name to save or load from.
            Console.WriteLine("What is the file name?\n>");
            string fileName = Console.ReadLine();

            return fileName;
        }
    }
}