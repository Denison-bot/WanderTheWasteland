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
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("//    " + player.name + " health: " + player.health + "/" + player.maxHealth + "    //");
            Console.WriteLine("//////////////////////////////");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("//    " + enemy.name + " health: " + enemy.health + "/" + enemy.maxHealth + "     //");
            Console.WriteLine("//////////////////////////////");

        }
    }
}
