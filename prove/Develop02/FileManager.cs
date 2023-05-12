using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Develop02
{
    class FileManager
    {
        public FileManager() { }
        public void saveToFile(string fileName, string fileContent)
        {
            try
            {
                //Open the File
                StreamWriter stream = new StreamWriter(fileName, true, Encoding.ASCII);

                // Writes content to file
                stream.WriteLine(fileContent);

                //close the file
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message); // Not sure on error message yet..
            }
            finally { } // Not sure if i need something here or not
        }

        public string readFromFile(string fileName)
        {
            string fileContent = "";
            try
            {
                String line;

                //Pass the file path and file name to the StreamReader constructor
                StreamReader stream = new StreamReader(fileName);

                //Read the first line of text
                line = stream.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    fileContent += line + "\n";

                    //Read the next line
                    line = stream.ReadLine();
                }
                //close the file
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("File does not exsist: " + e.Message);

            }
            finally { } // Not sure if i need something here or not

            // Return the file contents as a string
            return fileContent;
        }
    }
}
