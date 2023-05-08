using System;
using System.Collections.Generic;

namespace Develop02
{

    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.Store("What is my name?", "Calvin Bullock", "8 may 2023");
            
            Entry yourEntry = new Entry();
            yourEntry.Store("What is your name?", "Matt", "8 may 2023");

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);
            journal.StoreEntry(yourEntry);

            List<Entry> entries = journal.GetAllEntrys();
            foreach (Entry entry in entries)
            {
                string message = entry.GetAsString();
                Console.WriteLine(message);
            }
        }
    }
}