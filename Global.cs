using System;
using System.Collections.Generic;
using System.Linq;

namespace turn_based_RPG
{
    public class Global
    {
        public static Player player;
        public static Random rnd;
        public static T GetRandom<T>(T[] list)
        {
            rnd = new Random();
            T randomItem = list[rnd.Next(list.Length)];
            return randomItem;
        }
        public static T GetRandom<T>(List<T> list)
        {
            rnd = new Random();
            T randomItem = list[rnd.Next(list.Count)];
            return randomItem;
        }

        public static T[] GetObjects<T>()
        {
            Type[] subclassTypes = typeof(Program).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(T))).ToArray();
            T[] objects = new T[subclassTypes.Length];
            for (int i = 0; i < subclassTypes.Length; i++)
            {
                objects[i] = (T)Activator.CreateInstance(subclassTypes[i]);
            }
            return objects;
        }

        public static T SelectClass<T>(T[] options, Func<T, string> getField)
        {
            int selectedIndex = 0;
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-> " + getField(options[i]));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   " + getField(options[i]));
                    }
                }

                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex + 1) % options.Length;
                }

            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            return options[selectedIndex];
        }
    }
}
