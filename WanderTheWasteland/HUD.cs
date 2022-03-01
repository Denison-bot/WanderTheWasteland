using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class HUD
    {
        string hudBorder = "//////////////////////////////";

        public void DisplayHUD(Player player, Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 15);
            Console.Write(hudBorder);
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("//    " + player.name + " health: " + player.health + "/" + player.maxHealth + "    //");
            Console.SetCursorPosition(4, 17);
            Console.Write(hudBorder);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 18);
            Console.Write(hudBorder);
            Console.SetCursorPosition(4, 19);
            Console.WriteLine("//    " + enemy.name + " health: " + enemy.health + "/" + enemy.maxHealth + "     //");
            Console.SetCursorPosition(4, 20);
            Console.Write(hudBorder);
            // -------------------------------------------------------------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 3);
            Console.WriteLine("  " + player.name + " CORDS: " + player.currentPosX + ", " + player.currentPosY + "                              ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 4);
            Console.WriteLine("  " + enemy.name + "  CORDS: " + enemy.currentPosX + ", " + enemy.currentPosY + "                              ");


            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.SetCursorPosition(38, 8);
            //Console.WriteLine("   More Extra Mile included in the Battle Pass!");
            //Console.SetCursorPosition(38, 9);
            //Console.WriteLine("  ──────────────────────────────────────────────");
            //Console.SetCursorPosition(38, 10);
            //Console.WriteLine("         To purchase the Battle Pass:");
            //Console.SetCursorPosition(38, 11);
            //Console.WriteLine("     E-Transfer $20 to denipercey@gmail.com");

        }
    }
}
