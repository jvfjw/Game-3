﻿using Game_3;
using System;
using System.Xml.Linq;


bool menuRunning = true;
bool gameRunning = false;

//setting the Player and SceneController objects

Player player = new Player(1, "Default", 1, 100, 100, 5, 10);
SceneController sceneController = new SceneController(1, player);
player.inventory.AddItem(Items.scrapGun); //test can erase later
player.inventory.AddItem(Items.scrapSword); //test
player.inventory.AddItem(Items.bandage); // test
player.inventory.AddItem(Items.unknown); //test

while (menuRunning)
{
    Console.WriteLine("Welcome to the game!");
    Console.WriteLine("1. Start Game");
    Console.WriteLine("2. Exit");
    Console.Write("Please select an option: ");
    string? input = Console.ReadLine();
    switch (input)
    {
        case "1":
            
            Console.WriteLine("Select a name for your character");
            string? name = Console.ReadLine();
            player.name = name;
            menuRunning = false;
            gameRunning = true;
            break;
        case "2":
            menuRunning = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

while (gameRunning)
{
    Console.WriteLine("1. Show Player Stats");
    Console.WriteLine("2. Show Inventory");
    Console.WriteLine("3. Exit Game");
    Console.WriteLine("4. Select item");
    Console.Write("Please select an option: ");
    string? input = Console.ReadLine();
    switch (input)
    {
        case "1":
            player.showStats();
            break;
        case "2":
            player.inventory.ShowInventory();
            break;
        case "3":
            gameRunning = false;
            break;
        case "4":
            Console.WriteLine("Select an item to equip:\n");
            player.inventory.ShowInventory();
            Console.WriteLine("Enter the ID of the item you want to equip:");
            input = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int itemId))
            {
                Console.WriteLine("Invalid input. Please enter a valid item ID.");
                break;
            }
            player.inventory.selectItem(player, int.Parse(input));
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

