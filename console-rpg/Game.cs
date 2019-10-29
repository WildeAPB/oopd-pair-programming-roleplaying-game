using System;
using System.Collections.Generic;
using System.Text;

namespace console_rpg
{
    public class Game  //Game class that handles the "game" part of the game; e.g. menus, gameplay, etc. Individual characters will be handled by other classes.
    {
        static string playerName, playerClass;
        

        public static Tuple<string, string> Setup() //Setup method. Allows us to grab some data off of the user in order to run the game how they want it.
        {
            string playerName, playerClass;
            

            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Enter a character name:");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(24, 2);
            playerName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Choose a class:");
            Console.WriteLine("1 | Stalwart Knight");
            Console.WriteLine("2 | Elven Hunter");
            Console.WriteLine("3 | Fairy Princess");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.CursorVisible = false;
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': playerClass = "knight"; break;
                case '2': playerClass = "hunter"; break;
                case '3': playerClass = "fairy"; break;
                default: playerClass = null; break;
            }

            Game.playerName = playerName;
            Game.playerClass = playerClass;

            return Tuple.Create(playerName, playerClass);
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("1 | Start Story Mode");
            Console.WriteLine("2 | Start Random Battle");
            Console.WriteLine("3 | Options Menu");
            Console.WriteLine("4 | Exit");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': StoryMode(player.Name);  break;
                case '2': RandomBattle(player); break;
                case '3': OptionsMenu();  break;
                case '4': Environment.Exit(0);  break;
                default: break;
            }
        }

        public static void OptionsMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine($"1 | Change Name: {player.Name}");
            Console.WriteLine("2 | Change Level");
            Console.WriteLine("3 | Change Class");
            Console.WriteLine("4 | DEBUG: Test Player Objects");
            Console.WriteLine("5 | Export Character Sheet");
            Console.WriteLine("6 | Return to Menu");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            switch(Console.ReadKey(true).KeyChar)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;
                default: break;
            }

            MainMenu();
        }

        public static void StoryMode(Player player)
        {

        }

        public static void RandomBattle(Player player)
        {

        }
    }
}
