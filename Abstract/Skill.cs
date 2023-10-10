using System;

namespace turn_based_RPG
{
    public abstract class Skill : IGameObject
    {
        public abstract string name { get; }
        public virtual int power { get; set; }
        public abstract Element element { get; }
        public abstract SkillType skillType { get; }
        public virtual void Action(Entity entity) => throw new NotImplementedException();
        public virtual void Action(Entity[] entity) => throw new NotImplementedException();
        public void GetInformation()
        {
            Console.WriteLine($"\n Название: {name}\n Сила: {power}\n Стихия: {element.name}");
            skillType.GetInformation();
        }
        public void SetPower(int Power) => power = Power;
    }
}
