using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    
    class RandomMoveEnemy : GameCharacter
    {
        private const int up = 1;
        private const int down = 2;
        private const int left = 3;
        private const int right = 4;

        public void Init()
        {
            intendedPosX = 25;
            intendedPosY = 2;
            currentHealth = 5;
            maxHealth = 5;
            attack = 1;
            name = "Random Enemy";
            //attackedLast = false;
        }
        public void Draw()
        {
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;

            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("■");

            if (currentHealth <= 0)
            {
                PrintCorpse();
                if (currentHealth < 0)
                {
                    currentHealth = 0;
                }
            }
        }
        public void Update(Map map, RandomMoveEnemy enemy, VerticalSetEnemy enemy2, TrackingEnemy enemy3, Player player)
        {

            Random rnd = new Random();
            int nextMove = rnd.Next(1, 5);

            if (currentHealth > 0)
            {
                if (nextMove == up)
                {
                    intendedPosY--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY++;
                    }
                    if (enemy.Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosY++;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
                else if (nextMove == down)
                {
                    intendedPosY++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY--;
                    }
                    if (enemy.Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosY--;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
                else if (nextMove == left)
                {
                    intendedPosX--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX++;
                    }
                    if (enemy.Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosX++;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
                else if (nextMove == right)
                {
                    intendedPosX++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX--;
                    }
                    if (enemy.Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosX--;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
            }
        }
    }
}
//    attempt at tracking player

//    // check right
//    if (player.currentPosX == enemy.currentPosX + 1 && player.currentPosY == enemy.currentPosY)
//    {
//        player.TakeDamage(enemy, player);
//    }
//    // check left
//    else if (player.currentPosX == enemy.currentPosX - 1 && player.currentPosY == enemy.currentPosY)
//    {
//        player.TakeDamage(enemy, player);
//    }
//    // check down
//    else if (player.currentPosX == enemy.currentPosX && player.currentPosY == enemy.currentPosY + 1)
//    {
//        player.TakeDamage(enemy, player);
//    }
//    // check up
//    else if (player.currentPosX == enemy.currentPosX && player.currentPosY == enemy.currentPosY - 1)
//    {
//        player.TakeDamage(enemy, player);
//    }
