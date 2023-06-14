using System;

namespace Develop04
{
    class UserInterface
    {
        public void PrintMsg(string msg)
        {
            // Prints msg with no required input
        }

        public void CollectInput(string msg)
        {
            // Collects response answers
            // Will return a string
        }

        public int CollectInput()
        {
            // Will return an int
            // Collects duration responses
            return 0;
        }

        public void Menu() {
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflection activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit.");
            Console.Write("Enter a number to select an option: ");
            int input = Console.Read();
        }
    }
}