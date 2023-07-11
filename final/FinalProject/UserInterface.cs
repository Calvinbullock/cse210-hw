using System;
using System.Threading;
using System.Collections.Generic;

namespace final
{
    class UserInterface
    {
        /*========================================================*\
        || This Class is a console based user interface.          ||
        ||                                                        ||
        \*========================================================*/

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

            Console.Write("Select a choice from the menu [1 - 4]: ");

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
                Console.Write($"Select a choice from the menu [1 - {charList.Count}]: ");

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
            || Prints menu for user to choose their action.           ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||        player: The name of the player takeing action.  ||
            ||        instigater: The charicter that is takeing       ||
            ||                      action.                           ||
            ||                                                        ||
            || Return:                                                ||
            ||        actionsList[input - 1]: the choosen action.     ||
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
                Console.Write($"Select a choice from the menu [1 - {actionsList.Count}]: ");

                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();

                // Check if valid number was input
                if (input < 1)
                {
                    Console.Write("the number you input was to small");
                    Console.Write("Please enter a valid action Number");
                }
                else if (input > actionsList.Count)
                {
                    Console.Write("the number you input was to large");
                    Console.Write("Please enter a valid action Number");
                }
                else
                {
                    exit = true;
                }
            }
            LoadingAnimation(1);
            return actionsList[input - 1];
        }

        public void BattleScene(Turn turn, Charicter player1, Charicter player2)
        {
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/

            List<string> actionSummerys = turn.EndTurn();

            foreach (string actionSummery in actionSummerys)
            {
                Console.WriteLine($"{actionSummery}");
            }
            HealthBar(player1, player2);

            Console.WriteLine("Hit enter: ");
            Console.ReadLine();
            LoadingAnimation(1);
        }

        private void HealthBar(Charicter player1, Charicter player2)
        {
            Console.WriteLine("");
            Console.WriteLine($"Player 1                    Player 2");
            Console.WriteLine($"{player1.GetBaseHealth()}/{player1.GetCurrentHealth()}                        {player2.GetBaseHealth()}/{player2.GetCurrentHealth()}");
        }

        public void SendErrorMSG(string message)
        {
            // Main Menu error msg
            _playerMsg = message;
        }

        public void GoodByeMsg()
        {
            Console.WriteLine("Good Bye");
        }

        public void LoadingAnimation(int runtime)
        {
            // Stores the animation.
            //      the animation has a base time of 4 seconds to complete
            string[] animation = { "-", "\\", "|", "/" };
            int count = 0;
            Console.WriteLine("Just a moment...");

            // loops trought the animation takes about 5 seconds
            while (count != runtime)
            {
                foreach (string value in animation)
                {
                    Thread.Sleep(800);
                    Console.Write(value);
                    Console.Write("\b");
                }
                count++;
            }
            Console.Clear();
        }
    }
}