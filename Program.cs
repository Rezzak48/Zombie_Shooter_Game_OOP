using System;
using System.IO;

namespace Shoot_Zombies_Game_OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = "map.txt";
            string[] allLines = File.ReadAllLines(path);
            string[] characters = new string[10];
            for (int i = 0; i < allLines.Length; i++)
            {
                string[] characters = allLines[i].Split()
            }
            // char[,] map =
            Console.ReadLine();
        }
    }
}