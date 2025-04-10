using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    //This class will be used as template for all enemies in the game, thinking about adding a special boss enemy class that inherits from this class
    class Enemy
    {
        public int id;
        public string? name;
        public int level;
        public int health;
        public int maxHealth;
        public int minDamage;
        public int maxDamage;
    }
}
