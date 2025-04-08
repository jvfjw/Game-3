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


        /* I will utilize the constructor to initialize the scene controller with an id and a player.
        // This will allow me to create a scene controller for each player in the game. */
        public SceneController(int id, Player? player)
        {
            this.id = id;
            this.player = player;
        }


    }
}
