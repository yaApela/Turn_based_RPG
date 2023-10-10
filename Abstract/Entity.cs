using System;
using System.Collections.Generic;

namespace turn_based_RPG
{
    public abstract class Entity: IGameObject
    {
        public abstract string name { get; }
        public virtual int _health => 100;
        public virtual int health { get; set; }
        public virtual List<Skill> skills { get; set; }
        public void SetHealth(int health) => this.health = _health < health ? _health : health;
        public void AddSkill(Skill skill) => skills.Add(skill);
        public virtual void GetInformation() => Console.WriteLine($" Имя: {name}.\n Здоровье: {health}.");

    }
}
