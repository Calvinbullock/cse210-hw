using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------- User Interface class instantiation ----------------- \\
            UserInterface UI = new UserInterface();

            bool exit = false;
            int userAction = UI.MainMenu(playerCharName1, playerCharName2);

            while (exit == false)
            {
                // Launches the chosen activity
                switch (userAction)
                {
                    case 1: // Start Game
                        UI.BattleScene();
                        break;

                    case 2: // Set player 1
                        player1 = UI.CharicterSelection(_chars);
                        playerCharName1 = player1.GetName();
                        break;

                    case 3: // Set player 2
                        player2 = UI.CharicterSelection(_chars);
                        playerCharName2 = player2.GetName();
                        break;

                    case 4: // Record Event
                        exit = true;
                        UI.GoodByeMsg();
                        break;

                    case 5: // Return to mainMenu
                        userAction = UI.MainMenu(playerCharName1, playerCharName2);
                        break;
                }
            }
        }
    }
}