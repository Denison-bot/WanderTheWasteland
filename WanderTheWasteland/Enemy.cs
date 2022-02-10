using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    
    class Enemy : GameCharacter
    {
        private const int up = 1;
        private const int down = 2;
        private const int left = 3;
        private const int right = 4;

        public void EnemyInit()
        {
            intendedPosX = 25;
            intendedPosY = 12;
            health = 3;
        }
        public void Draw()
        {
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;

            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.WriteLine("E");
        }
        public void Update(Map map)
        {
            Random rnd = new Random();
            int nextMove = rnd.Next(1, 5);

            if (nextMove == up)
            {
                intendedPosY--;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosY++;
                }
            }
            else if (nextMove == down)
            {
                intendedPosY++;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosY--;
                }
            }
            else if (nextMove == left)
            {
                intendedPosX--;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosX++;
                }
            }
            else if (nextMove == right)
            {
                intendedPosX++;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosX--;
                }
            }
        }
    }
}
