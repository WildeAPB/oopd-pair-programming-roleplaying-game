using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace console_rpg
{
    class Compendium
    {
        Random diceRoll = new Random();
        string[] storyOneOptions = new string[10];
        string[] storyTwoOptions = new string[10];
        string[] storyThreeOptions = new string[10];
        string[] storyFourOptions = new string[10];
        string[] storyFiveOptions = new string[10];

        public Compendium()
        {
            storyOneOptions = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "storyOne.txt");
            storyTwoOptions = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "storyTwo.txt");
            storyThreeOptions = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "storyThree.txt");
            storyFourOptions = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "storyFour.txt");
            storyFiveOptions = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "storyFive.txt");
        }
    }
}
