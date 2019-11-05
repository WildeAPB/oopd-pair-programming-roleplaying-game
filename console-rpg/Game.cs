using System;
using System.Collections.Generic;
using System.Text;

namespace console_rpg
{
    public class Game  //Game class that handles the "game" part of the game; e.g. menus, gameplay, etc. Individual characters will be handled by other classes.
    {
        private Player player; // Create a Player variable which we can intantiate later.s
        
        public void Setup() //Setup method. Allows us to grab some data off of the user in order to run the game how they want it.
        {
            string playerName, playerClass; // Create 2 new strings for storing the player name and class later on in this method.
            

            Console.Clear(); // Clear screen so that it stays looking nice and clean.
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Enter a character name:");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(24, 2); // This is used to set the cursor next to the "enter character name" bit. Basically; makes it look nicer.
            playerName = Console.ReadLine(); // Print some text to the screen and then ask the user to enter a character name. Set the character name variable to whatever the user enters in that line.

            Console.Clear(); // Clear screen so that it stays looking nice and clean.
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Choose a class:");
            Console.WriteLine("1 | Stalwart Knight");
            Console.WriteLine("2 | Elven Hunter");
            Console.WriteLine("3 | Fairy Princess");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.CursorVisible = false; // Print some text to the screen to inform the user about their class choices. Hide the cursor, again to make it look nice.
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': playerClass = "Stalwart Knight"; break;
                case '2': playerClass = "Elven Hunter"; break;
                case '3': playerClass = "Fairy Princess"; break;
                default: playerClass = "Generic Scrub"; break;
            } // Switch Case to choose player class. Here we're using Console.ReadKey() to directly put the user's input without needing another variable.
              // .KeyChar gets the character of that key rather than using the ConsoleKey of the key pressed.
              // We then take the user's key press and set playerClass accordingly.

            player = new Player(1, playerName, playerClass);
            // Finally we create a new instance of Player and pass the variables we got of the user to it.
        }

