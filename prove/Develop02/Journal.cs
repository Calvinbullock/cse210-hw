using System.Collections.Generic;
namespace Develop02
{
    ///<summary> 
    // The responibility of am journal is to store instances of the entry class
    ///</summary> 
    class Journal
    {

        public List<Entry> entries;

        public Journal() {
            entries = new List<Entry>();
        }

        public List<Entry> GetAllEntrys()
        {
            // Returns the whole List of Entries
            return entries;
        }

        public void StoreEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }
    }
}