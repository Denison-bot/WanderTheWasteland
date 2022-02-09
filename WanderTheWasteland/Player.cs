using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Player
    {
        static char input;
        static int x;
        static int y;
        static int intendedPosX;
        static int intendedPosY;
        static int previousPosX;
        static int previousPosY;


        // map size
        static int northWall;
        static int eastWall;
        static int southWall;
        static int westWall;

        public void PlayerInit()
        {
            x = 2;
            y = 2;
        }

        public void Draw()
        {
            //Console.Clear();
            intendedPosX = x;
            intendedPosY = y;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("@");
        }
        
        public void Update(ref bool gameOver)
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            northWall = 0;
            eastWall = 39;
            southWall = 15;
            westWall = 0;
            previousPosX = x;
            previousPosY = y;

            if (input == 'w')
            {
                intendedPosY--;
                if (y <= northWall)
                {
                    intendedPosY++;
                }
            }
            else if (input == 's')
            {
                intendedPosY++;
                if (y >= southWall)
                {
                    intendedPosY--;
                }
            }
            else if (input == 'a')
            {
                intendedPosX--;
                if (x <= westWall)
                {
                    intendedPosX++;
                }
            }
            else if (input == 'd')
            {
                intendedPosX++;
                if (x >= eastWall)
                {
                    intendedPosX--;
                }
            }
            else if (input == 'p')
            {
                gameOver = true;
            }
        }

        public void QuitCheck(ref bool gameOver)
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            if (input == 'p')
            {
                 gameOver = true;
            }
        }
    }
}
