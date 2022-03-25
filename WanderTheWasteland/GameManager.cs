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
        static RandomMoveEnemy randomMoveEnemy = new RandomMoveEnemy();
        static VerticalSetEnemy verticleEnemy = new VerticalSetEnemy();
        static TrackingEnemy trackingEnemy = new TrackingEnemy();

        static bool gameOver = false;

        public void RunGame()
        {
            // hide cursor
            Console.CursorVisible = false;
            
            while (gameOver == false)
            {
                // DRAWS
                map.DrawFromFile();                
                healthPack1.Draw();
                powerBuff1.Draw();
                speedBuff1.Draw();
                randomMoveEnemy.Draw(hud);
                verticleEnemy.Draw(hud);
                trackingEnemy.Draw(hud);
                hud.DisplayBorder();
                hud.DisplayHUD(player1, randomMoveEnemy, verticleEnemy, trackingEnemy);
                //hud.DisplayModularHUD(player1, enemy1, enemy2, enemy3);

                // PLAYER (if speed buffed)
                if (player1.speedBuffed == true)
                {
                    for (int i = 0; i < player1.speedBoost; i++)
                    {
                        player1.Draw(hud);
                        player1.Update(ref gameOver, map, player1, randomMoveEnemy, verticleEnemy, trackingEnemy, healthPack1, powerBuff1, speedBuff1, hud);
                        map.DrawFromFile();
                        healthPack1.Draw();
                        powerBuff1.Draw();
                        speedBuff1.Draw();
                        player1.Draw(hud);
                        randomMoveEnemy.Draw(hud);
                        verticleEnemy.Draw(hud);
                        trackingEnemy.Draw(hud);
                    }
                }

                // UPDATES
                else
                player1.Draw(hud);
                player1.Update(ref gameOver, map, player1, randomMoveEnemy, verticleEnemy, trackingEnemy, healthPack1, powerBuff1, speedBuff1, hud);
                map.Update();
                randomMoveEnemy.Update(map, randomMoveEnemy, verticleEnemy, trackingEnemy, player1, hud);
                verticleEnemy.Update(map, randomMoveEnemy, verticleEnemy, trackingEnemy, player1, hud);
                trackingEnemy.Update(map, randomMoveEnemy, verticleEnemy, trackingEnemy, player1, hud);
            }
        }
    }
}
