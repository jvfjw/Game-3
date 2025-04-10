using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class SceneController
    {
        public int id;
        public Player? player;


        //I will use this class to control where the player is in the game, if he is in a scene or in combat.
        //I think a can create a save system with this class, so i can save the game and load it later. but i will do that later.
        public SceneController(int id, Player? player)
        {
            this.id = id;
            this.player = player;
        }


    }
}
