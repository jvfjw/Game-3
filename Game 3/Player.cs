using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class Player
    {
        //everything player related is in this class
        public int id;
        public string name;
        public int level;
        public int health;
        public int maxHealth;
        public int minDamage;
        public int maxDamage;
        public Inventory inventory;
        public SceneController sceneController;

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
            Console.Clear();
        }

        public void CreateName(Player player)
        {
            Console.WriteLine("Select a name for your character");
            string? input = Console.ReadLine().Trim();
            if(string.IsNullOrEmpty(input))
            {
                Console.Clear();
                Console.WriteLine("Invalid name. Please try again.\n");
                CreateName(player);
            }
            else
            {
                player.name = input;
                Console.Clear();
                Console.WriteLine($"Welcome {player.name}!");
            }
        }

        public void ShowHp(Player player)
        {
            Console.Clear();
            Console.WriteLine($"{player.name} Health: {health}/{maxHealth}");
            Console.Clear();
        }
        public void healPlayer(Player player)
        {
            player.ShowHp(player);
            Console.WriteLine("Select an item to use:\n");
            player.inventory.ShowUsableItems(player);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int itemId))
            {
                Items? item = player.inventory.items?.FirstOrDefault(i => i.id == itemId);
                if (item != null)
                {
                    int sum;
                    int calc = 0;
                    player.health += (int)item.maxDamage;
                    if (player.health > player.maxHealth)
                    {
                        sum = player.health - player.health;
                        player.health = player.maxHealth; 
                        calc = (int)item.maxDamage - sum;
                    }
                    Console.WriteLine($"You used {item.name} and healed {calc} health.\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Item not found. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid item ID.");
            }
        }

        public void selectItem(Player player)
        {
            Console.Clear();

            player.inventory.ShowWeapons(player);

            Console.WriteLine("\nEnter the itemId to equip:");
            bool itemFound = false;

            while (!itemFound)
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int itemId))
                {
                    Items? item = player.inventory.items?.FirstOrDefault(i => i.id == itemId);
                    if (item != null)
                    {
                        player.minDamage = (int)item.minDamage;
                        player.maxDamage = (int)item.maxDamage;
                        Console.WriteLine($"You equipped {item.name}\nPress any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        itemFound = true;
                    }
                    else
                    {
                        Console.WriteLine("Item not found. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid item ID.");
                }
            }
        }

        public void ExportPlayer(Player player)
        {
            string playerName = player.name;
            string fileName = playerName + ".txt";
            string filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @$"..\..\..\{playerName}.txt"));

            string playerData = $"{player.name};{player.id}{player.inventory};";
        }

    }
}
