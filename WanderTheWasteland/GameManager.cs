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
        static SpeedBuff speedBuff1 = new SpeedBuff();
        //static Enemy2 enemy2 = new Enemy2();

        static bool gameOver = false;

        public void RunGame()
        {
            player1.PlayerInit();
            enemy1.EnemyInit();
            //enemy2.EnemyInit();
            healthPack1.InitHealth();
            powerBuff1.InitPowerBuff();
            speedBuff1.InitSpeedBuff();
            
            // hide cursor
            Console.CursorVisible = false;

            while (gameOver == false)
            {
                // DRAWS

                map.DrawFromFile();                
                enemy1.Draw();
                //enemy2.Draw();
                healthPack1.Draw();
                powerBuff1.Draw();
                speedBuff1.Draw();
                hud.DisplayHUD(player1, enemy1);

                // PLAYER

                if (player1.speedBuffed == true)
                {
                    for (int i = 0; i < player1.speedBoost; i++)
                    {
                        player1.Draw();
                        player1.Update(ref gameOver, map, player1, enemy1, healthPack1, powerBuff1, speedBuff1);
                        map.DrawFromFile();
                        enemy1.Draw();
                        //enemy2.Draw();
                        healthPack1.Draw();
                        powerBuff1.Draw();
                        speedBuff1.Draw();
                        player1.Draw();
                    }
                }

                // UPDATES

                else
                player1.Draw();
                player1.Update(ref gameOver, map, player1, enemy1, healthPack1, powerBuff1, speedBuff1);
                map.Update();
                enemy1.Update(map, enemy1, player1);
                //enemy2.Update(map, enemy1, player1);
            }
        }
    }
}
