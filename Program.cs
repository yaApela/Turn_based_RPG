using System;
using System.Collections.Generic;
using System.Linq;
using turn_based_RPG.Abstract;
using turn_based_RPG.InventoryData.Items;
using turn_based_RPG.Skills;

namespace turn_based_RPG
{
    public class Program : Global
    {
        static void Main(string[] args)
        {
            player = new Player("Геральд");
            player.GetInformation();

            List<Item> items = new List<Item>();
            items.Add(new SmallHealingPotion());

            player.inventory.AddItem(items);

            player.inventory.GetInformation();
        }
    }
}
