using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Player
    {
        static int x;
        static int y;
        static char input;

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


            if (input == 'w')
            {
                y--;
                if (y <= northWall)
                {
                    y++;
                }
            }
            else if (input == 's')
            {
                y++;
                if (y >= southWall)
                {
                    y--;
                }
            }
            else if (input == 'a')
            {
                x--;
                if (x <= westWall)
                {
                    x++;
                }
            }
            else if (input == 'd')
            {
                x++;
                if (x >= eastWall)
                {
                    x--;
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
