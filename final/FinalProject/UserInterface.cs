using System;
using System.Collections.Generic;

namespace final
{
    class UserInterface
    {

        public int MainMenu(string playerSelection1, string playerSelection2)
        {
            // TODO add input validation check
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/

            Console.WriteLine("Menu Items");
            Console.WriteLine("1. Start Game");
            Console.WriteLine($"2. Player 1: {playerSelection1}");
            Console.WriteLine($"3. Player 2: {playerSelection2}");
            Console.WriteLine("4. Exit");

            Console.Write("Select a choice from the menu: ");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            return input;
        }

        public Charicter CharicterSelection(List<Charicter> _charList)
        {
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/

            int charicterNumber = 0;
            bool exit = false;
            int input = 0;

            // Loops until valid charicter number is input
            while (exit == false)
            {

                Console.WriteLine("Charicter Selection");

                // print out _char list
                foreach (Charicter charicter in _charList)
                {
                    Console.WriteLine($"{charicterNumber}. {charicter.GetName()}");
                }

                // Take input for charicteer selection
                Console.Write("Select a choice from the menu: ");

                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();

                // Check if valid number was input
                if (input < 1)
                {
                    Console.Write("the number you input was to small");
                    Console.Write("Please enter a valid charicter Number");
                }
                else if (input > _charList.Count)
                {
                    Console.Write("the number you input was to large");
                    Console.Write("Please enter a valid charicter Number");
                }
                else
                {
                    exit = true;
                }
            }

            return _charList[input - 1];
        }

        public void BattleScene()
        {
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/
        }

        public void ActionSelection()
        {
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/
        }

        public void GoodByeMsg()
        {
            Console.WriteLine("Good Bye");
        }
    }
}