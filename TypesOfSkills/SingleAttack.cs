using System;
using System.Collections.Generic;
namespace turn_based_RPG.TypesOfSkills
{
    public class SingleAttack: SkillType
    {
        public override string type => TypeSkill[1];
        public override string area => TypeSkillArea[0];
        public override void MethodAction(Entity entity, int power)
        {
            entity.SetHealth(entity.health - power);
        }

    }
}
