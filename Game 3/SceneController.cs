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

        public SceneController(int id, Player? player)
        {
            this.id = id;
            this.player = player;
        }


    }
}
