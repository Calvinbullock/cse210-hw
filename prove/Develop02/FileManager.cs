using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Develop02
{
    ///<summary> 
    // The responibility of FileManager is to handle the reading and writeing of Journal to files.
    ///</summary> 
    class FileManager
    {
        public FileManager() { }
        public void SaveToFile(string fileName, string fileContent)
        {
            // This function wirtes a string to a file
            // Paramiters:
            // String: the name of the file you want to write to
            // String the content you want to save to the file

            try
            {
                // Open the File
                StreamWriter stream = new StreamWriter(fileName, true, Encoding.ASCII);

                // Writes content to file
                stream.WriteLine(fileContent);

                // Close the file
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message); // TODO Not sure on error message yet..
            }
            finally { } // Not sure if i need something here or not
        }

        public string ReadFromFile(string fileName, Journal journal)
        {
            string fileContent = "";
            string[] lines = { };
            List<string> sub = new List<string>();

            // Open the file or through an error msg
            try
            {
                lines = System.IO.File.ReadAllLines(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine("File did not open." + e.Message); // DEBUG
            }

            // Might be redundent loop TODO - Might be better way
            // Loop through Lines and parse into one long string
            foreach (string line in lines)
            {
                fileContent += line + "\n"; // TODO get ride of \n?
            }

            // The diffrent charicters that dennote where the fileContent sting should be split
            char[] delimiters = new char[] { ':', '-', '\n' };

            // Console.WriteLine($"L.70"); // DEBUG
            // Parses FileContent into substrings
            int count = 0;
            foreach (string index in fileContent.Split(delimiters, StringSplitOptions.RemoveEmptyEntries))
            {
                // Console.WriteLine($"74: {index}, {count}"); // DEBUG
                if (count != 0) // TODO this is iniffecent it should only shceck once
                {
                    if (count % 3 == 0)
                    {
                        // Console.WriteLine($"L.79'{index}', '{count}'"); // DEBUG
                        sub.Add(index);
                    }
                    else if (count % 4 == 0)
                    {
                        // Console.WriteLine($"L.84'{index}', '{count}'"); // DEBUG
                        sub.Add(index);
                    }
                    else if (count == 1)
                    {
                        // Console.WriteLine($"L.84'{index}', '{count}'"); // DEBUG
                        sub.Add(index);
                    }
                }
                count++;
            }

            // Stores the parsed file content to new entries then to journal
            count = 0;
            foreach (string index in sub)
            {
                if (count % 3 == 0)
                {
                    // Creates new Entry instance
                    Entry yourEntry = new Entry();

                    Console.WriteLine($"L.84'{sub[count]}', '{sub[count + 1]}', '{sub[count + 2]}'"); // DEBUG
                    yourEntry.Store(sub[count + 1], sub[count + 2], sub[count]);

                    // Store the entries in journal
                    Console.WriteLine($"L.105: {yourEntry.GetAsString()}"); // DEBUG
                    journal.StoreEntry(yourEntry);
                }
                count++;
            }
            // Return the file contents as a string
            return fileContent;
        }

        public string ReadFromFile2(string fileName, Journal journal)
        {
            string fileContent = "";
            string[] lines = { };
            List<string> sub = new List<string>();

            // Open the file or through an error msg
            try
            {
                lines = System.IO.File.ReadAllLines(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine("File did not open." + e.Message); // DEBUG
            }

            // Might be redundent loop TODO - Might be better way
            // Loop through Lines and parse into one long string
            foreach (string line in lines)
            {
                fileContent += line + "\n"; // TODO get ride of \n?
            }

            // Console.WriteLine($"L.70"); // DEBUG
            // Parses FileContent into substrings
            int count = 0;
            foreach (string index in fileContent.Split(':', StringSplitOptions.RemoveEmptyEntries))
            {
                // Console.WriteLine($"L.79'{index}', '{count}'"); // DEBUG
                sub.Add(index);
                count++;
            }
            // Console.WriteLine($"L.146'{sub.Count}'"); // DEBUG

            // Stores the parsed file content to new entries then to journal
            count = 0;
            while (count < sub.Count)
            {
                // Console.WriteLine($"\nL.152 '{count}', '{sub[count]}'\n"); // DEBUG

                if (count % 2 == 0 && count % 4 != 0)
                {
                    // Creates new Entry instance
                    Entry yourEntry = new Entry();

                    // Console.WriteLine($"\nL.84 '{count}', '{sub[count - 1]}', '{sub[count]}', '{sub[count - 2]}'\n"); // DEBUG
                    yourEntry.Store(sub[count - 1], sub[count], sub[count - 2]);

                    // Store the entries in journal
                    journal.StoreEntry(yourEntry);

                    // To skip the empty entry - TODO BUG
                    count++;
                }
                count++;
            }
            // Return the file contents as a string
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