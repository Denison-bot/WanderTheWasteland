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

        public void PlayerInit()
        {
            x = 5;
            y = 5;
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

            if (input == 'w')
            {
                y--;
            }
            else if (input == 's')
            {
                y++;
            }
            else if (input == 'a')
            {
                x--;
            }
            else if (input == 'd')
            {
                x++;
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
