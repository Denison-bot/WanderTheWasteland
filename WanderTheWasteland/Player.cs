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
        public bool speedBuffed = false;
        public int speedBoost;

        
        public void PlayerInit()
        {
            intendedPosX = 8;
            intendedPosY = 2;
            currentHealth = 1;
            maxHealth = 3;
            attack = 1;
            name = "Player";
            speedBoost = 1;
        }

        public void Draw()
        {
            //Console.Clear();
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;
            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkGray;
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

        public void Update(ref bool gameOver, Map map, Player player, Enemy enemy, Enemy2 enemy2, Item item, Item item2, Item item3)
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            if (currentHealth > 0)
            {
                if (input == 'w')
                {
                    intendedPosY--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY++;
                        Console.Beep(100, 50);
                    }
                    if (player.Attacking(player, enemy, enemy2) == true)
                    {
                        intendedPosY++;
                        enemy.TakeDamage(player, enemy);
                        Console.Beep(200, 100);
                    }
                    if (player.PickUpItem(player, item) == true)
                    {
                        item.UseItem(item, player);
                    }
                    if (player.PickUpItem(player, item2) == true)
                    {
                        item2.UseItem(item2, player);
                    }
                    if (player.PickUpItem(player, item3) == true)
                    {
                        item3.UseItem(item3, player);
                    }
                }
                else if (input == 's')
                {
                    intendedPosY++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosY--;
                        Console.Beep(100, 50);
                    }
                    if (player.Attacking(player, enemy, enemy2) == true)
                    {
                        intendedPosY--;
                        enemy.TakeDamage(player, enemy);
                        Console.Beep(200, 100);
                    }
                    if (player.PickUpItem(player, item) == true)
                    {
                        item.UseItem(item, player);
                    }
                    if (player.PickUpItem(player, item2) == true)
                    {
                        item2.UseItem(item2, player);
                    }
                    if (player.PickUpItem(player, item3) == true)
                    {
                        item3.UseItem(item3, player);
                    }
                }
                else if (input == 'a')
                {
                    intendedPosX--;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX++;
                        Console.Beep(100, 50);
                    }
                    if (player.Attacking(player, enemy, enemy2) == true)
                    {
                        intendedPosX++;
                        enemy.TakeDamage(player, enemy);
                        Console.Beep(200, 100);
                    }
                    if (player.PickUpItem(player, item) == true)
                    {
                        item.UseItem(item, player);
                    }
                    if (player.PickUpItem(player, item2) == true)
                    {
                        item2.UseItem(item2, player);
                    }
                    if (player.PickUpItem(player, item3) == true)
                    {
                        item3.UseItem(item3, player);
                    }
                }
                else if (input == 'd')
                {
                    intendedPosX++;
                    if (map.IsWall(intendedPosX, intendedPosY) == true)
                    {
                        intendedPosX--;
                        Console.Beep(100, 50);
                    }
                    if (player.Attacking(player, enemy, enemy2) == true)
                    {
                        intendedPosX--;
                        enemy.TakeDamage(player, enemy);
                        Console.Beep(200, 100);
                    }
                    if (player.PickUpItem(player, item) == true)
                    {
                        item.UseItem(item, player);
                    }
                    if (player.PickUpItem(player, item2) == true)
                    {
                        item2.UseItem(item2, player);
                    }
                    if (player.PickUpItem(player, item3) == true)
                    {
                        item3.UseItem(item3, player);
                    }
                }
                else if (input == 'p')
                {
                    gameOver = true;
                }
            }
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
