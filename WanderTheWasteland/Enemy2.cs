using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Enemy2 : GameCharacter
    {
        private const int up = 1;
        private const int down = 2;
        private const int left = 3;
        private const int right = 4;

        public void EnemyInit()
        {
            intendedPosX = 25;
            intendedPosY = 5;
            currentHealth = 3;
            maxHealth = 3;
            attack = 2;
            name = "Enemy 2";
        }
        public void Draw()
        {
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;

            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.ForegroundColor = ConsoleColor.Black;
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

        public void Update(Map map, Enemy enemy, Player player)
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
                    if (enemy.Attacking(player, enemy) == true)
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
                    if (enemy.Attacking(player, enemy) == true)
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
                    if (enemy.Attacking(player, enemy) == true)
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
                    if (enemy.Attacking(player, enemy) == true)
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