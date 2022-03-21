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
        static Map map = new Map();
        static HUD hud = new HUD();
        static Health healthPack1 = new Health();
        static PowerBuff powerBuff1 = new PowerBuff();
        static SpeedBuff speedBuff1 = new SpeedBuff();
        static RandomMoveEnemy enemy1 = new RandomMoveEnemy();
        static VerticalSetEnemy enemy2 = new VerticalSetEnemy();
        static TrackingEnemy enemy3 = new TrackingEnemy();

        static bool gameOver = false;

        public void RunGame()
        {
            player1.Init();
            enemy1.Init();
            enemy2.EnemyInit();
            enemy3.EnemyInit();
            healthPack1.InitHealth();
            powerBuff1.InitPowerBuff();
            speedBuff1.InitSpeedBuff();
            
            // hide cursor
            Console.CursorVisible = false;
            
            while (gameOver == false)
            {
                // DRAWS
                map.DrawFromFile();                
                healthPack1.Draw();
                powerBuff1.Draw();
                speedBuff1.Draw();
                enemy1.Draw(hud);
                enemy2.Draw(hud);
                enemy3.Draw(hud);
                hud.DisplayBorder();
                hud.DisplayHUD(player1, enemy1, enemy2, enemy3);
                //hud.DisplayModularHUD(player1, enemy1, enemy2, enemy3);

                // PLAYER
                if (player1.speedBuffed == true)
                {
                    for (int i = 0; i < player1.speedBoost; i++)
                    {
                        player1.Draw(hud);
                        player1.Update(ref gameOver, map, player1, enemy1, enemy2, enemy3, healthPack1, powerBuff1, speedBuff1, hud);
                        map.DrawFromFile();
                        healthPack1.Draw();
                        powerBuff1.Draw();
                        speedBuff1.Draw();
                        player1.Draw(hud);
                        enemy1.Draw(hud);
                        enemy2.Draw(hud);
                        enemy3.Draw(hud);
                    }
                }

                // UPDATES
                else
                player1.Draw(hud);
                player1.Update(ref gameOver, map, player1, enemy1, enemy2, enemy3, healthPack1, powerBuff1, speedBuff1, hud);
                map.Update();
                enemy1.Update(map, enemy1, enemy2, enemy3, player1, hud);
                enemy2.Update(map, enemy1, enemy2, enemy3, player1, hud);
                enemy3.Update(map, enemy1, enemy2, enemy3, player1, hud);
            }
        }
    }
}
