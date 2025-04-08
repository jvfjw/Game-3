using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class Inventory
    {
        public int id;
        public Player? player;
        public List<Items>? items;


        public Inventory(int id, Player? player)
        {
            this.id = id;
            this.player = player;
            items = new List<Items>();
        }
    }
}
