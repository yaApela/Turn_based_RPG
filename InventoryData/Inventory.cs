using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turn_based_RPG.Abstract;

namespace turn_based_RPG.InventoryData
{
    public class Inventory: IGameObject
    {
        private const int inventorySize = 50;
        public List<Item> items { get; }
        public Inventory() => items = new List<Item>();
        public void RemoveItem(int index) => items.RemoveAt(index);
        public List<Item> GetItems() => items;
        public void AddItem(Item item)
        {
            if (items.Count <= inventorySize)
                items.Add(item);
            else
                Console.WriteLine("Инвентарь переполнен");
        }
        public void AddItem(List<Item> items)
        {
            foreach (var item in items)
            {
                if (this.items.Count <= inventorySize){
                    this.items.Add(item);
                }
                else{
                    Console.WriteLine("Инвентарь переполнен");
                    break;
                }
            }
        }
        public void GetInformation()
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i].GetInformation();
                Console.WriteLine(new string('-',50));
            }
        }
    }
}
