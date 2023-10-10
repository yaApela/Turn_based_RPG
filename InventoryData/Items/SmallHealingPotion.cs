using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turn_based_RPG.Abstract;

namespace turn_based_RPG.InventoryData.Items
{
    class SmallHealingPotion : Item
    {
        public override string name => "Малое зелье здоровья";
        public override string type => TypeItem[0];
        public override int power => 10;
        public override int price => 10;
        public override void Action()
        {
            Global.player.SetHealth(Global.player.health + power);
            Console.WriteLine($"Здоровье +{power}");
        }
    }
}
