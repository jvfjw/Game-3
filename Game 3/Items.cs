using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class Items
    {
        public int id;
        public string? name;
        public string? description;
        public int? minDamage;
        public int? maxDamage;

        public Items(int id, string? name, string? description, int? minDamage, int? maxDamage)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }
    }
}
