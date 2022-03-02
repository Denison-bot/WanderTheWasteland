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

        static bool gameOver = false;

        public void RunGame()
        {
            player1.PlayerInit();
            enemy1.EnemyInit();
            healthPack1.InitHealth();
            
            // hide cursor
            Console.CursorVisible = false;

            while (gameOver == false)
            {
                // draws
                map.DrawFromFile();
                player1.Draw();
                enemy1.Draw();
                healthPack1.Draw(1, 1);
                hud.DisplayHUD(player1, enemy1);

                // updates
                map.Update();
                player1.Update(ref gameOver, map, player1, enemy1, healthPack1);
                enemy1.Update(map, enemy1, player1);

            }
        }
    }
}
