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
        //I will use this class to control where the player is in the game, if he is in a scene or in combat.
        //I think i can create a save system with this class, so i can save the game and load it later. but i will do that later.
        public SceneController(Player player)
        {
            this.id = player.sceneId;
        }



    }
}
