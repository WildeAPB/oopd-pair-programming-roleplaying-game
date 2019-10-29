using System;
using System.Collections.Generic;
using System.Text;

namespace console_rpg
{
    class Character
    {
        protected int health, armour, energy, level;
        protected string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        public int Health
        {
            get { return this.health; }
        }
        public int Armour
        { 
            get { return this.armour; }
        }
        public int Energy
        {
            get { return this.energy; }
        }


        public Character(int level, string name)
        {
            this.level = level;
            this.name = name;

            this.health = (level * 10);
            this.armour = (level * 5);
            this.energy = 20;
        }
    }
}
