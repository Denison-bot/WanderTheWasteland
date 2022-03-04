using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    // ATTACKEDLAST BOOL DOES NOT RESET TO FALSE AFTER COMBAT HHHHHHHHHH 

    class HUD
    {
        string hudBorderTop = "┌──────────────────────────┐";
        string hudBorderBottom = "└──────────────────────────┘";

        //public void DisplayModularHUD(Player player, Enemy enemy, Enemy2 enemy2, Enemy3 enemy3)
        //{

        //    // PLAYER STATS
        //    Console.BackgroundColor = ConsoleColor.DarkBlue;
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.SetCursorPosition(4, 15);
        //    Console.Write(hudBorderTop);
        //    Console.SetCursorPosition(4, 16);
        //    Console.WriteLine("│    " + player.name + " health: " + player.currentHealth + "/" + player.maxHealth + "    │");
        //    Console.SetCursorPosition(4, 17);
        //    Console.Write(hudBorderBottom);
        //    // ENEMY STATS
        //    if (enemy.attackedLast == true)
        //    {
        //        Console.BackgroundColor = ConsoleColor.DarkRed;
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.SetCursorPosition(4, 18);
        //        Console.Write(hudBorderTop);
        //        Console.SetCursorPosition(4, 19);
        //        Console.WriteLine("│    " + enemy.name + " health: " + enemy.currentHealth + "/" + enemy.maxHealth + "   │");
        //        Console.SetCursorPosition(4, 20);
        //        Console.Write(hudBorderBottom);
        //    }
        //    else if (enemy2.attackedLast == true)
        //    {
        //        Console.BackgroundColor = ConsoleColor.DarkYellow;
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.SetCursorPosition(4, 18);
        //        Console.Write(hudBorderTop);
        //        Console.SetCursorPosition(4, 19);
        //        Console.WriteLine("│    " + enemy2.name + " health: " + enemy2.currentHealth + "/" + enemy2.maxHealth + "   │");
        //        Console.SetCursorPosition(4, 20);
        //        Console.Write(hudBorderBottom);
        //    }
        //    else if (enemy3.attackedLast == true)
        //    {
        //        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.SetCursorPosition(4, 18);
        //        Console.Write(hudBorderTop);
        //        Console.SetCursorPosition(4, 19);
        //        Console.WriteLine("│    " + enemy3.name + " health: " + enemy3.currentHealth + "/" + enemy3.maxHealth + "   │");
        //        Console.SetCursorPosition(4, 20);
        //        Console.Write(hudBorderBottom);
        //    }
        //}

        public void DisplayHUD(Player player, Enemy enemy, Enemy2 enemy2, Enemy3 enemy3)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 15);
            Console.Write(hudBorderTop);
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("│    " + player.name + " health: " + player.currentHealth + "/" + player.maxHealth + "    │");
            Console.SetCursorPosition(4, 17);
            Console.Write(hudBorderBottom);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 18);
            Console.Write(hudBorderTop);
            Console.SetCursorPosition(4, 19);
            Console.WriteLine("│    " + enemy.name + " health: " + enemy.currentHealth + "/" + enemy.maxHealth + "   │");
            Console.SetCursorPosition(4, 20);
            Console.Write(hudBorderBottom);

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 21);
            Console.Write(hudBorderTop);
            Console.SetCursorPosition(4, 22);
            Console.WriteLine("│    " + enemy2.name + " health: " + enemy2.currentHealth + "/" + enemy2.maxHealth + "   │");
            Console.SetCursorPosition(4, 23);
            Console.Write(hudBorderBottom);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 24);
            Console.Write(hudBorderTop);
            Console.SetCursorPosition(4, 25);
            Console.WriteLine("│    " + enemy3.name + " health: " + enemy3.currentHealth + "/" + enemy3.maxHealth + "   │");
            Console.SetCursorPosition(4, 26);
            Console.Write(hudBorderBottom);
            // -------------------------------------------------------------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 16);
            Console.WriteLine("  " + player.name + " CORDS: " + player.currentPosX + ", " + player.currentPosY + "                              ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 19);
            Console.WriteLine("  " + enemy.name + "  CORDS: " + enemy.currentPosX + ", " + enemy.currentPosY + "                              ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 22);
            Console.WriteLine("  " + enemy2.name + "  CORDS: " + enemy2.currentPosX + ", " + enemy2.currentPosY + "                              ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 25);
            Console.WriteLine("  " + enemy3.name + "  CORDS: " + enemy3.currentPosX + ", " + enemy3.currentPosY + "                              ");


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
