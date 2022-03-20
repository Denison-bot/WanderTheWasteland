using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class TrackingEnemy : GameCharacter
    {
        public void EnemyInit()
        {
            intendedPosX = 36;
            intendedPosY = 2;
            currentHealth = 3;
            maxHealth = 3;
            attack = 1;
            name = "Tracking Enemy";
            //attackedLast = false;
        }

        public void Draw()
        {
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;

            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
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
            if (currentHealth > 0)
            {
                if (player.intendedPosY > currentPosY)
                {
                    intendedPosY++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY--;
                    }
                    if (Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosY--;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
                else if (player.intendedPosY < currentPosY)
                {
                    intendedPosY--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY++;
                    }
                    if (Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosY++;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
                if (player.intendedPosX > currentPosX)
                {
                    intendedPosX++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX--;
                    }
                    if (Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosX--;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
                else if (player.intendedPosX < currentPosX)
                {
                    intendedPosX--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX++;
                    }
                    if (Attacking(player, enemy, enemy2, enemy3) == true)
                    {
                        intendedPosX++;
                        player.TakeDamage(enemy, player);
                        Console.Beep(150, 100);
                    }
                }
            }
            
        }
    }
}
