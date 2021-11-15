using System;
using System.IO;

namespace Shoot_Zombies_Game_OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game gm = new Game();
            string path = "map.txt";
            gm.UploadMap();
            gm.SpawnZombies(5);
            gm.RunGame();
            Console.ReadLine();
        }
    }
}