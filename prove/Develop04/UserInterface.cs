using System;

namespace Develop04
{
    class UserInterface
    {
        public void PrintMsg(string msg)
        {
            Console.WriteLine(msg);
        }

        public string CollectInputString(string msg)
        {
            // Collects response answers
            // Will return a string
            Console.Write(msg);
            string input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }

        public int CollectInputInt(string msg)
        {
            // Will return an int
            // Collects duration responses
            Console.Write(msg);
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return input;
        }

        public int Menu()
        {
            // Console display
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflection activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit.");
            Console.Write("Enter a number to select an option: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            return input;
        }
    }
}