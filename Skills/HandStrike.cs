using turn_based_RPG.Elements;
using turn_based_RPG.TypesOfSkills;

namespace turn_based_RPG.Skills
{
    public class HandStrike: Skill
    {
        public override string name => "Удар рукой";
        public override int power => 5;
        public override Element element => new FireElement();
        public override SkillType skillType => new SingleAttack();
        public override void Action(Entity entity) => skillType.MethodAction(entity, power);

    }
}
