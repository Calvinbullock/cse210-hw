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

                Console.WriteLine("Charicter Selection");

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