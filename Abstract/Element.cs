using System;

namespace turn_based_RPG
{
    public abstract class Element: IGameObject
    {
        public abstract string name { get;}
        public void GetInformation() { Console.Write(name); }

    }
}
