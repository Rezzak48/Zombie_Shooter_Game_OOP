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

        //Upload the mapo of the game from a file
        public void UploadMap()
        {
            string path = "map.txt";
            string[] allLines = File.ReadAllLines(path);
            int rows = allLines.Length;
            int columns = allLines[0].Length;
            map = new char[rows, columns];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = allLines[i][j];
                }
            }
        }

        public bool IsEmpty(int x, int y)
        {
            return 0 <= x && x < map.GetLength(1) && 0 <= y && y < map.GetLength(0) && map[x, y] == '.';
        }

        //Show the game
        public void ToConsole()
        {
            Console.Clear();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    char crntChar = map[i, j];
                    if (crntChar == '.')
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (crntChar == 'w')
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                //Console.Write("\n");
            }

            //Show Zombies
            for (int i = 0; i < zombies.Length; i++)
            {
                Console.SetCursorPosition(zombies[i].X, zombies[i].Y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write('\u263a');
                Console.ResetColor();
            }
        }

        private void ShootAt(int x, int y)
        {
            for (int i = 0; i < zombies.Length; i++)
            {
                if (zombies[i].X == x && zombies[i].Y == y)
                {
                    zombies[i].Active = false;
                }
            }
        }

        public void RunGame()
        {
            Zombie zom = new Zombie();

            while (true)
            {
                ToConsole();
                Console.SetCursorPosition(0, map.GetLength(1) + 1);
                Console.Write(" X = ");
                int x = int.Parse(Console.ReadLine());
                Console.Write(" Y = ");
                int y = int.Parse(Console.ReadLine());
                ShootAt(x, y);
                foreach (var item in zombies)
                {
                    item.Move(this);
                }
            }
        }
    }
}