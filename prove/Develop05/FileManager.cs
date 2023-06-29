using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Develop05
{
    ///<summary> 
    // The responibility of FileManager is to handle the reading and writeing of Journal to files.
    ///</summary> 
    class FileManager
    {
        public FileManager() { }
        public void SaveToFile(List<Goal> goals, string fileName)
        {
            /* =======================================================*\
            ||This function wirtes a list of goals to a file.         ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      Goal: the goal that will be saved to a file.      ||
            ||      String: the name of the file you want to write to.||
            \*========================================================*/

            // loops throught list to dump it all to one file
            foreach (Goal goal in goals)
            {
                string Name = goal.GetNameOfGoal();
                string description = goal.GetGoalDescription();

                try
                {
                    // Open the File
                    StreamWriter stream = new StreamWriter(fileName, true, Encoding.ASCII);

                    // Writes content to file
                    stream.WriteLine(description);

                    // TODO -----
                    // TODO -----
                    // Need to formate how all the goals are dumped to the file
                    // TODO -----

                    // Close the file
                    stream.Close();
                }
                catch (Exception except)
                {
                    Console.WriteLine("Exception: " + except.Message); // TODO Not sure on error message yet..
                }
                finally { } // Not sure if i need something here or not
            }
        }

        public List<Goal> ReadFromFile(string fileName)
        {
            string fileContent = "";
            string[] lines = { };
            List<string> subStr = new List<string>();

            // Open the file or throws an error msg
            try
            {
                lines = System.IO.File.ReadAllLines(fileName);
            }
            catch (Exception except)
            {
                Console.WriteLine("File did not open." + except.Message);
            }

            // Might be redundent loop TODO - Might be better way
            //      Loop through Lines and parse into one long string
            foreach (string line in lines)
            {
                fileContent += line + "\n"; // TODO get ride of \n?
            }

            // TODO -------- -------- Change this split to CSV formate -------- -------- TODO
            // Parses FileContent into substrings
            foreach (string index in fileContent.Split(':', StringSplitOptions.RemoveEmptyEntries))
            {
                // Adds the broken string bits to list nambe dsub
                subStr.Add(index);
            }

            // Stores the parsed file content to new entries then to journal
            int count = 0;
            while (count < subStr.Count)
            {
                // Breaks sub up into groups of 3 starting with 0 
                //      Logic is every odd that is not direcly divisable by 4 is the last 
                //      in teh groupe of three
                if (count % 2 == 0 && count % 4 != 0)
                {

                    // { TODO -------- This needs to be updated
                    // Creates new Entry instance
                    // Entry yourEntry = new Entry();

                    // Store the entries in journal
                    // yourEntry.Store(subStr[count - 1], subStr[count], subStr[count - 2]);
                    // journal.StoreEntry(yourEntry);
                    // }

                    // To skip the empty entry in sub - TODO clean out the empty new linr
                    count++;
                }
                // Normal count iteration
                count++;
            }
            // Return the file contents as a string DEBUG
            return fileContent;

        }
    }
}

// Ref for spliting strings and RemoveEmptyEntries
// https://www.youtube.com/watch?v=D8TL6lVlDYg

// Refrance for try catch on reading and writing to and from a file
// https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file

// Refrance for indexOF() and SubString() methods
// https://www.c-sharpcorner.com/UploadFile/mahesh/substring-in-C-Sharp/