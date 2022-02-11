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
            intendedPosY = 9;
            health = 3;
            attack = 1;
        }
        public void Draw()
        {
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;

            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("■");

            if (health <= 0)
            {
                PrintCorpse();
            }
        }
        public void Update(Map map, Enemy enemy, Player player)
        {
            Random rnd = new Random();
            int nextMove = rnd.Next(1, 5);
            if (health > 0)
            {
                if (nextMove == up)
                {
                    intendedPosY--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY++;
                    }
                    //if (enemy.Attacking(player, enemy) == true)
                    //{
                    //    intendedPosY++;
                    //    player.TakeDamage(enemy, player);
                    //}
                }
                else if (nextMove == down)
                {
                    intendedPosY++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY--;
                    }
                    //if (enemy.Attacking(player, enemy) == true)
                    //{
                    //    intendedPosY--;
                    //    player.TakeDamage(enemy, player);
                    //}
                }
                else if (nextMove == left)
                {
                    intendedPosX--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX++;
                    }
                    if (enemy.Attacking(player, enemy) == true)
                    {
                        intendedPosX++;
                        player.TakeDamage(enemy, player);
                    }
                }
                else if (nextMove == right)
                {
                    intendedPosX++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX--;
                    }
                    if (enemy.Attacking(player, enemy) == true)
                    {
                        intendedPosX--;
                        player.TakeDamage(enemy, player);
                    }
                }
            }

        }
    }
}
