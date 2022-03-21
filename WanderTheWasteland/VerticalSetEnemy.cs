using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class VerticalSetEnemy : GameCharacter
    {
        private bool movingUp = true;

        public void EnemyInit()
        {
            intendedPosX = 17;
            intendedPosY = 5;
            currentHealth = 3;
            maxHealth = 3;
            attack = 5;
            name = "Vertical Enemy";
            //attackedLast = false;
        }
        public void Draw(HUD hud)
        {
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;

            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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

        public void Update(Map map, RandomMoveEnemy enemy, VerticalSetEnemy enemy2, TrackingEnemy enemy3, Player player, HUD hud)
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
                    if (enemy.Attacking(player, enemy, enemy2, enemy3, hud) == true)
                    {
                        intendedPosY++;
                        player.TakeDamage(enemy, player, hud);
                        Console.Beep(150, 100);
                    }
                }
                else if (movingUp == false){
                    intendedPosY++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY--;
                        movingUp = true;
                    }
                    if (enemy.Attacking(player, enemy, enemy2, enemy3, hud) == true)
                    {
                        intendedPosY--;
                        player.TakeDamage(enemy, player, hud);
                        Console.Beep(150, 100);
                    }
                }        
            }
        }
    }
}

//public void Update(Map map, Enemy enemy, Player player)
//{

//    Random rnd = new Random();
//    int nextMove = rnd.Next(1, 5);
//    if (currentHealth > 0)
//    {
//        if (nextMove == up)
//        {
//            intendedPosY--;
//            if (map.IsWall(intendedPosX, intendedPosY) == true)
//            {
//                intendedPosY++;
//            }
//            if (enemy.Attacking(player, enemy) == true)
//            {
//                intendedPosY++;
//                player.TakeDamage(enemy, player);
//                Console.Beep(150, 100);
//            }
//        }
//        else if (nextMove == down)
//        {
//            intendedPosY++;
//            if (map.IsWall(intendedPosX, intendedPosY) == true)
//            {
//                intendedPosY--;
//            }
//            if (enemy.Attacking(player, enemy) == true)
//            {
//                intendedPosY--;
//                player.TakeDamage(enemy, player);
//                Console.Beep(150, 100);
//            }
//        }
//        else if (nextMove == left)
//        {
//            intendedPosX--;
//            if (map.IsWall(intendedPosX, intendedPosY) == true)
//            {
//                intendedPosX++;
//            }
//            if (enemy.Attacking(player, enemy) == true)
//            {
//                intendedPosX++;
//                player.TakeDamage(enemy, player);
//                Console.Beep(150, 100);
//            }
//        }
//        else if (nextMove == right)
//        {
//            intendedPosX++;
//            if (map.IsWall(intendedPosX, intendedPosY) == true)
//            {
//                intendedPosX--;
//            }
//            if (enemy.Attacking(player, enemy) == true)
//            {
//                intendedPosX--;
//                player.TakeDamage(enemy, player);
//                Console.Beep(150, 100);
//            }
//        }
//    }
//}