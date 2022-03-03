using System;
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
        static Health healthPack1 = new Health();
        static PowerBuff powerBuff1 = new PowerBuff();
        static Enemy2 enemy2 = new Enemy2();

        static bool gameOver = false;

        public void RunGame()
        {
            player1.PlayerInit();
            enemy1.EnemyInit();
            enemy2.EnemyInit();
            healthPack1.InitHealth();
            powerBuff1.InitPowerBuff();
            
            // hide cursor
            Console.CursorVisible = false;

            while (gameOver == false)
            {
                // draws
                map.DrawFromFile();
                player1.Draw();
                enemy1.Draw();
                enemy2.Draw();
                healthPack1.Draw();
                powerBuff1.Draw();
                hud.DisplayHUD(player1, enemy1);

                // updates
                map.Update();
                player1.Update(ref gameOver, map, player1, enemy1, healthPack1, powerBuff1);
                enemy1.Update(map, enemy1, player1);
                enemy2.Update(map, enemy1, player1);
            }
        }
    }
}
