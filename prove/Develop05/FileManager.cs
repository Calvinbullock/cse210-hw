using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Develop05
{
    class FileManager
    {
        /*========================================================*\
        || Handels the saveing and loading of goal data to and    ||
        ||      from save files.                                  ||
        ||                                                        ||
        \*========================================================*/

        // TODO -- Probably a better way to so this....
        //      I need to store this so I can return it sepret from the array of goals.
        private int _totalScoreFromFile;

        public FileManager() { }
        public void SaveToFile(List<Goal> goals, int score, string fileName)
        {
            /* =======================================================*\
            ||This function wirtes a list of goals to a file.         ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      Goal: the goal that will be saved to a file.      ||
            ||      String: the name of the file you want to write to.||
            \*========================================================*/

            try
            {
                // Open the File
                StreamWriter stream = new StreamWriter(fileName, true, Encoding.ASCII);

                // Saves points at top of file
                string scoreString = score + "";
                stream.WriteLine(scoreString);

                // loops throught list to dump it all to one file
                foreach (Goal goal in goals)
                {
                    string content = goal.GetStorageString();

                    // Writes content to file
                    stream.WriteLine(content);
                }

                // Close the file
                stream.Close();
            }
            catch (FileNotFoundException except)
            {
                Console.WriteLine("Exception: " + except.Message); // TODO Not sure on error message yet..
            }
            finally { } // Not sure if i need something here or not
        }

        public List<Goal> ReadFromFile(string fileName)
        {
            /* =======================================================*\
            || This pulls data from a file and puts it into goals     || 
            ||      list then returns that list.                      ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      String: the name of the file you want to write    ||
            ||                  From.                                 ||
            \*========================================================*/
            string[] lines = { };
            List<Goal> goals = new List<Goal>();

            // Open the file or throw an error msg
            try
            {
                lines = System.IO.File.ReadAllLines(fileName);
            }
            catch (Exception except)
            {
                Console.WriteLine("File did not open." + except.Message);
            }

            // Allows first line to be skiped 
            bool firstIteration = true;

            // Parses lines into substrings data.
            foreach (string line in lines)
            {
                List<string> dataList = new List<string>();

                // Adds the broken string bits to list named substr
                foreach (string dataPart in line.Split('|', StringSplitOptions.RemoveEmptyEntries))
                {
                    dataList.Add(dataPart);
                    Console.WriteLine("93," + dataPart);
                }
                Console.WriteLine("96," + dataList.Count);

                // Goals data ready
                int goalType;
                int pointValue;
                bool isCompleted;
                string nameOfGoal;
                string description;

                // Parses the goal type indicater
                goalType = Convert.ToInt32(dataList[0]);

                if (firstIteration)
                {
                    // get the user score from first line of Goal storage file
                    firstIteration = false;

                    // Can't return this from the ReadFromFile Method
                    //      so I retturn it from a sepret method
                    _totalScoreFromFile = Convert.ToInt32(dataList[0]);
                }
                else if (goalType == 1) // Parses data for Simple goals
                {
                    pointValue = Convert.ToInt32(dataList[3]);
                    isCompleted = Convert.ToBoolean(dataList[4]);
                    nameOfGoal = dataList[1];
                    description = dataList[2];

                    SimpleGoal simpGoal = new SimpleGoal(nameOfGoal, description, pointValue, isCompleted);
                    goals.Add(simpGoal);
                }
                else if (goalType == 2) // Parses data for Eternal goals
                {
                    pointValue = Convert.ToInt32(dataList[3]);
                    isCompleted = Convert.ToBoolean(dataList[4]);
                    nameOfGoal = dataList[1];
                    description = dataList[2];

                    EteralGoal EGoal = new EteralGoal(nameOfGoal, description, pointValue, isCompleted);
                    goals.Add(EGoal);
                }
                else // Parses data for Check List goals 
                {
                    pointValue = Convert.ToInt32(dataList[3]);
                    isCompleted = Convert.ToBoolean(dataList[4]);
                    nameOfGoal = dataList[1];
                    description = dataList[2];

                    int bonuesPointsAmt = Convert.ToInt32(dataList[7]);
                    int completionsNeeded = Convert.ToInt32(dataList[5]);
                    int achivedCompletions = Convert.ToInt32(dataList[6]);

                    CheckGoal cGoal = new CheckGoal(bonuesPointsAmt, completionsNeeded, achivedCompletions, nameOfGoal, description, pointValue, isCompleted);
                    goals.Add(cGoal);
                }
            }

            // Return the file contents as a string.
            return goals;
        }

        public int GetTotalScore()
        {
            /*================================================*\
            || Can't return this from the ReadFromFile Method ||
            ||      so I retturn it from a sepret method.     ||
            \*================================================*/
            return _totalScoreFromFile;
        }
    }
}

// Ref for spliting strings and RemoveEmptyEntries
// https://www.youtube.com/watch?v=D8TL6lVlDYg

// Refrance for try catch on reading and writing to and from a file
// https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file

// Refrance for indexOF() and SubString() methods
// https://www.c-sharpcorner.com/UploadFile/mahesh/substring-in-C-Sharp/