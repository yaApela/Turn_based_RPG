using System;
using System.Collections.Generic;
using turn_based_RPG.InventoryData;
using turn_based_RPG.Skills;

namespace turn_based_RPG
{
    public class Player : Entity
    {
        public override string name { get; }
        public override int health => _health;
        public override List<Skill> skills { get; set; }

        public Inventory inventory;

        public int money;
        public Player(string name)
        {
            this.name = name;
            this.skills = new List<Skill>();
            this.money = 0;
            this.inventory = new Inventory();
            AddSkill(new HandStrike());
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($" Баланс: {money}гранд.");
        }
    }
}
