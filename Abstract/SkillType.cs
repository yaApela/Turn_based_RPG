using System;

namespace turn_based_RPG
{
    public abstract class SkillType: IGameObject
    {
        public abstract string type { get; }
        public abstract string area { get; }
        public virtual void MethodAction(Entity entity, int health) => throw new NotImplementedException();
        public virtual void MethodAction(Entity[] entity, int health) => throw new NotImplementedException();
        public void GetInformation()
        {
            Console.WriteLine($" Тип: {type}\n Область атаки: {area}");
        }

        public static readonly string[] TypeSkill = { "Лечение", "Атака", "Защита" };
        public static readonly string[] TypeSkillArea = { "Одиночная", "По области" };
    }
}
