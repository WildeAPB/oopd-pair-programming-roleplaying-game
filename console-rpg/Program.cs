using System;

namespace console_rpg
{
    class Program
    {
        static void Main(string[] args) //Main method is the entry point to the program.
        {
            Game.Setup(); //Run the Setup method in the Game class in order to grab the users class choice and their character name.
            Game.MainMenu(); //Run the MainMenu method in the Game class once the Setup is completed; from here the Game class takes over instead of using the Program class.
        }
    }
}
