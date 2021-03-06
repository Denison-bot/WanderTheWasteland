using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class EnemyParent : GameCharacter
    {
        private const int up = 1;
        private const int down = 2;
        private const int left = 3;
        private const int right = 4;

        bool movingUp = true;

        public void Draw(HUD hud)
        {
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;

            Console.SetCursorPosition(currentPosX, currentPosY);
            if (name == "Random Enemy")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if (name == "Vertical Enemy")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (name == "Tracking Enemy")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }

            Console.Write("■");

            if (currentHealth <= 0)
            {
                PrintCorpse(hud);
                if (currentHealth < 0)
                {
                    currentHealth = 0;
                }
            }
        }

        public void Update(Map map, RandomMoveEnemy randomMoveEnemy, VerticalSetEnemy verticalSetEnemy, TrackingEnemy trackingEnemy, Player player, HUD hud)
        {
            if (name == "Random Enemy")
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
                        if (randomMoveEnemy.Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosY++;
                            player.TakeDamage(randomMoveEnemy, player, hud);
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
                        if (randomMoveEnemy.Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosY--;
                            player.TakeDamage(randomMoveEnemy, player, hud);
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
                        if (randomMoveEnemy.Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosX++;
                            player.TakeDamage(randomMoveEnemy, player, hud);
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
                        if (randomMoveEnemy.Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosX--;
                            player.TakeDamage(randomMoveEnemy, player, hud);
                            Console.Beep(150, 100);
                        }
                    }
                }
            }
            //--------------------------------------------------------
            if (name == "Vertical Enemy")
            {
                if (currentHealth > 0)
                {                    
                    if (movingUp == true)
                    {
                        intendedPosY--;
                        if (map.IsWall(intendedPosX, intendedPosY) == true)
                        {
                            intendedPosY++;
                            movingUp = false;
                        }
                        if (verticalSetEnemy.Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosY++;
                            player.TakeDamage(verticalSetEnemy, player, hud);
                            Console.Beep(150, 100);
                        }
                    }
                    else if (movingUp == false)
                    {
                        intendedPosY++;
                        if (map.IsWall(intendedPosX, intendedPosY) == true)
                        {
                            intendedPosY--;
                            movingUp = true;
                        }
                        if (verticalSetEnemy.Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosY--;
                            player.TakeDamage(verticalSetEnemy, player, hud);
                            Console.Beep(150, 100);
                        }
                    }
                }
            }
            //--------------------------------------------------------
            if (name == "Tracking Enemy")
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
                        if (Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosY--;
                            player.TakeDamage(trackingEnemy, player, hud);
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
                        if (Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosY++;
                            player.TakeDamage(trackingEnemy, player, hud);
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
                        if (Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosX--;
                            player.TakeDamage(trackingEnemy, player, hud);
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
                        if (Attacking(player, randomMoveEnemy, verticalSetEnemy, trackingEnemy, hud) == true)
                        {
                            intendedPosX++;
                            player.TakeDamage(trackingEnemy, player, hud);
                            Console.Beep(150, 100);
                        }
                    }
                }
            }
        }
    }
}
