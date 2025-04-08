using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class Player
    {
        public int id;
        public string name;
        public int level;
        public int health;
        public int maxHealth;
        public int minDamage;
        public int maxDamage;
        public Inventory inventory;
        public SceneController sceneController;


        //everything player related is in this class
        public Player(int id, string name, int level, int health, int maxHealth, int minDamage, int maxDamage)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.health = health;
            this.maxHealth = maxHealth;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            inventory = new Inventory(id, this);
            sceneController = new SceneController(id, this);
        }

        public void showStats()
        {
            Console.Clear();
            Console.WriteLine($"Player: {name}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Health: {health}/{maxHealth}");
            Console.WriteLine($"Damage: {minDamage}-{maxDamage}");
            Console.ReadKey();
        }



    }
}
