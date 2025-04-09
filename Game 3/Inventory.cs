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

        //I'am utilizing the constructor to initialize the inventory with an id and a player.

        public Inventory(int id, Player? player)
        {
            this.id = id;
            this.player = player;
            items = new List<Items>();
        }

        //I will create a method to add items to the inventory.

        public void AddItem(Items item)
        {
            items?.Add(item);
        }

        public void RemoveItem(int id)
        {
            if (items != null)
            {
                Items? itemToRemove = items.FirstOrDefault(item => item.id == id);
                if (itemToRemove != null)
                {
                    items.Remove(itemToRemove);
                }
            }

        }

        public void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("Inventory: ");
            if (items != null && items.Count > 0)
            {
                foreach (var item in items)
                {
                    Console.WriteLine($"- ID: {item.id}, {item.name} {item.description}");
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
        //Verify if the player has the item in the inventory and if so, set the minDamage and maxDamage to the values of the selected item.
        public void selectItem(Player player, int id )
        {
            if(player.inventory.items != null && player.inventory.items.Count > 0)
            {
                foreach(var item in player.inventory.items)
                {
                    if (item.minDamage != null && item.maxDamage != null && id == item.id)
                    {
                        player.minDamage = (int)item.minDamage;
                        player.maxDamage = (int)item.maxDamage;
                        Console.WriteLine($"You have selected {item.name} with damage {player.minDamage} - {player.maxDamage}");
                        break;
                    }
                }
            }
        }
    }
}
