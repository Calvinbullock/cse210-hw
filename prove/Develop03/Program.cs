using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {

            string rawScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy cpaths.";

            Scripture scripture = new Scripture(rawScripture);
            UserInterface ui = new UserInterface();

            ui.Display(scripture);
        }
    }
}