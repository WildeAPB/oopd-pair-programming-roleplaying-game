using System;
using System.Collections.Generic;
using System.Text;

namespace console_rpg
{
    class Enemy : Character
    {
        private int aggressiveness;

        public Enemy(int level, string name, int aggressiveness) : base(level, name)
        {
            this.aggressiveness = aggressiveness;
        }

        public string Aggressiveness
        {
            get
            {
                if (this.aggressiveness <= 0)
                {
                    return "Passive";
                }
                else if (this.aggressiveness == 1)
                {
                    return "Defensive";
                }
                else if (this.aggressiveness == 2)
                {
                    return "Agressive";
                }
                else if (this.aggressiveness >= 3)
                {
                    return "Maniac";
                }
                else
                {
                    return "Unknown";
                }
            }
        }

    }
}
