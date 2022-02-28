using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland 
{
    class Player : GameCharacter
    {
        static char input;
        
        public void PlayerInit()
        {
            intendedPosX = 2;
            intendedPosY = 2;
            health = 3;
            maxHealth = 3;
            attack = 1;
            name = "Player";
        }

        public void Draw()
        {
            //Console.Clear();
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;
            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("■");

            if (health <= 0)
            {
                PrintCorpse();
                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        public void Update(ref bool gameOver, Map map, Player player, Enemy enemy)
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            //if (health > 0)
            //{
            //    if (input == 'w')
            //    {
            //        intendedPosY--;
            //        if (map.IsWall(intendedPosX, intendedPosY) == true)
            //        {
            //            intendedPosY++;
            //            Console.Beep(100, 50);
            //        }
            //        if (player.Attacking(player, enemy) == true)
            //        {
            //            intendedPosY++;
            //            enemy.TakeDamage(player, enemy);
            //            Console.Beep(200, 100);
            //        }
            //    }
            //    else if (input == 's')
            //    {
            //        intendedPosY++;
            //        if (map.IsWall(intendedPosX, intendedPosY) == true)
            //        {
            //            intendedPosY--;
            //            Console.Beep(100, 50);
            //        }
            //        if (player.Attacking(player, enemy) == true)
            //        {
            //            intendedPosY--;
            //            enemy.TakeDamage(player, enemy);
            //            Console.Beep(200, 100);
            //        }
            //    }
            //    else if (input == 'a')
            //    {
            //        intendedPosX--;
            //        if (map.IsWall(intendedPosX, intendedPosY) == true)
            //        {
            //            intendedPosX++;
            //            Console.Beep(100, 50);
            //        }
            //        if (player.Attacking(player, enemy) == true)
            //        {
            //            intendedPosX++;
            //            enemy.TakeDamage(player, enemy);
            //            Console.Beep(200, 100);
            //        }
            //    }
            //    else if (input == 'd')
            //    {
            //        intendedPosX++;
            //        if (map.IsWall(intendedPosX, intendedPosY) == true)
            //        {
            //            intendedPosX--;
            //            Console.Beep(100, 50);
            //        }
            //        if (player.Attacking(player, enemy) == true)
            //        {
            //            intendedPosX--;
            //            enemy.TakeDamage(player, enemy);
            //            Console.Beep(200, 100);
            //        }
            //    }
            //    else if (input == 'p')
            //    {
            //        gameOver = true;
            //    }
            //}
        }

        public void QuitCheck(ref bool gameOver)
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            if (input == 'p')
            {
                 gameOver = true;
            }
        }
    }
}
