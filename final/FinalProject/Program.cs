using System.Collections.Generic;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO maybe make another class called Game.cs to store all this gunk.
            /*========================================================*\
            || Runs and create's the main stack.                      ||
            ||                                                        ||
            \*========================================================*/

            // ----------------- player 1 & 2   class instantiation ----------------- \\
            Charicter player1 = null;
            Charicter player2 = null;

            // ----------------- player 1 & 2   class instantiation ----------------- \\
            Turn turn = new Turn();

            // Menu choosen charicter idicaters   
            string playerCharName1 = "Select Charicter";
            string playerCharName2 = "Select Charicter";

            // --------- player diffrent charicter info class instantiation --------- \\
            // TODO move this to be read from a file in the future
            Charicter flamout = new Charicter("Flamout", "fire monkey", 10, 160, 50);
            Charicter rockout = new Charicter("Rockout", "Earthen turtle", 10, 200, 30);
            Charicter slizzar = new Charicter("Slizzar", "Grass Snacke", 10, 120, 100);
            Charicter tailwind = new Charicter("Tailwind", "Air Hawk", 10, 130, 80);

            List<Charicter> chars = new List<Charicter> {
                flamout,
                rockout,
                slizzar,
                tailwind
            };

            // ----------------- User Interface class instantiation ----------------- \\
            UserInterface UI = new UserInterface();

            bool exit = false;
            Action player1Action = null;
            Action player2Action = null;
            int userAction = UI.MainMenu(playerCharName1, playerCharName2);

            while (exit == false)
            {
                // Launches the chosen activity
                switch (userAction)
                {
                    case 1: // Start Game
                        // Make sure both charicters 
                        if (!(playerCharName1.Equals("Select Charicter"))
                                && !(playerCharName2.Equals("Select Charicter")))
                        {
                            player1Action = UI.ActionSelection("Player 1", player1);
                            player1Action.SetInstagaterAndReciver(player1, player2);
                            turn.AddAction(player1Action);

                            player2Action = UI.ActionSelection("Player 2", player2);
                            player2Action.SetInstagaterAndReciver(player2, player1);
                            turn.AddAction(player2Action);

                            // TODO figure out how to allow user to exit with out 
                            //          kicking user back to Main Menu.

                        }
                        else
                        {
                            UI.SendErrorMSG("Select charicters.");

                            // kick user back to Main Menu
                            userAction = 5;
                        }
                        break;

                    case 2: // Set player 1
                        player1 = UI.CharicterSelection(chars);
                        playerCharName1 = player1.GetName();

                        // Send player back to main menu 
                        userAction = 5;
                        break;

                    case 3: // Set player 2
                        player2 = UI.CharicterSelection(chars);
                        playerCharName2 = player2.GetName();

                        // Send player back to main menu 
                        userAction = 5;
                        break;

                    case 4: // Quit game
                        exit = true;
                        UI.GoodByeMsg();
                        break;

                    case 5: // Return to MainMenu
                        userAction = UI.MainMenu(playerCharName1, playerCharName2);
                        break;
                }
            }
        }
    }
}