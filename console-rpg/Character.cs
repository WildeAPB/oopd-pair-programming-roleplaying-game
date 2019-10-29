using System;
using System.Collections.Generic;
using System.Text;

namespace console_rpg
{
    class Character
    {
        protected int health, armour, energy;
        protected string name;

        public string Name
        {
            get { return this.name; }
        }
    }
}
