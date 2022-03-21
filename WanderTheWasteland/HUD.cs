using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    // ATTACKEDLAST BOOL DOES NOT RESET TO FALSE AFTER COMBAT HHHHHHHHHH 

    // I attempted to get the HUD working, but I'm genuinely at a loss 
    // I left the DisplayHUD active because it WORKS
    // Enable DisplayModularHUD if you'd like to see, but the HUD will prioritize whatever comes first in the method
    class HUD
    {
        string hudBorderTop = "┌──────────────────────────────────────────┐";
        string hudBorderBottom = "└──────────────────────────────────────────┘";
        string colorHUDTop = "┌────────────────────────────┐";
        string colorHUDBottom = "└────────────────────────────┘";
        public string action = "";
        
        int actionLength;
        int hudLength;
        
        public void DisplayBorder()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 15);
            Console.Write(hudBorderTop);
            Console.SetCursorPosition(0, 16);
            UpdateInfo();
            Console.Write(hudBorderBottom);
        }
        public void UpdateInfo()
        {
            actionLength = action.Length;
            hudLength = colorHUDTop.Length;

            Console.Write("│");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(action);
            if (actionLength < hudLength)
            {
                for (int i = actionLength; i < hudLength + 10; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("│");
            }
            if (actionLength > hudLength)
            {
                Console.WriteLine();
            }
        }

        //public void DisplayModularHUD(Player player)
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

        //}

        public void DisplayHUD(Player player, RandomMoveEnemy randomMoveEnemy, VerticalSetEnemy verticalSetEnemy, TrackingEnemy trackingEnemy)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 18);
            Console.Write(colorHUDTop);
            Console.SetCursorPosition(4, 19);
            Console.WriteLine("│    " + player.name + " health: " + player.currentHealth + "/" + player.maxHealth + "      │");
            Console.SetCursorPosition(4, 20);
            Console.Write(colorHUDBottom);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 21);
            Console.Write(colorHUDTop);
            Console.SetCursorPosition(4, 22);
            Console.WriteLine("│ " + randomMoveEnemy.name + " health: " + randomMoveEnemy.currentHealth + "/" + randomMoveEnemy.maxHealth + "   │");
            Console.SetCursorPosition(4, 23);
            Console.Write(colorHUDBottom);

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 24);
            Console.Write(colorHUDTop);
            Console.SetCursorPosition(4, 25);
            Console.WriteLine("│ " + verticalSetEnemy.name + " health: " + verticalSetEnemy.currentHealth + "/" + verticalSetEnemy.maxHealth + " │");
            Console.SetCursorPosition(4, 26);
            Console.Write(colorHUDBottom);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 27);
            Console.Write(colorHUDTop);
            Console.SetCursorPosition(4, 28);
            Console.WriteLine("│ " + trackingEnemy.name + " health: " + trackingEnemy.currentHealth + "/" + trackingEnemy.maxHealth + " │");
            Console.SetCursorPosition(4, 29);
            Console.Write(colorHUDBottom);
            // -------------------------------------------------------------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 19);
            Console.WriteLine("CORDS: " + player.currentPosX + ", " + player.currentPosY + "                              ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 22);
            Console.WriteLine("CORDS: " + randomMoveEnemy.currentPosX + ", " + randomMoveEnemy.currentPosY + "                              ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 25);
            Console.WriteLine("CORDS: " + verticalSetEnemy.currentPosX + ", " + verticalSetEnemy.currentPosY + "                              ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 28);
            Console.WriteLine("CORDS: " + trackingEnemy.currentPosX + ", " + trackingEnemy.currentPosY + "                                          ");
        }
    }
}

// ---------------------------------------------------------------------------------------------------

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

//public void DisplayHUD(Player player, RandomMoveEnemy randomMoveEnemy, VerticalSetEnemy verticalSetEnemy, TrackingEnemy trackingEnemy)
//{

//    Console.BackgroundColor = ConsoleColor.DarkBlue;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(4, 15);
//    Console.Write(hudBorderTop);
//    Console.SetCursorPosition(4, 16);
//    Console.WriteLine("│    " + player.name + " health: " + player.currentHealth + "/" + player.maxHealth + "    │");
//    Console.SetCursorPosition(4, 17);
//    Console.Write(hudBorderBottom);

//    Console.BackgroundColor = ConsoleColor.DarkRed;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(4, 18);
//    Console.Write(hudBorderTop);
//    Console.SetCursorPosition(4, 19);
//    Console.WriteLine("│ " + randomMoveEnemy.name + " health: " + randomMoveEnemy.currentHealth + "/" + randomMoveEnemy.maxHealth + " │");
//    Console.SetCursorPosition(4, 20);
//    Console.Write(hudBorderBottom);

//    Console.BackgroundColor = ConsoleColor.DarkYellow;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(4, 21);
//    Console.Write(hudBorderTop);
//    Console.SetCursorPosition(4, 22);
//    Console.WriteLine("│    " + verticalSetEnemy.name + " health: " + verticalSetEnemy.currentHealth + "/" + verticalSetEnemy.maxHealth + "   │");
//    Console.SetCursorPosition(4, 23);
//    Console.Write(hudBorderBottom);

//    Console.BackgroundColor = ConsoleColor.DarkMagenta;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(4, 24);
//    Console.Write(hudBorderTop);
//    Console.SetCursorPosition(4, 25);
//    Console.WriteLine("│    " + trackingEnemy.name + " health: " + trackingEnemy.currentHealth + "/" + trackingEnemy.maxHealth + "   │");
//    Console.SetCursorPosition(4, 26);
//    Console.Write(hudBorderBottom);
//    // -------------------------------------------------------------------------------------------------------------
//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(38, 16);
//    Console.WriteLine("  " + player.name + " CORDS: " + player.currentPosX + ", " + player.currentPosY + "                              ");

//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(38, 19);
//    Console.WriteLine("  " + randomMoveEnemy.name + "  CORDS: " + randomMoveEnemy.currentPosX + ", " + randomMoveEnemy.currentPosY + "                              ");

//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(38, 22);
//    Console.WriteLine("  " + verticalSetEnemy.name + "  CORDS: " + verticalSetEnemy.currentPosX + ", " + verticalSetEnemy.currentPosY + "                              ");

//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.SetCursorPosition(38, 25);
//    Console.WriteLine("  " + trackingEnemy.name + "  CORDS: " + trackingEnemy.currentPosX + ", " + trackingEnemy.currentPosY + "                              ");


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

//}
