using System;
using System.Collections.Generic;
using System.Text;

namespace console_rpg
{
    class Player : Character
    {
        private string playerClass;
        private bool storyModeCompleted;
        private int storyModeCompletions;
        private int arenaModeCompletions;

        public string Class
        {
            get { return this.playerClass; }
            set { this.playerClass = value; }
        }
        public bool StoryModeCompleted
        {
            get { return this.storyModeCompleted; }
        }
        public int StoryModeCompletions
        {
            get { return this.storyModeCompletions; }
        }
        public int ArenaModeCompletions
        {
            get { return this.arenaModeCompletions; }
        }


        public Player(int level, string name) : base(level, name)
        {
            this.playerClass = null;
        }
        public Player(int level, string name, string playerClass) : base(level, name)
        {
            this.playerClass = playerClass;
            this.storyModeCompleted = false;
            this.storyModeCompletions = 0;
            this.arenaModeCompletions = 1;
        }
    }
}
