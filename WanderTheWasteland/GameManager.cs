﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{

    class GameManager
    {
        static Player player1 = new Player();
        static Enemy enemy1 = new Enemy();
        static Map map = new Map();
        static HUD hud = new HUD();

        static bool gameOver = false;

        public void RunGame()
        {
            player1.PlayerInit();
            enemy1.EnemyInit();
            
            // hide cursor
            Console.CursorVisible = false;

            while (gameOver == false)
            {
                // draws
                map.Draw();
                player1.Draw();
                enemy1.Draw();
                hud.DisplayHUD(player1, enemy1);

                // updates
                map.Update();
                player1.Update(ref gameOver, map, player1, enemy1);
                enemy1.Update(map, enemy1, player1);

            }
        }
    }
}
