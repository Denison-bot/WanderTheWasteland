using System;
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
                // draws
                map.Draw();
                player1.Draw();
                enemy1.Draw();

                // updates
                map.Update();
                enemy1.Update();
                player1.Update(ref gameOver);
            }            
        }
    }
}