        public void MainMenu() // Basic Method for creating Main Menu the user can interact with.
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("1 | Start Story Mode");
            Console.WriteLine("2 | Start Random Battle");
            Console.WriteLine("3 | Options Menu");
            Console.WriteLine("4 | Exit");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': StoryMode();  break;
                case '2': RandomBattle(); break;
                case '3': OptionsMenu();  break;
                case '4': Environment.Exit(0);  break;
                default: break;
            } // Again, here we use the same Switch on a read key to get the user to choose an option.
              // Differing to the Setup() Switch we instead just call a method depending on user input.
        }

        private void OptionsMenu() // Options menu method to allow the user to change aspects of the program.
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine($"1 | Change Name: {player.Name}");
            Console.WriteLine($"2 | Change Level: {player.Level}");
            Console.WriteLine($"3 | Change Class: {player.Class}");
            Console.WriteLine("4 | DEBUG: Test Player Objects");
            Console.WriteLine("5 | Export Character Sheet");
            Console.WriteLine("6 | Return to Menu");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            switch(Console.ReadKey(true).KeyChar)
            {
                case '1': // Here we will allow the user to change their character name.
                    Console.SetCursorPosition(17, 2);
                    foreach(char c in player.Name)
                    {
                        Console.Write(" ");
                    }
                    Console.CursorVisible = true;
                    Console.SetCursorPosition(17, 2);
                    player.Name = Console.ReadLine();
                    Console.CursorVisible = false;
                    break;
                case '2': // Here we will allow the user to cheat their player level, making the character stronger.
                    Console.SetCursorPosition(18, 3);
                    foreach(char c in player.Level.ToString())
                    {
                        Console.Write(" ");
                    }
                    Console.CursorVisible = true;
                    Console.SetCursorPosition(18, 3);
                    player.Level = int.Parse(Console.ReadLine());
                    Console.CursorVisible = false;
                    break;
                case '3': // Here we will allow the user to change their character class.
                    Console.Clear();
                    Console.WriteLine("-------------------");
                    Console.WriteLine();
                    Console.WriteLine("Choose a class:");
                    Console.WriteLine("1 | Stalwart Knight");
                    Console.WriteLine("2 | Elven Hunter");
                    Console.WriteLine("3 | Fairy Princess");
                    Console.WriteLine();
                    Console.WriteLine("-------------------");
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1': player.Class = "Stalwart Knight"; break;
                        case '2': player.Class = "Elven Hunter"; break;
                        case '3': player.Class = "Fairy Princess"; break;
                        default: player.Class = "Generic Scrub"; break;
                    }
                    break;
                case '4': // Here we will populate the screen with some test characters to show that the character classes are functioning.
                    DebugCharacterClasses();
                    break;
                case '5': // Here we will allow the user to export a .TXT file that tells them about their character. We could also use this to load stuff in future.
                    ProfileGenerator();
                    break;
                case '6': // And this one just goes back to MainMenu().
                    MainMenu();
                    break;
                default: break;
            }

            OptionsMenu(); // Once the user has changed an option, we will automatically refresh the OptionsMenu().
        }

        private void DebugCharacterClasses()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Test for Character class:");
            Console.WriteLine();
            Character testCharacter = new Character(5, "NPC One");
            Console.WriteLine($"Name: {testCharacter.Name}");
            Console.WriteLine($"Level: {testCharacter.Level}");
            Console.WriteLine($"Health: {testCharacter.Health}");
            Console.WriteLine($"Armour: {testCharacter.Armour}");
            Console.WriteLine($"Energy: {testCharacter.Energy}");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Test for Player class:");
            Console.WriteLine();
            Player testPlayer = new Player(15, "Player Two", "Generic Player Class");
            Console.WriteLine($"Name: {testPlayer.Name}");
            Console.WriteLine($"Level: {testPlayer.Level}");
            Console.WriteLine($"Health: {testPlayer.Health}");
            Console.WriteLine($"Armour: {testPlayer.Armour}");
            Console.WriteLine($"Energy: {testPlayer.Energy}");
            Console.WriteLine($"Class: {testPlayer.Class}");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Test for Enemy class:");
            Console.WriteLine();
            Enemy testEnemy = new Enemy(7, "Big Ol' Orc Chieftain", 3);
            Console.WriteLine($"Name: {testEnemy.Name}");
            Console.WriteLine($"Level: {testEnemy.Level}");
            Console.WriteLine($"Health: {testEnemy.Health}");
            Console.WriteLine($"Armour: {testEnemy.Armour}");
            Console.WriteLine($"Energy: {testEnemy.Energy}");
            Console.WriteLine($"Aggressiveness: {testEnemy.Aggressiveness}");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("----------------------");

            OptionsMenu();
        }

        private void ProfileGenerator()
        {
            var stringBuilder = new StringBuilder();
            string profileTitle = $"Character profile for {player.Name}";
            string profileTitleUnderline = null;
            foreach(char letter in profileTitle)
            {
                profileTitleUnderline += "-";
            }
            string profileLevel = $"Level: {player.Level}";
            string profileClass = $"Class: {player.Class}";
            string profileHealth = $"Health: {player.Health}";
            string profileArmour = $"Armour: {player.Armour}";
            string profileEnergy = $"Energy: {player.Energy}";
            string profileStatsUnderline = profileTitleUnderline;
            string storyModeYN = player.StoryModeCompleted == true ? "Yes" : "No";
            string profileStoryModeCompleted = $"Story Mode Completed? {storyModeYN}";
            string profileStoryModeCompletions = $"Story Mode Completions: {player.StoryModeCompletions}";
            string profileArenaModeCompletions = $"Arena Mode Completions: {player.ArenaModeCompletions}";

            stringBuilder.Append(profileTitle)
                .Append(profileTitleUnderline)
                .Append(profileLevel)
                .Append(profileClass)
                .Append(profileHealth)
                .Append(profileEnergy)
                .Append(profileStatsUnderline)
                .Append(profileStoryModeCompleted)
                .Append(profileStoryModeCompletions)
                .Append(profileArenaModeCompletions);

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.Directory.CreateDirectory(docPath + "/console-rpg");
        }

        private void StoryMode()
        {

        }

        private void RandomBattle()
        {

        }
    }
}
