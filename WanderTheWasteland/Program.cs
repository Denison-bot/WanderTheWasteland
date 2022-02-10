﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    
    class Program
    {
        static Player player1 = new Player();
        static Enemy enemy1 = new Enemy();
        static Map map = new Map();

        static bool gameOver = false;

        static void Main(string[] args)
        {
            player1.PlayerInit();
            enemy1.EnemyInit();

            while (gameOver == false)
            {
                Console.CursorVisible = false;
                

                // draws
                map.Draw();
                player1.Draw();
                enemy1.Draw();

                // updates
                map.Update();
                player1.Update(ref gameOver, map, player1, enemy1);
                enemy1.Update(map, enemy1, player1);
            }            
        }
    }
}
