using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shoot_Zombies_Game_OOP
{
    internal class Game
    {
        private char[,] map;
        private Zombie[] zombies;

        //Initilize Create the zombies
        public void SpawnZombies(int count)
        {
            zombies = new Zombie[count];
            for (int i = 0; i < zombies.Length; i++)
            {
                zombies[i] = new Zombie();
            }
        }

        public void UploadMap()
        {
            string path = "map.txt";
            string[] allLines = File.ReadAllLines(path);
            // map = new string[allLines.Length];
            //   for (int i = 0; i < length; i++)
            {
            }
        }
    }
}