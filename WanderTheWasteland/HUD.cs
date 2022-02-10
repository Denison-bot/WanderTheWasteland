using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class HUD
    {
        public void DisplayHUD(Player player, Enemy enemy)
        {
            Console.SetCursorPosition(50, 20);
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("// PLAYER HEALTH: " + player.health + "//");
            Console.WriteLine("//////////////////////////////");
        }
    }
}
