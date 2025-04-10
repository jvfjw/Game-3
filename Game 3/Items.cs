using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class Items
    {
        //I am using the class Items to create a template for all the items in the game.
        public int id;
        public string? name;
        public string? description;
        public int? minDamage;
        public int? maxDamage;
        public bool? usable;

        public Items(int id, string? name, string? description, int? minDamage, int? maxDamage, bool? usable)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.usable = usable;
        }

        public static Items scrapGun = new Items(1, "Scrap Gun", "A gun made of scrap metal that deals 5 to 10 damage", 5, 10, false);
        public static Items scrapSword = new Items(2, "Scrap Sword", "A sword made of scrap metal that deals 5 to 10 damage", 5, 10, false);
        public static Items bandage = new Items(3, "Bandage", "A bandage to heal yourself.", null, 10, true);
        public static Items unknown = new Items(4, "Unknown", "An unknown item.", null, 20000, false);
    }
}
