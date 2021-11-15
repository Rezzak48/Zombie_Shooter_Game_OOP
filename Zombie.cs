using System;
using System.Collections.Generic;
using System.Text;

namespace Shoot_Zombies_Game_OOP
{
    internal class Zombie
    {
        private Random rnd = new Random();

        //the x-axis position is x
        //the y-axis position is y
        private int x;

        private int y;
        private bool active;

        public Zombie(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.active = true;
        }

        public Zombie() : this(0, 0)
        {
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public bool Active
        {
            set
            {
                if (value != true)
                {
                    active = value;
                }
            }
        }

        public void Move(Game game)
        {
            int targetX = x;
            int targetY = y;
            int direction = rnd.Next(4);
            switch (direction)
            {
                case (0):
                    targetX--;
                    break;

                case (1):
                    targetY++;
                    break;

                case (2):
                    targetX++;
                    break;

                case (3):
                    targetY--;
                    break;
            }
            //To DO
        }
    }
}