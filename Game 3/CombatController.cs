using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class CombatController
    {
        Player player;
        Enemy enemy;


        public CombatController(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }
        /// This method bellow will be called when the player enters combat with an enemy
        public void Start(Player player, Enemy enemy)
        {
            Console.WriteLine($"You entered combat with {enemy.name}");

        }
    }
}
