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

        //Utilizing the constructor to initialize the inventory with an id and a player. So i can assign a inventory to a player.

        public Inventory(int id, Player? player)
        {
            this.id = id;
            this.player = player;
            items = new List<Items>();
        }

        //Method to add items to the inventory

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
            }

        }

        public void ShowWeapons()
        {
            Console.Clear();
            Console.WriteLine("Weapons:\n");

            foreach(var weapon in player.inventory.items)
            {
                if(weapon.minDamage == null && weapon.maxDamage == null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{weapon.id} - {weapon.name} - {weapon.description}");
                }

            }
        }
        //Verify if the player has the item in the inventory and if so, set the minDamage and maxDamage to the values of the selected item.
        public void selectItem(Player player)
        {
            Console.Clear();
            player.inventory.ShowWeapons();
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
    }
}
