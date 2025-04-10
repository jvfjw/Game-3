using Game_3;
using System;
using System.Xml.Linq;


bool menuRunning = true;
bool gameRunning = false;

//setting the Player and SceneController objects

Player player = new Player(1, "Default", 1, 100, 100, 5, 10, 1);
SceneController sceneController = new SceneController(player);

player.inventory.AddItem(Items.scrapGun);
player.inventory.AddItem(Items.scrapSword);
player.inventory.AddItem(Items.scrapSword);
player.inventory.AddItem(Items.bandage);
player.inventory.AddItem(Items.unknown);
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
            Console.Clear();
            player.CreateName(player);            
            menuRunning = false;
            gameRunning = true;
            break;
        case "2":
            menuRunning = false;
            break;
        default:
            Console.Clear();
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
            player.inventory.ShowInventory(player);
            break;
        case "3":
            gameRunning = false;
            break;
        case "4":
            Console.WriteLine("Select an item to equip:\n");
            player.inventory.ShowInventory(player);
            player.selectItem(player);
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

