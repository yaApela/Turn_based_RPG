using System.Collections.Generic;
using turn_based_RPG.Elements;
using turn_based_RPG.Interfaces;
using turn_based_RPG.Skills;

namespace turn_based_RPG.Enemies
{
    public class Ghoul : Entity, IEnemy
    {
        public override string name => "Гуль";
        public override int _health => 20;
        public override int health => _health;
        public override List<Skill> skills => new List<Skill>();
        public Element weaknessElement => new FireElement();
        public Ghoul()
        {
            AddSkill(new HandStrike());
        }
        public void Attack()
        {
            Global.GetRandom<Skill>(skills).Action(Global.player);
        }
    }
}
