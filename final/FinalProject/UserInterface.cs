using System;
using System.Collections.Generic;

namespace final
{
    class UserInterface
    {
        private string _playerMsg = "";

        public int MainMenu(string playerSelection1, string playerSelection2)
        {
            // TODO add input validation check
            /*========================================================*\
            || Draws the main menu of the game.                       ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      playerSelection1: shows the slected charicter of  ||
            ||                              player one.               ||
            ||      playerSelection2: shows the slected charicter of  ||
            ||                              player Two.               ||
            ||                                                        ||
            || Return:                                                ||
            ||      the number of the users chosen input.             ||
            ||                                                        ||
            \*========================================================*/

            Console.Clear();

            Console.WriteLine("**Main Menu**");
            Console.WriteLine(_playerMsg);
            Console.WriteLine();
            Console.WriteLine("1. Start Game");
            Console.WriteLine($"2. Player 1: {playerSelection1}");
            Console.WriteLine($"3. Player 2: {playerSelection2}");
            Console.WriteLine("4. Exit");

            Console.Write("Select a choice from the menu: ");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            // Reset error msg after leaving the Main Menu
            _playerMsg = "";

            return input;
        }

        public Charicter CharicterSelection(List<Charicter> charList)
        {
            /*========================================================*\
            || Draws the charicter selction Menu.                     ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      charList: a list of the charicters options in the || 
            ||                      game.                             ||
            ||                                                        ||
            || Return:                                                ||
            ||      The choosen Charicter instance form charList.     ||
            ||                                                        ||
            \*========================================================*/

            int charicterNumber = 1;
            bool exit = false;
            int input = 0;

            // Loops until valid charicter number is input
            while (exit == false)
            {
                Console.WriteLine("**Charicter Selection**");
                Console.WriteLine();

                // print out _char list
                foreach (Charicter charicter in charList)
                {
                    Console.WriteLine($"{charicterNumber}. {charicter.GetName()}");
                    charicterNumber++;
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
                else if (input > charList.Count)
                {
                    Console.Write("the number you input was to large");
                    Console.Write("Please enter a valid charicter Number");
                }
                else
                {
                    exit = true;
                }
            }

            return charList[input - 1];
        }

        public Action ActionSelection(string player, Charicter instigater)
        {
            /*========================================================*\
            ||                                                        ||
            ||                                                        ||
            \*========================================================*/

            List<Action> actionsList = instigater.GetAvalableActions();
            bool exit = false;
            int input = 0;
            int index = 0;

            while (exit == false)
            {
                Console.WriteLine($"**{player}, Select Action**");
                Console.WriteLine();

                foreach (Action action in actionsList)
                {
                    Console.WriteLine($"{index + 1}. {action.GetName()}");
                    index++;
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
                else if (input > actionsList.Count)
                {
                    Console.Write("the number you input was to large");
                    Console.Write("Please enter a valid charicter Number");
                }
                else
                {
                    exit = true;
                }
            }

            return actionsList[input - 1];
        }

        public void BattleScene()
        {
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/
        }

        public void SendErrorMSG(string message)
        {
            _playerMsg = message;
        }

        public void GoodByeMsg()
        {
            Console.WriteLine("Good Bye");
        }
    }
}