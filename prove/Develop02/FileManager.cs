using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Develop02
{
    class FileManager
    {
        public FileManager()
        {

        }
        public void saveToFile() { }

        public string readFromFile(string fileName)
        {
            // TODO Maybe use a try catch when opeing the file?
            string fileContent = "";
            String line;
            

            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(fileName);
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                fileContent += line;
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();

            // Return the file contents as a string
            return fileContent;
        }
    }
}
