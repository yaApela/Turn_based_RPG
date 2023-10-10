using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_based_RPG.Abstract
{
    public abstract class Item: IGameObject
    {
        public abstract string name { get; }
        public abstract string type { get; }
        public abstract int power { get; }
        public abstract int price { get; }
        public abstract void Action();
        public void GetInformation()
        {
            Console.WriteLine($" Название: {name}.\n Тип: {type}.\n Сила: {power}.\n Стоимость: {price}гранд.");
        }

        public static readonly string[] TypeItem = { "Лечение", "Усиление" };

    }
}
