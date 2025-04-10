using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_3
{
    class Inventory
    {
        public int id;
        
        public List<Items>? items;

        //Utilizing the constructor to initialize the inventory with an id and a player. So i can assign a inventory to a player.

        public Inventory(int id, Player? player)
        {
            this.id = id;
           
            items = new List<Items>();
        }

        //Method to add items to the inventory

        public void AddItem(Items item)
        {
            items?.Add(item);
        }

        //Method to remove items from the inventory
        public void RemoveItem(Player player, int id)
        {
            player.inventory.items?.RemoveAll(i => i.id == id);
        }

        public void ShowInventory(Player player)
        {
            Console.Clear();
            
            Console.WriteLine("Inventory: ");
            
            if (player.inventory.items != null && player.inventory.items.Count > 0)
            {
                foreach (var item in player.inventory.items)
                {
                    Console.WriteLine($"- ID: {item.id}, {item.name}: {item.description}");
                }
            }
            if (player.equippedItem != null)
                Console.WriteLine($"\nEquipped item: {player.equippedItem.name}: {player.equippedItem.description}");
            else
                Console.WriteLine("\nEqquiped item: No item equipped.");

                Console.WriteLine("\n\n");
            Console.WriteLine("1. Equip a weapon");
            Console.WriteLine("2. Use an item");
            Console.WriteLine("3. Exit");

            string? input = Console.ReadLine();
            
            switch(input)
            {
                case "1":
                    player.selectItem(player);
                    break;
                case "2":
                    player.healPlayer(player);
                    break;
                case "3":
                    break;
            }
        }

        public void ShowWeapons(Player player)
        {
            Console.Clear();

            Console.WriteLine("Weapons:\n");

            foreach(var weapon in player.inventory.items)
            {
                if(weapon.minDamage == null || weapon.maxDamage == null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"id: {weapon.id} - {weapon.name} - {weapon.description}");
                }

            }
            Console.WriteLine("\n\n");
        }

        public void ShowUsableItems(Player player)
        {
            if (player.inventory.items != null && player.inventory.items.Count > 0)
            {
                foreach (var item in player.inventory.items)
                {
                    if (item.usable == true)
                        Console.WriteLine($"- ID: {item.id}, {item.name}: {item.description}");
                    else
                        continue;
                }
                
            }
        }

    }
}
