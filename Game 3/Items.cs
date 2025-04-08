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

        public static Items scrapGun = new Items(1, "Scrap Gun", "A gun made of scrap metal that deals 5 to 10 damage", 5, 10);
        public static Items scrapSword = new Items(2, "Scrap Sword", "A sword made of scrap metal that deals 5 to 10 damage", 5, 10);
        public static Items bandage = new Items(3, "Bandage", "A bandage to heal yourself.", null, null);
        public static Items unknown = new Items(4, "Unknown", "An unknown item.", null, null);
    }
}
