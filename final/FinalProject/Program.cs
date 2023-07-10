using System;
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
            Charicter player1;
            Charicter player2;

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
            
            // --------- player diffrent charicter info class instantiation --------- \\
            // TODO move this to be read from a file in the future
            Action fireBall = new Action();

            List<Action> avalableActions = new List<Action> {

            };

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
                        // Make sure both charicters 
                        if (!(playerCharName1.Equals("Select Charicter")) && !(playerCharName2.Equals("Select Charicter")))
                        {
                            UI.BattleScene();
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